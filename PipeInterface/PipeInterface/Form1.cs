using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CColor = System.Drawing.Color;

using Ozeki.Camera;
using Ozeki.Media;

namespace PipeInterface
{
    public delegate void GlobalMouseClickEventHander(object sender, MouseEventArgs e);
    
    public partial class Form1 : Form
    {

        int NumOverlayText = 20;

        private OzekiCamera _camera;
        //private IIPCamera _camera;
        private DrawingImageProvider _imageProvider;
        private MediaConnector _connector;
        private CameraURLBuilderWF _myCameraUrlBuilder;
        public TextOverlay[] _textOverlay = new TextOverlay[20];
        private VideoViewerWF videoViewerWf1;
        private SnapshotHandler _snapshotHandler;
        private MPEG4Recorder _mpeg4Recorder;

        int xMouse = 0, yMouse = 0;
        public Form1()
        {
            InitializeComponent();

            this.bt_rocker_2_L.MouseDown += new MouseEventHandler(this.bt_rocker_2_L_MouseDown);
            this.bt_rocker_2_L.MouseUp += new MouseEventHandler(this.bt_rocker_2_L_MouseUp);
            this.bt_rocker_2_R.MouseDown += new MouseEventHandler(this.bt_rocker_2_R_MouseDown);
            this.bt_rocker_2_R.MouseUp += new MouseEventHandler(this.bt_rocker_2_R_MouseUp);
            this.bt_rocker_2_U.MouseDown += new MouseEventHandler(this.bt_rocker_2_U_MouseDown);
            this.bt_rocker_2_U.MouseUp += new MouseEventHandler(this.bt_rocker_2_U_MouseUp);
            this.bt_rocker_2_D.MouseDown += new MouseEventHandler(this.bt_rocker_2_D_MouseDown);
            this.bt_rocker_2_D.MouseUp += new MouseEventHandler(this.bt_rocker_2_D_MouseUp);

            //label3.Parent = pictureBox4;

            _connector = new MediaConnector();
            _imageProvider = new DrawingImageProvider();
            _snapshotHandler = new SnapshotHandler();
            //videoViewerWf1.SetImageProvider(_imageProvider);
            _myCameraUrlBuilder = new CameraURLBuilderWF();

            videoViewerWf1 = new VideoViewerWF();
            videoViewerWf1.Select();

            SetVideoViewer();

            for (int n = 0; n < NumOverlayText; n++)
            {
                _textOverlay[n] = new TextOverlay();

                _textOverlay[n].Text = "";
                _textOverlay[n].Font = new Font("Times" ,18, FontStyle.Bold);
                _textOverlay[n].Brush = System.Drawing.Brushes.Green;
            }
            
            //_textOverlay2 = new TextOverlay();
            //_textOverlay2.Text = "Hallo";
            //_textOverlay2.Font = new Font("Times", 24);
            //_textOverlay2.Brush = Brushes.Blue;
            //_textOverlay2.X = 10;
            //_textOverlay2.Y = 10;

            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Location = new Point(-10, 0);
            BindControlMouseClicks(this);

        }
        
        
        int ClickCount = 0, showListBoxCount = 100;

        FontStyle cFontStyle;
        String[] FontName = { "Arial", "AirCut", "Arial Black", "Comic Sans MS", "Times New Roman" };
        private void changeFontOverlay() {
            if (MyGlobals.FontChangeMode == 1)
            {
                var FormSetting = new SettingForm();
                switch (MyGlobals.FontStyle1)
                {
                    case 0:
                        cFontStyle = FontStyle.Regular;
                        break;
                    case 1:
                        cFontStyle = FontStyle.Bold;
                        break;
                    case 2:
                        cFontStyle = FontStyle.Italic;
                        break;
                    case 3:
                        cFontStyle = FontStyle.Strikeout;
                        break;
                    case 4:
                        cFontStyle = FontStyle.Underline;
                        break;
                }
                for (int n = 0; n < NumOverlayText; n++)
                {
                    _textOverlay[n].Font = new Font(FontName[MyGlobals.FontName1], Convert.ToInt16(MyGlobals.FontSize1), cFontStyle);
                    //var ColorFont = (Color)System.Drawing.ColorConverter.ConvertFromString(MyGlobals.FontColor);
                    _textOverlay[n].Brush = new SolidBrush(Color.FromArgb(MyGlobals.FontColor));
                }
                MyGlobals.FontChangeMode = 0;
            }
        }
        private void changeFontDate()
        {
            if (MyGlobals.FontChangeMode2 == 1)
            {
                var FormSetting = new SettingForm();
                switch (MyGlobals.FontStyle2)
                {
                    case 0:
                        cFontStyle = FontStyle.Regular;
                        break;
                    case 1:
                        cFontStyle = FontStyle.Bold;
                        break;
                    case 2:
                        cFontStyle = FontStyle.Italic;
                        break;
                    case 3:
                        cFontStyle = FontStyle.Strikeout;
                        break;
                    case 4:
                        cFontStyle = FontStyle.Underline;
                        break;
                }
                dateLabel.Font = new Font(FontName[MyGlobals.FontName2], Convert.ToInt16(MyGlobals.FontSize2), cFontStyle);
                dateLabel.ForeColor = Color.FromArgb(MyGlobals.FontColor2);
                MyGlobals.FontChangeMode2 = 0;

                dateLabel.Location = new Point(dateLabel.Location.X, CameraBox.Height - dateLabel.Height);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            changeFontOverlay();
            changeFontDate();
            dateLabel.Text = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + " | " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "  -  " + statelabel.Text;
            
            xMouse = Cursor.Position.X - this.Left - this.CameraBox.Location.X - 10;
            yMouse = Cursor.Position.Y - this.Top - this.CameraBox.Location.Y - 34;

            CountOverlayMode++;
            //label1.Text = Cursor.Position.X.ToString() + " : " + this.Top.ToString() + " : " + xMouse.ToString() + " : " + this.CameraBox.Location.X.ToString();
            //label2.Text = Cursor.Position.Y.ToString() + " : " + this.Left.ToString() + " : " + yMouse.ToString() + " : " + this.CameraBox.Location.Y.ToString();
          
            //if(modeFontOverlay == 0)
                //countShowText --;

            if (countShowText <= 0)
            {
                groupBoxOverlay.Visible = false;
                countShowText = 0;
            }
            if (ClickCount > 0)
            {
                _textOverlay[ClickCount - 1].X = OverlayPointX;
                _textOverlay[ClickCount - 1].Y = OverlayPointY;
            }

            if (playbackGB.Visible == true)
            {
                if (ImageViewMode == 0)
                {
                    showListBoxCount--;
                    button1.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }

                if (showListBoxCount <= 0)
                {
                    listBox1.Enabled = false;
                    listBox2.Enabled = false;
                    showListBoxCount = 0;
                    if (listBox1.Width > 0)
                    {
                        listBox1.Width -= 10;
                        listBox2.Width = listBox1.Width;
                        listBox1.Location = new Point(listBox1.Location.X + 10, listBox1.Location.Y);
                        listBox2.Location = new Point(listBox2.Location.X + 10, listBox2.Location.Y);
                    }
                    button2.Text = "Show";
                    iShow = 1;
                }
                else {
                    if (listBox1.Width < 240)
                    {
                        listBox1.Width += 10;
                        listBox2.Width = listBox1.Width;
                        listBox1.Location = new Point(listBox1.Location.X - 10, listBox1.Location.Y);
                        listBox2.Location = new Point(listBox2.Location.X - 10, listBox2.Location.Y);
                    }
                    else {

                        listBox1.Enabled = true;
                        listBox2.Enabled = true;
                    }
                    button2.Text = "Hide";
                    iShow = 0;
                }
            }

            DragButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyGlobals.FontColor = Color.Black.ToArgb();
            MyGlobals.FontColor2 = Color.Black.ToArgb();

            timer1.Start();
            timer1.Interval = 5;
            //timer2.Start();
            //timer2.Interval = 10;

            this.fontStyleComboBox.Items.AddRange(new string[] { "Regular", "Bold", "Italic", "BoldItalic", "Underline" });
            this.fontStyleComboBox.SelectedIndex = 0;

            this.fontNameComboBox.Items.AddRange(new string[] { "Arial", "AirCut", "Arial Black", "Comic Sans MS", "Times New Roman" });
            this.fontNameComboBox.SelectedIndex = 0;
            
            lb_Position.Parent = CameraBox;

            var pos = this.PointToScreen(MoveButton.Location);
            pos = pictureBoxButton.PointToClient(pos);
            MoveButton.Parent = pictureBoxButton;
            MoveButton.Location = pos;
            MoveButton.BackColor = Color.Transparent;

            for (int i = 8; i <= 60; i += 2)
            {
                this.fontSizeComboBox.Items.Add(i);
            }
            this.fontSizeComboBox.SelectedIndex = 2;

            CreateDirectory();

            ClickCount = 0;
        }

        #region video viewer command
        private void SetVideoViewer()
        {
            CameraBox.Controls.Add(videoViewerWf1);
            videoViewerWf1.Size = new Size(CameraBox.Size.Width, CameraBox.Size.Height);
            videoViewerWf1.BackColor = System.Drawing.Color.Black;
            videoViewerWf1.TabStop = false;
            videoViewerWf1.Location = new Point(0, 0);
            videoViewerWf1.Name = "_videoViewerWf";

        }
        private void connectBtn_Click(object sender, EventArgs e)
        {
            var result = _myCameraUrlBuilder.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            btn_Disconnect.Enabled = false;
            btn_Connect.Enabled = true;
            connectBtn.Enabled = false;

            tb_cameraUrl.Text = _myCameraUrlBuilder.CameraURL;
            

            ClickCount = 0;
        }
        int CameraMode = 0;
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            var settingForm = new SettingForm();
            NumOverlayText = MyGlobals.MaxTextOverlayNum;
            Bridge.MaxNumTextEdit = 0;


            //_camera = IPCameraFactory.GetCamera("192.168.16.119:80", "admin", "admin", CameraTransportType.TCP);

            CameraMode = 1;
            if (_camera != null)
            {
                _camera.CameraStateChanged -= _camera_CameraStateChanged;
                _camera.Disconnect();
                _connector.Disconnect(_camera.VideoChannel, _imageProvider);
                _camera.Dispose();
                _camera = null;

            }

            _camera = new OzekiCamera(_myCameraUrlBuilder.CameraURL);

            _camera.CameraStateChanged += _camera_CameraStateChanged;

            _connector.Connect(_camera.VideoChannel, _textOverlay[0]);
            for (int n = 1; n < NumOverlayText; n++)
            {
                _connector.Connect(_textOverlay[n - 1], _textOverlay[n]);
            }
            _connector.Connect(_textOverlay[NumOverlayText - 1], _imageProvider);

            _connector.Connect(_camera.VideoChannel, _textOverlay[0]);
            for (int n = 1; n < NumOverlayText; n++)
            {
                _connector.Connect(_textOverlay[n - 1], _textOverlay[n]);
            }
            _connector.Connect(_textOverlay[NumOverlayText - 1], _snapshotHandler);

            //_connector.Connect(_camera.VideoChannel, _snapshotHandler);
            //_connector.Connect(_camera.VideoChannel, _textOverlay2);
            //_connector.Connect(_textOverlay2, _imageProvider);

            for (int n = 0; n < NumOverlayText; n++)
            {
                _textOverlay[n].Start();
            }
            //_textOverlay2.Start();

            videoViewerWf1.SetImageProvider(_imageProvider);
            videoViewerWf1.Start();
            _camera.Start();

            btn_Connect.Enabled = false;
            btn_Disconnect.Enabled = true;
        }
        void _camera_CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            InvokeThread(() =>
            {
                statelabel.Text = e.State.ToString();

                if (e.State == CameraState.Streaming)
                {
                    Streaming();
                }


                if (e.State == CameraState.Disconnected)
                    Disconnect();

            });
        }
        private void Disconnect()
        {
            btn_Connect.Enabled = true;
            btn_Disconnect.Enabled = false;

        }
        private void Streaming()
        {
            btn_Connect.Enabled = false;
            btn_Disconnect.Enabled = true;

        }
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {

            var settingForm = new SettingForm();
            Bridge.MaxNumTextEdit = 1;
            //ClickCount = 0;

            if (_camera == null) return;

            _camera.Disconnect();
            _connector.Disconnect(_camera.VideoChannel, _textOverlay[0]);
            for (int n = 1; n < NumOverlayText; n++)
            {
                _connector.Disconnect(_textOverlay[n - 1], _textOverlay[n]);
            }
            _connector.Disconnect(_textOverlay[NumOverlayText - 1], _imageProvider);
            _camera = null;
            for (int n = 1; n < NumOverlayText; n++)
            {
                _textOverlay[n].Stop();
            }

            btn_Connect.Enabled = true;
            btn_Disconnect.Enabled = false;
            connectBtn.Enabled = true;
        }
        void InvokeThread(Action action)
        {
            BeginInvoke(action);
        }

        #endregion
        
        #region Trigger Click Command

        [Category("Action")]
        [Description("Fires when any control on the form is clicked.")]
        public event GlobalMouseClickEventHander GlobalMouseClick;
        private void BindControlMouseClicks(Control con)
        {
            con.MouseClick += delegate (object sender, MouseEventArgs e)
            {
                TriggerMouseClicked(sender, e);
            };
            // bind to controls already added
            foreach (Control i in con.Controls)
            {
                BindControlMouseClicks(i);
            }
            // bind to controls added in the future
            con.ControlAdded += delegate (object sender, ControlEventArgs e)
            {
                BindControlMouseClicks(e.Control);
            };
        }
        int OverlayPointX = 0, OverlayPointY = 0;

        private void btCamera_Click(object sender, EventArgs e)
        {
            CountOverlayMode = 0;
            CameraMode = 1;
            playbackGB.Visible = false;
            dateLabel.Visible = true;
        }
        int CountOverlayMode = 0;
        private void TriggerMouseClicked(object sender, MouseEventArgs e)
        {
            int xPos;
            if (GlobalMouseClick != null)
            {
                GlobalMouseClick(sender, e);
            }
            if ((xMouse > 0 && xMouse < CameraBox.Size.Width) && (yMouse >25 && yMouse < CameraBox.Size.Height) && groupBoxOverlay.Visible == false 
                && playbackGB.Visible == false && CameraMode == 1 && CountOverlayMode >= 5) {
                //MessageBox.Show("Try");
                CountOverlayMode = 5;
                if (xMouse > CameraBox.Width - groupBoxOverlay.Width)
                {
                    xPos = CameraBox.Width - groupBoxOverlay.Width;
                }
                else
                {
                    xPos = xMouse;
                }
                groupBoxOverlay.Location = new Point(xPos, yMouse);
                countShowText = 300;
                groupBoxOverlay.Visible = true;
                groupBoxFontOverlay.Visible = false;

                OverlayPointX = (int)((double)(xMouse*0.89));
                OverlayPointY = (int)((double)(yMouse*0.93))-25;

                ClickCount++;
                if (ClickCount > NumOverlayText) {
                    ClickCount = NumOverlayText;
                }
                text_OverlayText.Text = "";
            }
        }
        #endregion

        #region Playback Command

        string[] file, paths, paths2;
        private void playback_Click(object sender, EventArgs e)
        {
            CameraMode = 0;
            playbackGB.Visible = true;
            dateLabel.Visible = false;
            showListBoxCount = 300;
            ImageViewMode = 1;
            PopulateListBox(listBox1, MyGlobals.SaveVideo, "*.mp4",
                listBox2, MyGlobals.SaveImage, "*.jpg");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        int iShow = 0;
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            if (iShow == 0)
            {
                //listBox1.Hide();
                showListBoxCount = 0;
                button2.Text = "Show";
                iShow = 1;
            }
            else
            {
                listBox1.Show();
                listBox2.Show();
                button2.Text = "Hide";
                showListBoxCount = 300;
                iShow = 0;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            String[] path;
            if (ImageViewMode == 0)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file = openFileDialog1.SafeFileNames;
                    path = openFileDialog1.FileNames;
                    int k = listBox1.Items.Count;
                    for (int i = 0; i < path.Length; i++)
                    {
                        if (!listBox1.Items.Contains(file[i]))
                        {
                            listBox1.Items.Add(file[i]);
                            paths[k] = path[i];
                            k++;
                        }
                    }
                }
            }else if (ImageViewMode == 1)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file = openFileDialog1.SafeFileNames;
                    path = openFileDialog1.FileNames;
                    int k = listBox2.Items.Count;
                    for (int i = 0; i < path.Length; i++)
                    {
                        if (!listBox2.Items.Contains(file[i]))
                        {
                            listBox2.Items.Add(file[i]);
                            paths2[k] = path[i];
                            k++;
                        }
                    }
                }
            }
        }
        private void PopulateListBox(ListBox lsb1, string Folder1, string FileType1, 
            ListBox lsb2, string Folder2, string FileType2)
        {
            int i = 0;
            paths = new string[100];
            paths2 = new string[100];
            lsb1.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(Folder1);
            FileInfo[] Files = dinfo.GetFiles(FileType1);
            foreach (FileInfo file in Files)
            {
                lsb1.Items.Add(file.Name);
                paths[i] = file.FullName;
                i++;
            }
            i = 0;
            lsb2.Items.Clear();
            dinfo = new DirectoryInfo(Folder2);
            Files = dinfo.GetFiles(FileType2);
            foreach (FileInfo file in Files)
            {
                lsb2.Items.Add(file.Name);
                paths2[i] = file.FullName;
                i++;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (iShow == 0)
            {
                //listBox1.Hide();
                showListBoxCount = 0;
                button2.Text = "Show";
                iShow = 1;
            }
            else
            {
                listBox1.Show();
                button2.Text = "Hide";
                showListBoxCount = 300;
                iShow = 0;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPlayback.Visible = false;
            showListBoxCount = 100;
            ImageViewMode = 0;
            ViewMode.Text = "Video";
            if (listBox1.SelectedIndex == -1) return;
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
        }
        int ImageViewMode = 0;
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageViewMode = 1;
            pictureBoxPlayback.Visible = true;
            ViewMode.Text = "Image";
            if (listBox2.SelectedIndex == -1) return;
            pictureBoxPlayback.Image = Image.FromFile(paths2[listBox2.SelectedIndex]);
            pictureBoxPlayback.SizeMode = PictureBoxSizeMode.Zoom;
        }
        #endregion

        #region Rocker Button

        private void button7_Click(object sender, EventArgs e)
        {
        }
        private void bt_rocker_2_L_MouseDown(object sender, MouseEventArgs e)
        {
            this.ImageBTRocker2.Image = Properties.Resources.rocker_left;
            this.bt_rocker_2_L.Image = ((System.Drawing.Image)(Properties.Resources.rocker_leftBT));
            bt_rocker_2_U.Visible = false;
            bt_rocker_2_D.Visible = false;
        }
        private void bt_rocker_2_L_MouseUp(object sender, MouseEventArgs e)
        {
            this.ImageBTRocker2.Image = Properties.Resources.rocker_normal;
            this.bt_rocker_2_L.Image = ((System.Drawing.Image)(Properties.Resources.rocker_normal_leftBT));
            bt_rocker_2_U.Visible = true;
            bt_rocker_2_D.Visible = true;
        }
        private void bt_rocker_2_R_MouseDown(object sender, MouseEventArgs e)
        {
            this.ImageBTRocker2.Image = Properties.Resources.rocker_right;
            this.bt_rocker_2_R.Image = ((System.Drawing.Image)(Properties.Resources.rocker_rightBT));
            bt_rocker_2_U.Visible = false;
            bt_rocker_2_D.Visible = false;
        }
        private void bt_rocker_2_R_MouseUp(object sender, MouseEventArgs e)
        {
            this.ImageBTRocker2.Image = Properties.Resources.rocker_normal;
            this.bt_rocker_2_R.Image = ((System.Drawing.Image)(Properties.Resources.rocker_normal_rightBT));
            bt_rocker_2_U.Visible = true;
            bt_rocker_2_D.Visible = true;
        }
        private void bt_rocker_2_U_MouseDown(object sender, MouseEventArgs e)
        {
            this.ImageBTRocker2.Image = Properties.Resources.rocker_up;
            this.bt_rocker_2_U.Image = ((System.Drawing.Image)(Properties.Resources.rocker_upBT));
            bt_rocker_2_L.Visible = false;
            bt_rocker_2_R.Visible = false;
        }
        private void bt_rocker_2_U_MouseUp(object sender, MouseEventArgs e)
        {
            this.ImageBTRocker2.Image = Properties.Resources.rocker_normal;
            this.bt_rocker_2_U.Image = ((System.Drawing.Image)(Properties.Resources.rocker_normal_upBT));
            bt_rocker_2_L.Visible = true;
            bt_rocker_2_R.Visible = true;
        }
        private void bt_rocker_2_D_MouseDown(object sender, MouseEventArgs e)
        {
            this.ImageBTRocker2.Image = Properties.Resources.rocker_down;
            this.bt_rocker_2_D.Image = ((System.Drawing.Image)(Properties.Resources.rocker_downBT));
            bt_rocker_2_L.Visible = false;
            bt_rocker_2_R.Visible = false;
        }
        private void bt_rocker_2_D_MouseUp(object sender, MouseEventArgs e)
        {
            this.ImageBTRocker2.Image = Properties.Resources.rocker_normal;
            this.bt_rocker_2_D.Image = ((System.Drawing.Image)(Properties.Resources.rocker_normal_downBT));
            bt_rocker_2_L.Visible = true;
            bt_rocker_2_R.Visible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Capture and SnapShot Video
        int CaptureMode = 0;
        private void button_CaptureVideo1Start_Click(object sender, EventArgs e)
        {
            if (CaptureMode == 0)
            {
                //TextBox_SaveTo.Text = "C:\\Users\\Azhar Aulia Saputra\\Documents\\Saved Data\\Video";
                var path = MyGlobals.SaveVideo;// TextBox_SaveTo.Text;
                if (!String.IsNullOrEmpty(path))
                    StartVideoCapture(path);
                button_CaptureVideo1Start.Text = "Stop Capture";
                CaptureMode = 1;
                playback.Enabled = false;
                btCurve.Enabled = false;
                btLaser.Enabled = false;
                btCondition.Enabled = false;
                btSetting.Enabled = false;

            }
            else {
                StopVideoCapture();
                button_CaptureVideo1Start.Text = "Start Capture";
                CaptureMode = 0;
                playback.Enabled = true;
                btCurve.Enabled = true;
                btLaser.Enabled = true;
                btCondition.Enabled = true;
                btSetting.Enabled = true;
            }   
        }
        private void StartVideoCapture(string path)
        {
            
            var date = "Video_on_" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "_at_" +
                       DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;

            string currentpath;
            if (String.IsNullOrEmpty(path))
                currentpath = date + ".mp4";
            else
                currentpath = path + "\\" + date + ".mp4";

            _mpeg4Recorder = new MPEG4Recorder(currentpath);
            _mpeg4Recorder.MultiplexFinished += Mpeg4Recorder_MultiplexFinished;
            _connector.Connect(_camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
            _connector.Connect(_camera.VideoChannel, _textOverlay[0]);
            for (int n = 1; n < NumOverlayText; n++)
            {
                _connector.Connect(_textOverlay[n - 1], _textOverlay[n]);
            }
            _connector.Connect(_textOverlay[NumOverlayText-1], _mpeg4Recorder.VideoRecorder);
        }
        private void Mpeg4Recorder_MultiplexFinished(object sender, VoIPEventArgs<bool> e)
        {
            _connector.Disconnect(_camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
            //_connector.Disconnect(_camera.VideoChannel, _mpeg4Recorder.VideoRecorder);
            //_connector.Disconnect(_camera.VideoChannel, _textOverlay[0]);
            //for (int n = 1; n < NumOverlayText; n++)
            //{
            //    _connector.Disconnect(_textOverlay[n - 1], _textOverlay[n]);
            //}
            //_connector.Disconnect(_textOverlay[NumOverlayText - 1], _mpeg4Recorder.VideoRecorder);
            _mpeg4Recorder.Dispose();
        }
        private void StopVideoCapture()
        {
            if (_mpeg4Recorder != null)
            {
                _mpeg4Recorder.Multiplex();
                _connector.Disconnect(_camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
                //_connector.Disconnect(_camera.VideoChannel, _mpeg4Recorder.VideoRecorder);
                //_connector.Disconnect(_camera.VideoChannel, _textOverlay[0]);
                //for (int n = 1; n < NumOverlayText; n++)
                //{
                //    _connector.Disconnect(_textOverlay[n - 1], _textOverlay[n]);
                //}
                //_connector.Disconnect(_textOverlay[NumOverlayText-1], _mpeg4Recorder.VideoRecorder);
            }
        }
        private void button_SaveTo1_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                TextBox_SaveTo.Text = folderBrowserDialog1.SelectedPath;
            //TextBox_SaveTo.Text = "C:\\Users\\Azhar Aulia Saputra\\Documents";
        }
        private void Btn_Snapshot_Click(object sender, EventArgs e)
        {
            //TextBox_SaveTo.Text = "C:\\Users\\Azhar Aulia Saputra\\Documents\\Saved Data\\Picture";
            var path = MyGlobals.SaveImage;// TextBox_SaveTo.Text;
            CreateSnapShot(path);
        }
        private void CreateSnapShot(string path)
        {
            var date = "Image_" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "_" +
                       DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;
            //var date = DateTime.Now.Year + "y-" + DateTime.Now.Month + "m-" + DateTime.Now.Day + "d-" +
            //       DateTime.Now.Hour + "h-" + DateTime.Now.Minute + "m-" + DateTime.Now.Second + "s";
            string currentpath;
            if (String.IsNullOrEmpty(path))
                currentpath = date + ".jpg";
            else
                currentpath = path + "\\" + date + ".jpg";

            var snapShotImage = _snapshotHandler.TakeSnapshot().ToImage();
            snapShotImage.Save(currentpath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        private void CreateDirectory()
        {
            // Specify the directory you want to manipulate.
            string path1 = MyGlobals.SaveVideo;
            string path2 = MyGlobals.SaveImage;

            // Determine whether the directory exists.
            if (Directory.Exists(path1))
            {

            }
            else
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path1);
                //MessageBox.Show("The directory was created successfully");

            }
            if (Directory.Exists(path2))
            {

            }
            else
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path2);
                //MessageBox.Show("The directory was created successfully");

            }
        }

        #endregion

        #region In overlay command

        int countShowText = 0;
        private void text_OverlayText_TextChanged(object sender, EventArgs e)
        {
            if (groupBoxOverlay.Visible == true)
            {
                string text = text_OverlayText.Text;
                _textOverlay[ClickCount - 1].Text = text;
                countShowText = 150;
            }
        }
        private void OKbuttonOverlay_Click(object sender, EventArgs e)
        {
            countShowText = 0;
            modeFontOverlay = 0;
            groupBoxFontOverlay.Visible = false;
            if (text_OverlayText.Text == "") {
                ClickCount--;
            }
        }
        private void TextBox_SaveTo_TextChanged(object sender, EventArgs e)
        {

        }
        private void fontNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeFontOverlay == 1)
                _textOverlay[ClickCount - 1].Font = new Font(this.fontNameComboBox.Text, Convert.ToInt16(this.fontSizeComboBox.Text));
        }
        private void fontStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeFontOverlay == 1)
            {
                switch (fontStyleComboBox.SelectedIndex)
                {
                    case 0:
                        cFontStyle = FontStyle.Regular;
                        break;
                    case 1:
                        cFontStyle = FontStyle.Bold;
                        break;
                    case 2:
                        cFontStyle = FontStyle.Italic;
                        break;
                    case 3:
                        cFontStyle = FontStyle.Strikeout;
                        break;
                    case 4:
                        cFontStyle = FontStyle.Underline;
                        break;
                }
                _textOverlay[ClickCount - 1].Font = new Font(this.fontNameComboBox.Text, Convert.ToInt16(this.fontSizeComboBox.Text), cFontStyle);
            }
        }
        int modeFontOverlay = 0;
        private void FontButtonOverlay_Click(object sender, EventArgs e)
        {
            int xPos, yPos;
            if (modeFontOverlay == 0)
            {
                groupBoxFontOverlay.Visible = true;
                if (yMouse > CameraBox.Height / 2)
                {
                    yPos = groupBoxOverlay.Location.Y - groupBoxFontOverlay.Height;
                }
                else
                {
                    yPos = groupBoxOverlay.Location.Y + groupBoxOverlay.Height;
                }
                xPos = groupBoxOverlay.Location.X;
                groupBoxFontOverlay.Location = new Point(xPos, yPos);
                modeFontOverlay = 1;
                countShowText = 200;
            }
            else
            {
                groupBoxFontOverlay.Visible = false;
                modeFontOverlay = 0;
                countShowText = 200;

            }
        }


        private void fontColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                for (short i = 0; i < NumOverlayText; i++)
                {
                    //this.axVideoCap1.TextColor(i, this.Color2Uint32(this.colorDialog1.Color));
                    _textOverlay[ClickCount - 1].Brush = new SolidBrush(colorDialog1.Color);
                }
            }
        }
        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeFontOverlay == 1)
                _textOverlay[ClickCount - 1].Font = new Font(this.fontNameComboBox.Text, Convert.ToInt16(this.fontSizeComboBox.Text));
        }

        #endregion

        #region button drag 

        int Drag = 0;

        private void MoveButton_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = 0;
            xButton = pictureBoxButton.Width / 2;
            yButton = pictureBoxButton.Height / 2;

            MoveButton.Location = new Point(xButton - MoveButton.Width / 2, yButton - MoveButton.Height / 2);
            pictureBoxButton.Image = Properties.Resources.MoveBtnNormal;
        }

        private void MoveButton_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = 1;
            xRest = Cursor.Position.X - this.Left - pictureBoxButton.Location.X - MoveButton.Location.X - e.X;
            yRest = Cursor.Position.Y - this.Top - pictureBoxButton.Location.Y - MoveButton.Location.Y - e.Y;
            //MoveButton.DoDragDrop(MoveButton.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        int xButton, yButton;
        int xMoveBtn, yMoveBtn;
        int xRest = 0, yRest = 0;
        double Theta = 0, Theta2 = 0, zMove = 0;
        public void DragButton()
        {
            if (Drag == 1)
            {
                xButton = Cursor.Position.X - this.Left - xRest - pictureBoxButton.Location.X;// - pictureBoxButton.Width / 2;
                yButton = Cursor.Position.Y - this.Top - yRest - pictureBoxButton.Location.Y;// - pictureBoxButton.Width / 2;

                xMoveBtn = xButton - pictureBoxButton.Width / 2;
                yMoveBtn = yButton - pictureBoxButton.Height / 2;

                Theta = Math.Atan2((double)(xMoveBtn), (double)(yMoveBtn));
                Theta2 = Theta * 180 / Math.PI;
                zMove = Math.Sqrt(xMoveBtn * xMoveBtn + yMoveBtn * yMoveBtn);
                if (zMove > 40)
                {
                    xButton = pictureBoxButton.Width / 2 + (int)(40 * Math.Sin(Theta));
                    yButton = pictureBoxButton.Height / 2 + (int)(40 * Math.Cos(Theta));
                    MoveButton.Location = new Point(xButton - MoveButton.Width / 2, yButton - MoveButton.Height / 2);
                }
                else {
                    MoveButton.Location = new Point(xButton - MoveButton.Width / 2, yButton - MoveButton.Height / 2);
                }
                if (zMove > 20)
                {
                    if (Theta2 >= -22 && Theta2 < 23)
                    {
                        pictureBoxButton.Image = Properties.Resources.MoveBtn0;
                    }
                    else if (Theta2 >= 23 && Theta2 < 68)
                    {
                        pictureBoxButton.Image = Properties.Resources.MoveBtn45;
                    }
                    else if (Theta2 >= 68 && Theta2 < 113)
                    {
                        pictureBoxButton.Image = Properties.Resources.MoveBtn90;
                    }
                    else if (Theta2 >= 113 && Theta2 < 158)
                    {
                        pictureBoxButton.Image = Properties.Resources.MoveBtn135;
                    }
                    else if (Theta2 >= 158 || Theta2 < -158)
                    {
                        pictureBoxButton.Image = Properties.Resources.MoveBtn180;
                    }
                    else if (Theta2 >= -158 && Theta2 < -113)
                    {
                        pictureBoxButton.Image = Properties.Resources.MoveBtn225;
                    }
                    else if (Theta2 >= -113 && Theta2 < -68)
                    {
                        pictureBoxButton.Image = Properties.Resources.MoveBtn270;
                    }
                    else if (Theta2 >= -68 && Theta2 < -22)
                    {
                        pictureBoxButton.Image = Properties.Resources.MoveBtn315;
                    }
                }
                else {
                    pictureBoxButton.Image = Properties.Resources.MoveBtnNormal;
                }
                
                label1.Visible = true;
                label1.Text = xMoveBtn + " " + yMoveBtn + " " + xRest + " " + yRest + " " + Theta;
            }
            else {

            }
        }

        #endregion
        private void ViewMode_Click(object sender, EventArgs e)
        {
            if (ImageViewMode == 0)
            {
                ImageViewMode = 1;
                ViewMode.Text = "Image";
            }
            else if (ImageViewMode == 1)
            {
                ImageViewMode = 0;
                ViewMode.Text = "Video";
            }
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            Bridge.SettingOpen = 1;
            SettingForm SF = new SettingForm();
            SF.StartPosition = FormStartPosition.CenterParent;
            SF.ShowDialog();
            CountOverlayMode = 0;
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            Bridge.SettingOpen = 1;
            Version SF = new Version();
            SF.StartPosition = FormStartPosition.CenterParent;
            SF.ShowDialog();
            CountOverlayMode = 0;
        }

        
    }
}

