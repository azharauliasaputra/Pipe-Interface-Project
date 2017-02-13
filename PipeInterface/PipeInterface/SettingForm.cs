using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace PipeInterface
{
    public partial class SettingForm : Form
    {
   
        public SettingForm()
        {

            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            InitializeComponent();

            textBoxMaxNum.Enabled = Convert.ToBoolean(Bridge.MaxNumTextEdit);

            this.languageComboBox.Items.AddRange(new string[] { "English", "Chinese"});
            this.languageComboBox.SelectedIndex = MyGlobals.LanguageMode;

            this.fontStyleComboBox.Items.AddRange(new string[] { "Regular", "Bold", "Italic", "BoldItalic", "Underline" });
            this.fontStyleComboBox.SelectedIndex = MyGlobals.FontStyle1;

            this.fontNameComboBox.Items.AddRange(new string[] { "Arial", "AirCut", "Arial Black", "Comic Sans MS", "Times New Roman" });
            this.fontNameComboBox.SelectedIndex = MyGlobals.FontName1;

            //this.fontNameComboBox.SelectedIndex = 0;

            for (int i = 8; i <= 60; i += 2)
            {
                    this.fontSizeComboBox.Items.Add(i);
            }
            this.fontSizeComboBox.SelectedIndex = (MyGlobals.FontSize1 - 8) / 2;
            //this.fontSizeComboBox.SelectedIndex = 2;

            colorBox.BackColor = Color.FromArgb(MyGlobals.FontColor);
            fontStyleComboBox.Text = fontStyleComboBox.Items[fontStyleComboBox.SelectedIndex].ToString();
            fontNameComboBox.Text = fontNameComboBox.Items[fontNameComboBox.SelectedIndex].ToString();
            fontSizeComboBox.Text = fontSizeComboBox.Items[fontSizeComboBox.SelectedIndex].ToString();

            this.fontStyleComboBox2.Items.AddRange(new string[] { "Regular", "Bold", "Italic", "BoldItalic", "Underline" });
            this.fontStyleComboBox2.SelectedIndex = MyGlobals.FontStyle2;

            this.fontNameComboBox2.Items.AddRange(new string[] { "Arial", "AirCut", "Arial Black", "Comic Sans MS", "Times New Roman" });
            this.fontNameComboBox2.SelectedIndex = MyGlobals.FontName2;
            //this.fontNameComboBox.SelectedIndex = 0;

            for (int i = 8; i <= 60; i += 2)
            {
                this.fontSizeComboBox2.Items.Add(i);
            }
            this.fontSizeComboBox2.SelectedIndex = (MyGlobals.FontSize2 - 8) / 2;
            //this.fontSizeComboBox.SelectedIndex = 2;

            colorBox2.BackColor = Color.FromArgb(MyGlobals.FontColor2);
            fontStyleComboBox2.Text = fontStyleComboBox2.Items[fontStyleComboBox2.SelectedIndex].ToString();
            fontNameComboBox2.Text = fontNameComboBox2.Items[fontNameComboBox2.SelectedIndex].ToString();
            fontSizeComboBox2.Text = fontSizeComboBox2.Items[fontSizeComboBox2.SelectedIndex].ToString();

            textBoxMaxNum.Text = MyGlobals.MaxTextOverlayNum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SaveTo1_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextBox_SaveTo.Text = folderBrowserDialog1.SelectedPath;
                MyGlobals.SaveImage = folderBrowserDialog1.SelectedPath;
            }
            //TextBox_SaveTo.Text = "C:\\Users\\Azhar Aulia Saputra\\Documents";
        }

        private void button_SaveTo2_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextBox_SaveTo2.Text = folderBrowserDialog1.SelectedPath;
                MyGlobals.SaveVideo = folderBrowserDialog1.SelectedPath;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        #region font overlay edit
        private void btFontApply_Click(object sender, EventArgs e)
        {
            MyGlobals.FontChangeMode = 1;
        }
        private void fontColorButton_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                MyGlobals.FontColor = colorDialog1.Color.ToArgb();
                colorBox.BackColor = colorDialog1.Color;
            }
        }

        private void fontStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyGlobals.FontStyle1 = this.fontStyleComboBox.SelectedIndex;
        }

        private void fontNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyGlobals.FontName1 = this.fontNameComboBox.SelectedIndex;
        }

        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyGlobals.FontSize1 = Convert.ToInt32(this.fontSizeComboBox.Text);
        }

        private void textBoxMaxNum_TextChanged(object sender, EventArgs e)
        {
            MyGlobals.MaxTextOverlayNum = Convert.ToInt32(textBoxMaxNum.Text);
        }

        #endregion

        #region font date edit
        private void btFontApply2_Click(object sender, EventArgs e)
        {
            MyGlobals.FontChangeMode2 = 1;
        }
        private void fontColorButton2_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                MyGlobals.FontColor2 = colorDialog1.Color.ToArgb();
                colorBox2.BackColor = colorDialog1.Color;
            }
        }

        private void fontStyleComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyGlobals.FontStyle2 = this.fontStyleComboBox2.SelectedIndex;
        }

        private void fontNameComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyGlobals.FontName2 = this.fontNameComboBox2.SelectedIndex;
        }

        private void fontSizeComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyGlobals.FontSize2 = Convert.ToInt32(this.fontSizeComboBox2.Text);
        }


        #endregion

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyGlobals.LanguageMode = languageComboBox.SelectedIndex;
            switch (MyGlobals.LanguageMode) {
                case 0:
                    
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

                    break;
                case 1:

                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");

                    break;
            }
        }
    }
}
