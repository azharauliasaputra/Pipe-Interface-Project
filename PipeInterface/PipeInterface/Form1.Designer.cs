namespace PipeInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectBtn = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.tb_cameraUrl = new System.Windows.Forms.TextBox();
            this.text_OverlayText = new System.Windows.Forms.TextBox();
            this.lb_Position = new System.Windows.Forms.Label();
            this.CameraBox = new System.Windows.Forms.GroupBox();
            this.groupBoxFontOverlay = new System.Windows.Forms.GroupBox();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.fontStyleLabel = new System.Windows.Forms.Label();
            this.fontColorLabel = new System.Windows.Forms.Label();
            this.fontStyleComboBox = new System.Windows.Forms.ComboBox();
            this.fontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.fontNameLabel = new System.Windows.Forms.Label();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontNameComboBox = new System.Windows.Forms.ComboBox();
            this.groupBoxOverlay = new System.Windows.Forms.GroupBox();
            this.FontButtonOverlay = new System.Windows.Forms.Button();
            this.OKbuttonOverlay = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.statelabel = new System.Windows.Forms.Label();
            this.playbackGB = new System.Windows.Forms.GroupBox();
            this.ViewMode = new System.Windows.Forms.Button();
            this.btCamera = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playback = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_CaptureVideo1Start = new System.Windows.Forms.Button();
            this.button_SaveTo1 = new System.Windows.Forms.Button();
            this.TextBox_SaveTo = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Btn_Snapshot = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btSetting = new System.Windows.Forms.Button();
            this.btCondition = new System.Windows.Forms.Button();
            this.btLaser = new System.Windows.Forms.Button();
            this.btCurve = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.pictureBoxButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayback = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_rocker_2_D = new System.Windows.Forms.Button();
            this.bt_rocker_2_U = new System.Windows.Forms.Button();
            this.bt_rocker_2_R = new System.Windows.Forms.Button();
            this.bt_rocker_2_L = new System.Windows.Forms.Button();
            this.ImageBTRocker2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CameraBox.SuspendLayout();
            this.groupBoxFontOverlay.SuspendLayout();
            this.groupBoxOverlay.SuspendLayout();
            this.playbackGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBTRocker2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(15, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(99, 23);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Compose";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Enabled = false;
            this.btn_Connect.Location = new System.Drawing.Point(15, 41);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(99, 23);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Enabled = false;
            this.btn_Disconnect.Location = new System.Drawing.Point(15, 70);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(99, 23);
            this.btn_Disconnect.TabIndex = 2;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // tb_cameraUrl
            // 
            this.tb_cameraUrl.Location = new System.Drawing.Point(911, 568);
            this.tb_cameraUrl.Name = "tb_cameraUrl";
            this.tb_cameraUrl.Size = new System.Drawing.Size(57, 20);
            this.tb_cameraUrl.TabIndex = 3;
            this.tb_cameraUrl.Visible = false;
            // 
            // text_OverlayText
            // 
            this.text_OverlayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_OverlayText.Location = new System.Drawing.Point(2, 2);
            this.text_OverlayText.Name = "text_OverlayText";
            this.text_OverlayText.Size = new System.Drawing.Size(100, 21);
            this.text_OverlayText.TabIndex = 7;
            this.text_OverlayText.TextChanged += new System.EventHandler(this.text_OverlayText_TextChanged);
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.BackColor = System.Drawing.Color.Transparent;
            this.lb_Position.Location = new System.Drawing.Point(895, 550);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(73, 13);
            this.lb_Position.TabIndex = 9;
            this.lb_Position.Text = "Label Position";
            // 
            // CameraBox
            // 
            this.CameraBox.BackColor = System.Drawing.Color.Silver;
            this.CameraBox.Controls.Add(this.groupBoxFontOverlay);
            this.CameraBox.Controls.Add(this.groupBoxOverlay);
            this.CameraBox.Controls.Add(this.dateLabel);
            this.CameraBox.Controls.Add(this.statelabel);
            this.CameraBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraBox.Location = new System.Drawing.Point(128, 15);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(720, 500);
            this.CameraBox.TabIndex = 10;
            this.CameraBox.TabStop = false;
            // 
            // groupBoxFontOverlay
            // 
            this.groupBoxFontOverlay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxFontOverlay.Controls.Add(this.fontColorButton);
            this.groupBoxFontOverlay.Controls.Add(this.fontStyleLabel);
            this.groupBoxFontOverlay.Controls.Add(this.fontColorLabel);
            this.groupBoxFontOverlay.Controls.Add(this.fontStyleComboBox);
            this.groupBoxFontOverlay.Controls.Add(this.fontSizeComboBox);
            this.groupBoxFontOverlay.Controls.Add(this.fontNameLabel);
            this.groupBoxFontOverlay.Controls.Add(this.fontSizeLabel);
            this.groupBoxFontOverlay.Controls.Add(this.fontNameComboBox);
            this.groupBoxFontOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFontOverlay.ForeColor = System.Drawing.Color.Black;
            this.groupBoxFontOverlay.Location = new System.Drawing.Point(29, 164);
            this.groupBoxFontOverlay.Name = "groupBoxFontOverlay";
            this.groupBoxFontOverlay.Size = new System.Drawing.Size(187, 113);
            this.groupBoxFontOverlay.TabIndex = 31;
            this.groupBoxFontOverlay.TabStop = false;
            this.groupBoxFontOverlay.Text = "Font";
            this.groupBoxFontOverlay.Visible = false;
            // 
            // fontColorButton
            // 
            this.fontColorButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColorButton.Location = new System.Drawing.Point(73, 88);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(110, 20);
            this.fontColorButton.TabIndex = 31;
            this.fontColorButton.Text = "Change";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // fontStyleLabel
            // 
            this.fontStyleLabel.AutoSize = true;
            this.fontStyleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontStyleLabel.Location = new System.Drawing.Point(10, 18);
            this.fontStyleLabel.Name = "fontStyleLabel";
            this.fontStyleLabel.Size = new System.Drawing.Size(54, 13);
            this.fontStyleLabel.TabIndex = 32;
            this.fontStyleLabel.Text = "Font Style";
            // 
            // fontColorLabel
            // 
            this.fontColorLabel.AutoSize = true;
            this.fontColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColorLabel.Location = new System.Drawing.Point(10, 89);
            this.fontColorLabel.Name = "fontColorLabel";
            this.fontColorLabel.Size = new System.Drawing.Size(55, 13);
            this.fontColorLabel.TabIndex = 30;
            this.fontColorLabel.Text = "Font Color";
            // 
            // fontStyleComboBox
            // 
            this.fontStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontStyleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontStyleComboBox.FormattingEnabled = true;
            this.fontStyleComboBox.Location = new System.Drawing.Point(74, 14);
            this.fontStyleComboBox.Name = "fontStyleComboBox";
            this.fontStyleComboBox.Size = new System.Drawing.Size(108, 20);
            this.fontStyleComboBox.TabIndex = 33;
            this.fontStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.fontStyleComboBox_SelectedIndexChanged);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontSizeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizeComboBox.FormattingEnabled = true;
            this.fontSizeComboBox.Location = new System.Drawing.Point(74, 63);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(108, 21);
            this.fontSizeComboBox.TabIndex = 37;
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeComboBox_SelectedIndexChanged);
            // 
            // fontNameLabel
            // 
            this.fontNameLabel.AutoSize = true;
            this.fontNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontNameLabel.Location = new System.Drawing.Point(10, 42);
            this.fontNameLabel.Name = "fontNameLabel";
            this.fontNameLabel.Size = new System.Drawing.Size(59, 13);
            this.fontNameLabel.TabIndex = 34;
            this.fontNameLabel.Text = "Font Name";
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizeLabel.Location = new System.Drawing.Point(10, 66);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(51, 13);
            this.fontSizeLabel.TabIndex = 36;
            this.fontSizeLabel.Text = "Font Size";
            // 
            // fontNameComboBox
            // 
            this.fontNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontNameComboBox.FormattingEnabled = true;
            this.fontNameComboBox.Location = new System.Drawing.Point(74, 38);
            this.fontNameComboBox.Name = "fontNameComboBox";
            this.fontNameComboBox.Size = new System.Drawing.Size(108, 21);
            this.fontNameComboBox.TabIndex = 35;
            this.fontNameComboBox.SelectedIndexChanged += new System.EventHandler(this.fontNameComboBox_SelectedIndexChanged);
            // 
            // groupBoxOverlay
            // 
            this.groupBoxOverlay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxOverlay.Controls.Add(this.FontButtonOverlay);
            this.groupBoxOverlay.Controls.Add(this.OKbuttonOverlay);
            this.groupBoxOverlay.Controls.Add(this.text_OverlayText);
            this.groupBoxOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOverlay.Location = new System.Drawing.Point(25, 138);
            this.groupBoxOverlay.Name = "groupBoxOverlay";
            this.groupBoxOverlay.Size = new System.Drawing.Size(191, 25);
            this.groupBoxOverlay.TabIndex = 30;
            this.groupBoxOverlay.TabStop = false;
            // 
            // FontButtonOverlay
            // 
            this.FontButtonOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontButtonOverlay.ForeColor = System.Drawing.Color.Black;
            this.FontButtonOverlay.Location = new System.Drawing.Point(145, 2);
            this.FontButtonOverlay.Name = "FontButtonOverlay";
            this.FontButtonOverlay.Size = new System.Drawing.Size(43, 21);
            this.FontButtonOverlay.TabIndex = 9;
            this.FontButtonOverlay.Text = "Font";
            this.FontButtonOverlay.UseVisualStyleBackColor = true;
            this.FontButtonOverlay.Click += new System.EventHandler(this.FontButtonOverlay_Click);
            // 
            // OKbuttonOverlay
            // 
            this.OKbuttonOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbuttonOverlay.ForeColor = System.Drawing.Color.Black;
            this.OKbuttonOverlay.Location = new System.Drawing.Point(102, 2);
            this.OKbuttonOverlay.Name = "OKbuttonOverlay";
            this.OKbuttonOverlay.Size = new System.Drawing.Size(43, 21);
            this.OKbuttonOverlay.TabIndex = 8;
            this.OKbuttonOverlay.Text = "OK";
            this.OKbuttonOverlay.UseVisualStyleBackColor = true;
            this.OKbuttonOverlay.Click += new System.EventHandler(this.OKbuttonOverlay_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.LightGray;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(0, 487);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 13);
            this.dateLabel.TabIndex = 24;
            this.dateLabel.Text = "label3";
            // 
            // statelabel
            // 
            this.statelabel.AutoSize = true;
            this.statelabel.BackColor = System.Drawing.Color.Transparent;
            this.statelabel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.statelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statelabel.Location = new System.Drawing.Point(59, 454);
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(39, 13);
            this.statelabel.TabIndex = 11;
            this.statelabel.Text = "Closed";
            this.statelabel.Visible = false;
            // 
            // playbackGB
            // 
            this.playbackGB.BackColor = System.Drawing.Color.Black;
            this.playbackGB.Controls.Add(this.ViewMode);
            this.playbackGB.Controls.Add(this.pictureBoxPlayback);
            this.playbackGB.Controls.Add(this.btCamera);
            this.playbackGB.Controls.Add(this.listBox2);
            this.playbackGB.Controls.Add(this.listBox1);
            this.playbackGB.Controls.Add(this.button6);
            this.playbackGB.Controls.Add(this.button1);
            this.playbackGB.Controls.Add(this.button5);
            this.playbackGB.Controls.Add(this.button2);
            this.playbackGB.Controls.Add(this.button4);
            this.playbackGB.Controls.Add(this.button3);
            this.playbackGB.Controls.Add(this.axWindowsMediaPlayer1);
            this.playbackGB.ForeColor = System.Drawing.Color.White;
            this.playbackGB.Location = new System.Drawing.Point(128, 15);
            this.playbackGB.Name = "playbackGB";
            this.playbackGB.Size = new System.Drawing.Size(720, 500);
            this.playbackGB.TabIndex = 14;
            this.playbackGB.TabStop = false;
            this.playbackGB.Text = "Playback";
            this.playbackGB.Visible = false;
            // 
            // ViewMode
            // 
            this.ViewMode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewMode.ForeColor = System.Drawing.Color.White;
            this.ViewMode.Location = new System.Drawing.Point(489, 463);
            this.ViewMode.Name = "ViewMode";
            this.ViewMode.Size = new System.Drawing.Size(55, 23);
            this.ViewMode.TabIndex = 26;
            this.ViewMode.Text = "Image";
            this.ViewMode.UseVisualStyleBackColor = false;
            this.ViewMode.Click += new System.EventHandler(this.ViewMode_Click);
            // 
            // btCamera
            // 
            this.btCamera.BackColor = System.Drawing.Color.Red;
            this.btCamera.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCamera.Location = new System.Drawing.Point(657, 463);
            this.btCamera.Name = "btCamera";
            this.btCamera.Size = new System.Drawing.Size(48, 25);
            this.btCamera.TabIndex = 16;
            this.btCamera.Text = "Close";
            this.btCamera.UseVisualStyleBackColor = false;
            this.btCamera.Click += new System.EventHandler(this.btCamera_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(470, 239);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(244, 199);
            this.listBox2.TabIndex = 24;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(470, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 225);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(11, 460);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 33);
            this.button6.TabIndex = 22;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(223, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(276, 463);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Pause";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(435, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(329, 463);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(382, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Browser";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(8, 14);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(706, 480);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(870, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(870, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playback
            // 
            this.playback.BackColor = System.Drawing.Color.LightGray;
            this.playback.Location = new System.Drawing.Point(551, 523);
            this.playback.Name = "playback";
            this.playback.Size = new System.Drawing.Size(86, 28);
            this.playback.TabIndex = 15;
            this.playback.Text = "Playback";
            this.playback.UseVisualStyleBackColor = false;
            this.playback.Click += new System.EventHandler(this.playback_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Media player";
            this.openFileDialog1.Multiselect = true;
            // 
            // button_CaptureVideo1Start
            // 
            this.button_CaptureVideo1Start.BackColor = System.Drawing.Color.LightGray;
            this.button_CaptureVideo1Start.Location = new System.Drawing.Point(127, 523);
            this.button_CaptureVideo1Start.Name = "button_CaptureVideo1Start";
            this.button_CaptureVideo1Start.Size = new System.Drawing.Size(86, 28);
            this.button_CaptureVideo1Start.TabIndex = 23;
            this.button_CaptureVideo1Start.Text = "Start Capture";
            this.button_CaptureVideo1Start.UseVisualStyleBackColor = false;
            this.button_CaptureVideo1Start.Click += new System.EventHandler(this.button_CaptureVideo1Start_Click);
            // 
            // button_SaveTo1
            // 
            this.button_SaveTo1.Location = new System.Drawing.Point(373, 560);
            this.button_SaveTo1.Name = "button_SaveTo1";
            this.button_SaveTo1.Size = new System.Drawing.Size(86, 28);
            this.button_SaveTo1.TabIndex = 25;
            this.button_SaveTo1.Text = "Save to:";
            this.button_SaveTo1.UseVisualStyleBackColor = true;
            this.button_SaveTo1.Click += new System.EventHandler(this.button_SaveTo1_Click);
            // 
            // TextBox_SaveTo
            // 
            this.TextBox_SaveTo.Location = new System.Drawing.Point(465, 565);
            this.TextBox_SaveTo.Name = "TextBox_SaveTo";
            this.TextBox_SaveTo.Size = new System.Drawing.Size(130, 20);
            this.TextBox_SaveTo.TabIndex = 26;
            this.TextBox_SaveTo.TextChanged += new System.EventHandler(this.TextBox_SaveTo_TextChanged);
            // 
            // Btn_Snapshot
            // 
            this.Btn_Snapshot.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Snapshot.Location = new System.Drawing.Point(233, 523);
            this.Btn_Snapshot.Name = "Btn_Snapshot";
            this.Btn_Snapshot.Size = new System.Drawing.Size(86, 28);
            this.Btn_Snapshot.TabIndex = 29;
            this.Btn_Snapshot.Text = "Snapshot";
            this.Btn_Snapshot.UseVisualStyleBackColor = false;
            this.Btn_Snapshot.Click += new System.EventHandler(this.Btn_Snapshot_Click);
            // 
            // btSetting
            // 
            this.btSetting.BackColor = System.Drawing.Color.LightGray;
            this.btSetting.Location = new System.Drawing.Point(657, 523);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(86, 28);
            this.btSetting.TabIndex = 30;
            this.btSetting.Text = "Setting";
            this.btSetting.UseVisualStyleBackColor = false;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // btCondition
            // 
            this.btCondition.BackColor = System.Drawing.Color.LightGray;
            this.btCondition.Location = new System.Drawing.Point(763, 523);
            this.btCondition.Name = "btCondition";
            this.btCondition.Size = new System.Drawing.Size(86, 28);
            this.btCondition.TabIndex = 31;
            this.btCondition.Text = "Condition";
            this.btCondition.UseVisualStyleBackColor = false;
            // 
            // btLaser
            // 
            this.btLaser.BackColor = System.Drawing.Color.LightGray;
            this.btLaser.Location = new System.Drawing.Point(445, 523);
            this.btLaser.Name = "btLaser";
            this.btLaser.Size = new System.Drawing.Size(86, 28);
            this.btLaser.TabIndex = 32;
            this.btLaser.Text = "Laser";
            this.btLaser.UseVisualStyleBackColor = false;
            // 
            // btCurve
            // 
            this.btCurve.BackColor = System.Drawing.Color.LightGray;
            this.btCurve.Location = new System.Drawing.Point(339, 523);
            this.btCurve.Name = "btCurve";
            this.btCurve.Size = new System.Drawing.Size(86, 28);
            this.btCurve.TabIndex = 33;
            this.btCurve.Text = "Curve";
            this.btCurve.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(912, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 22);
            this.button7.TabIndex = 34;
            this.button7.Text = "About";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // MoveButton
            // 
            this.MoveButton.BackColor = System.Drawing.Color.Transparent;
            this.MoveButton.BackgroundImage = global::PipeInterface.Properties.Resources.BtnMove2;
            this.MoveButton.FlatAppearance.BorderSize = 0;
            this.MoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveButton.Location = new System.Drawing.Point(52, 324);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(25, 25);
            this.MoveButton.TabIndex = 36;
            this.MoveButton.UseVisualStyleBackColor = false;
            this.MoveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveButton_MouseDown);
            this.MoveButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveButton_MouseUp);
            // 
            // pictureBoxButton
            // 
            this.pictureBoxButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxButton.Image = global::PipeInterface.Properties.Resources.MoveBtnNormal;
            this.pictureBoxButton.Location = new System.Drawing.Point(14, 286);
            this.pictureBoxButton.Name = "pictureBoxButton";
            this.pictureBoxButton.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxButton.TabIndex = 35;
            this.pictureBoxButton.TabStop = false;
            // 
            // pictureBoxPlayback
            // 
            this.pictureBoxPlayback.Location = new System.Drawing.Point(6, 14);
            this.pictureBoxPlayback.Name = "pictureBoxPlayback";
            this.pictureBoxPlayback.Size = new System.Drawing.Size(458, 424);
            this.pictureBoxPlayback.TabIndex = 25;
            this.pictureBoxPlayback.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::PipeInterface.Properties.Resources.ROCKER1;
            this.pictureBox3.Location = new System.Drawing.Point(860, 431);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PipeInterface.Properties.Resources.zoom;
            this.pictureBox2.Location = new System.Drawing.Point(860, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // bt_rocker_2_D
            // 
            this.bt_rocker_2_D.BackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_rocker_2_D.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_rocker_2_D.FlatAppearance.BorderSize = 0;
            this.bt_rocker_2_D.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rocker_2_D.ForeColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_D.Image = global::PipeInterface.Properties.Resources.rocker_normal_downBT;
            this.bt_rocker_2_D.Location = new System.Drawing.Point(40, 511);
            this.bt_rocker_2_D.Name = "bt_rocker_2_D";
            this.bt_rocker_2_D.Size = new System.Drawing.Size(49, 19);
            this.bt_rocker_2_D.TabIndex = 21;
            this.bt_rocker_2_D.UseVisualStyleBackColor = false;
            // 
            // bt_rocker_2_U
            // 
            this.bt_rocker_2_U.BackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_U.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_rocker_2_U.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_rocker_2_U.FlatAppearance.BorderSize = 0;
            this.bt_rocker_2_U.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_U.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_U.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rocker_2_U.ForeColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_U.Image = global::PipeInterface.Properties.Resources.rocker_normal_upBT;
            this.bt_rocker_2_U.Location = new System.Drawing.Point(40, 431);
            this.bt_rocker_2_U.Name = "bt_rocker_2_U";
            this.bt_rocker_2_U.Size = new System.Drawing.Size(49, 19);
            this.bt_rocker_2_U.TabIndex = 20;
            this.bt_rocker_2_U.UseVisualStyleBackColor = false;
            // 
            // bt_rocker_2_R
            // 
            this.bt_rocker_2_R.BackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_R.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_rocker_2_R.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_rocker_2_R.FlatAppearance.BorderSize = 0;
            this.bt_rocker_2_R.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_R.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_R.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rocker_2_R.ForeColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_R.Image = global::PipeInterface.Properties.Resources.rocker_normal_rightBT;
            this.bt_rocker_2_R.Location = new System.Drawing.Point(95, 456);
            this.bt_rocker_2_R.Name = "bt_rocker_2_R";
            this.bt_rocker_2_R.Size = new System.Drawing.Size(19, 49);
            this.bt_rocker_2_R.TabIndex = 19;
            this.bt_rocker_2_R.UseVisualStyleBackColor = false;
            this.bt_rocker_2_R.Click += new System.EventHandler(this.button8_Click);
            // 
            // bt_rocker_2_L
            // 
            this.bt_rocker_2_L.BackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_rocker_2_L.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt_rocker_2_L.FlatAppearance.BorderSize = 0;
            this.bt_rocker_2_L.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_L.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rocker_2_L.ForeColor = System.Drawing.Color.Transparent;
            this.bt_rocker_2_L.Image = global::PipeInterface.Properties.Resources.rocker_normal_leftBT;
            this.bt_rocker_2_L.Location = new System.Drawing.Point(14, 456);
            this.bt_rocker_2_L.Name = "bt_rocker_2_L";
            this.bt_rocker_2_L.Size = new System.Drawing.Size(20, 49);
            this.bt_rocker_2_L.TabIndex = 18;
            this.bt_rocker_2_L.UseVisualStyleBackColor = false;
            this.bt_rocker_2_L.Click += new System.EventHandler(this.button7_Click);
            // 
            // ImageBTRocker2
            // 
            this.ImageBTRocker2.BackColor = System.Drawing.Color.Transparent;
            this.ImageBTRocker2.Image = global::PipeInterface.Properties.Resources.rocker_normal;
            this.ImageBTRocker2.Location = new System.Drawing.Point(15, 431);
            this.ImageBTRocker2.Name = "ImageBTRocker2";
            this.ImageBTRocker2.Size = new System.Drawing.Size(100, 100);
            this.ImageBTRocker2.TabIndex = 17;
            this.ImageBTRocker2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(971, 558);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.pictureBoxButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btCurve);
            this.Controls.Add(this.btLaser);
            this.Controls.Add(this.btCondition);
            this.Controls.Add(this.playbackGB);
            this.Controls.Add(this.btSetting);
            this.Controls.Add(this.Btn_Snapshot);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TextBox_SaveTo);
            this.Controls.Add(this.button_SaveTo1);
            this.Controls.Add(this.button_CaptureVideo1Start);
            this.Controls.Add(this.bt_rocker_2_D);
            this.Controls.Add(this.bt_rocker_2_U);
            this.Controls.Add(this.bt_rocker_2_R);
            this.Controls.Add(this.bt_rocker_2_L);
            this.Controls.Add(this.ImageBTRocker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playback);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.lb_Position);
            this.Controls.Add(this.CameraBox);
            this.Controls.Add(this.tb_cameraUrl);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Pipe Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CameraBox.ResumeLayout(false);
            this.CameraBox.PerformLayout();
            this.groupBoxFontOverlay.ResumeLayout(false);
            this.groupBoxFontOverlay.PerformLayout();
            this.groupBoxOverlay.ResumeLayout(false);
            this.groupBoxOverlay.PerformLayout();
            this.playbackGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBTRocker2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.TextBox tb_cameraUrl;
        private System.Windows.Forms.TextBox text_OverlayText;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.GroupBox CameraBox;
        private System.Windows.Forms.Label statelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox playbackGB;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button playback;
        private System.Windows.Forms.Button btCamera;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox ImageBTRocker2;
        private System.Windows.Forms.Button bt_rocker_2_L;
        private System.Windows.Forms.Button bt_rocker_2_R;
        private System.Windows.Forms.Button bt_rocker_2_U;
        private System.Windows.Forms.Button bt_rocker_2_D;
        private System.Windows.Forms.Button button_CaptureVideo1Start;
        private System.Windows.Forms.Button button_SaveTo1;
        private System.Windows.Forms.TextBox TextBox_SaveTo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button Btn_Snapshot;
        private System.Windows.Forms.GroupBox groupBoxOverlay;
        private System.Windows.Forms.Button FontButtonOverlay;
        private System.Windows.Forms.Button OKbuttonOverlay;
        private System.Windows.Forms.GroupBox groupBoxFontOverlay;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.Label fontStyleLabel;
        private System.Windows.Forms.Label fontColorLabel;
        private System.Windows.Forms.ComboBox fontStyleComboBox;
        private System.Windows.Forms.ComboBox fontSizeComboBox;
        private System.Windows.Forms.Label fontNameLabel;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.ComboBox fontNameComboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Button btCondition;
        private System.Windows.Forms.Button btLaser;
        private System.Windows.Forms.Button btCurve;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBoxPlayback;
        private System.Windows.Forms.Button ViewMode;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBoxButton;
        private System.Windows.Forms.Button MoveButton;
    }
}

