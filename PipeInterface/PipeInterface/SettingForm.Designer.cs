using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ozeki.Camera;
using Ozeki.Media;

namespace PipeInterface
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.btFontApply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SettingTab = new System.Windows.Forms.TabControl();
            this.tabFont = new System.Windows.Forms.TabPage();
            this.textBoxMaxNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.colorBox2 = new System.Windows.Forms.PictureBox();
            this.btFontApply2 = new System.Windows.Forms.Button();
            this.fontColorButton2 = new System.Windows.Forms.Button();
            this.fontNameComboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fontSizeComboBox2 = new System.Windows.Forms.ComboBox();
            this.fontStyleComboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.fontNameComboBox = new System.Windows.Forms.ComboBox();
            this.fontStyleLabel = new System.Windows.Forms.Label();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontNameLabel = new System.Windows.Forms.Label();
            this.fontColorLabel = new System.Windows.Forms.Label();
            this.fontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.fontStyleComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_SaveTo2 = new System.Windows.Forms.TextBox();
            this.button_SaveTo2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_SaveTo1 = new System.Windows.Forms.Button();
            this.TextBox_SaveTo = new System.Windows.Forms.TextBox();
            this.tabPageDate = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.General = new System.Windows.Forms.TabPage();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SettingTab.SuspendLayout();
            this.tabFont.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.General.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFontApply
            // 
            resources.ApplyResources(this.btFontApply, "btFontApply");
            this.btFontApply.Name = "btFontApply";
            this.btFontApply.UseVisualStyleBackColor = true;
            this.btFontApply.Click += new System.EventHandler(this.btFontApply_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingTab
            // 
            this.SettingTab.Controls.Add(this.tabFont);
            this.SettingTab.Controls.Add(this.tabPage2);
            this.SettingTab.Controls.Add(this.tabPageDate);
            this.SettingTab.Controls.Add(this.tabPage1);
            this.SettingTab.Controls.Add(this.General);
            resources.ApplyResources(this.SettingTab, "SettingTab");
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.SelectedIndex = 0;
            // 
            // tabFont
            // 
            this.tabFont.Controls.Add(this.textBoxMaxNum);
            this.tabFont.Controls.Add(this.label5);
            this.tabFont.Controls.Add(this.groupBox4);
            this.tabFont.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabFont, "tabFont");
            this.tabFont.Name = "tabFont";
            this.tabFont.UseVisualStyleBackColor = true;
            // 
            // textBoxMaxNum
            // 
            resources.ApplyResources(this.textBoxMaxNum, "textBoxMaxNum");
            this.textBoxMaxNum.Name = "textBoxMaxNum";
            this.textBoxMaxNum.TextChanged += new System.EventHandler(this.textBoxMaxNum_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.colorBox2);
            this.groupBox4.Controls.Add(this.btFontApply2);
            this.groupBox4.Controls.Add(this.fontColorButton2);
            this.groupBox4.Controls.Add(this.fontNameComboBox2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.fontSizeComboBox2);
            this.groupBox4.Controls.Add(this.fontStyleComboBox2);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // colorBox2
            // 
            this.colorBox2.BackColor = System.Drawing.Color.Transparent;
            this.colorBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.colorBox2, "colorBox2");
            this.colorBox2.Name = "colorBox2";
            this.colorBox2.TabStop = false;
            // 
            // btFontApply2
            // 
            resources.ApplyResources(this.btFontApply2, "btFontApply2");
            this.btFontApply2.Name = "btFontApply2";
            this.btFontApply2.UseVisualStyleBackColor = true;
            this.btFontApply2.Click += new System.EventHandler(this.btFontApply2_Click);
            // 
            // fontColorButton2
            // 
            resources.ApplyResources(this.fontColorButton2, "fontColorButton2");
            this.fontColorButton2.Name = "fontColorButton2";
            this.fontColorButton2.UseVisualStyleBackColor = true;
            this.fontColorButton2.Click += new System.EventHandler(this.fontColorButton2_Click);
            // 
            // fontNameComboBox2
            // 
            this.fontNameComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.fontNameComboBox2, "fontNameComboBox2");
            this.fontNameComboBox2.FormattingEnabled = true;
            this.fontNameComboBox2.Name = "fontNameComboBox2";
            this.fontNameComboBox2.SelectedIndexChanged += new System.EventHandler(this.fontNameComboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // fontSizeComboBox2
            // 
            this.fontSizeComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.fontSizeComboBox2, "fontSizeComboBox2");
            this.fontSizeComboBox2.FormattingEnabled = true;
            this.fontSizeComboBox2.Name = "fontSizeComboBox2";
            this.fontSizeComboBox2.SelectedIndexChanged += new System.EventHandler(this.fontSizeComboBox2_SelectedIndexChanged);
            // 
            // fontStyleComboBox2
            // 
            this.fontStyleComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.fontStyleComboBox2, "fontStyleComboBox2");
            this.fontStyleComboBox2.FormattingEnabled = true;
            this.fontStyleComboBox2.Name = "fontStyleComboBox2";
            this.fontStyleComboBox2.SelectedIndexChanged += new System.EventHandler(this.fontStyleComboBox2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.colorBox);
            this.groupBox3.Controls.Add(this.btFontApply);
            this.groupBox3.Controls.Add(this.fontColorButton);
            this.groupBox3.Controls.Add(this.fontNameComboBox);
            this.groupBox3.Controls.Add(this.fontStyleLabel);
            this.groupBox3.Controls.Add(this.fontSizeLabel);
            this.groupBox3.Controls.Add(this.fontNameLabel);
            this.groupBox3.Controls.Add(this.fontColorLabel);
            this.groupBox3.Controls.Add(this.fontSizeComboBox);
            this.groupBox3.Controls.Add(this.fontStyleComboBox);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Transparent;
            this.colorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.colorBox, "colorBox");
            this.colorBox.Name = "colorBox";
            this.colorBox.TabStop = false;
            // 
            // fontColorButton
            // 
            resources.ApplyResources(this.fontColorButton, "fontColorButton");
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // fontNameComboBox
            // 
            this.fontNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.fontNameComboBox, "fontNameComboBox");
            this.fontNameComboBox.FormattingEnabled = true;
            this.fontNameComboBox.Name = "fontNameComboBox";
            this.fontNameComboBox.SelectedIndexChanged += new System.EventHandler(this.fontNameComboBox_SelectedIndexChanged);
            // 
            // fontStyleLabel
            // 
            resources.ApplyResources(this.fontStyleLabel, "fontStyleLabel");
            this.fontStyleLabel.Name = "fontStyleLabel";
            // 
            // fontSizeLabel
            // 
            resources.ApplyResources(this.fontSizeLabel, "fontSizeLabel");
            this.fontSizeLabel.Name = "fontSizeLabel";
            // 
            // fontNameLabel
            // 
            resources.ApplyResources(this.fontNameLabel, "fontNameLabel");
            this.fontNameLabel.Name = "fontNameLabel";
            // 
            // fontColorLabel
            // 
            resources.ApplyResources(this.fontColorLabel, "fontColorLabel");
            this.fontColorLabel.Name = "fontColorLabel";
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.fontSizeComboBox, "fontSizeComboBox");
            this.fontSizeComboBox.FormattingEnabled = true;
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeComboBox_SelectedIndexChanged);
            // 
            // fontStyleComboBox
            // 
            this.fontStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.fontStyleComboBox, "fontStyleComboBox");
            this.fontStyleComboBox.FormattingEnabled = true;
            this.fontStyleComboBox.Name = "fontStyleComboBox";
            this.fontStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.fontStyleComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TextBox_SaveTo2);
            this.groupBox2.Controls.Add(this.button_SaveTo2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // TextBox_SaveTo2
            // 
            resources.ApplyResources(this.TextBox_SaveTo2, "TextBox_SaveTo2");
            this.TextBox_SaveTo2.Name = "TextBox_SaveTo2";
            // 
            // button_SaveTo2
            // 
            resources.ApplyResources(this.button_SaveTo2, "button_SaveTo2");
            this.button_SaveTo2.Name = "button_SaveTo2";
            this.button_SaveTo2.UseVisualStyleBackColor = true;
            this.button_SaveTo2.Click += new System.EventHandler(this.button_SaveTo2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_SaveTo1);
            this.groupBox1.Controls.Add(this.TextBox_SaveTo);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_SaveTo1
            // 
            resources.ApplyResources(this.button_SaveTo1, "button_SaveTo1");
            this.button_SaveTo1.Name = "button_SaveTo1";
            this.button_SaveTo1.UseVisualStyleBackColor = true;
            this.button_SaveTo1.Click += new System.EventHandler(this.button_SaveTo1_Click);
            // 
            // TextBox_SaveTo
            // 
            resources.ApplyResources(this.TextBox_SaveTo, "TextBox_SaveTo");
            this.TextBox_SaveTo.Name = "TextBox_SaveTo";
            // 
            // tabPageDate
            // 
            resources.ApplyResources(this.tabPageDate, "tabPageDate");
            this.tabPageDate.Name = "tabPageDate";
            this.tabPageDate.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // General
            // 
            this.General.Controls.Add(this.languageComboBox);
            this.General.Controls.Add(this.label9);
            resources.ApplyResources(this.General, "General");
            this.General.Name = "General";
            this.General.UseVisualStyleBackColor = true;
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // SettingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SettingTab);
            this.Controls.Add(this.button2);
            this.Name = "SettingForm";
            this.SettingTab.ResumeLayout(false);
            this.tabFont.ResumeLayout(false);
            this.tabFont.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl SettingTab;
        private System.Windows.Forms.TabPage tabFont;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TextBox_SaveTo;
        private System.Windows.Forms.Button button_SaveTo1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox TextBox_SaveTo2;
        private System.Windows.Forms.Button button_SaveTo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.Label fontStyleLabel;
        private System.Windows.Forms.Label fontColorLabel;
        private System.Windows.Forms.Label fontNameLabel;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.Button btFontApply;
        public System.Windows.Forms.ComboBox fontStyleComboBox;
        public System.Windows.Forms.ComboBox fontNameComboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox fontSizeComboBox;
        private GroupBox groupBox4;
        private Button btFontApply2;
        private Button fontColorButton2;
        public ComboBox fontNameComboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox fontSizeComboBox2;
        public ComboBox fontStyleComboBox2;
        private GroupBox groupBox3;
        private Label label5;
        public TextBox textBoxMaxNum;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private TabPage tabPageDate;
        private TabPage tabPage1;
        private PictureBox colorBox;
        private PictureBox colorBox2;
        private TabPage General;
        private ComboBox languageComboBox;
        private Label label9;
    }


    public static class MyGlobals
    {
        public static string SaveVideo = @"C:\Pipe Interface\Saved Data\Video";
        public static string SaveImage = @"C:\Pipe Interface\Saved Data\Picture";

        public static int FontName1 = 0;
        public static int FontStyle1 = 1;
        public static int FontSize1 = 14;
        public static int FontChangeMode = 0;
        public static int FontColor = 0;// Convert.ToInt32(Color.Black);

        public static int FontName2 = 0;
        public static int FontStyle2 = 1;
        public static int FontSize2 = 14;
        public static int FontChangeMode2 = 0;
        public static int FontColor2 = 0;// Convert.ToInt32(Color.Black);

        public static int MaxTextOverlayNum = 10;
        public static int LanguageMode = 0;

    }
    public static class Bridge
    {
        public static int SettingOpen = 0;
        public static int MaxNumTextEdit = 1;
    }
}