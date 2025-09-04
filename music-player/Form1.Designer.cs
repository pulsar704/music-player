namespace music_player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnPlay = new Button();
            BtnStop = new Button();
            openFileDialog1 = new OpenFileDialog();
            BtnOpenFile = new Button();
            SuspendLayout();
            // 
            // BtnPlay
            // 
            BtnPlay.Location = new Point(200, 174);
            BtnPlay.Name = "BtnPlay";
            BtnPlay.Size = new Size(75, 23);
            BtnPlay.TabIndex = 0;
            BtnPlay.Text = "Play";
            BtnPlay.UseVisualStyleBackColor = true;
            BtnPlay.Click += BtnPlay_Click;
            // 
            // BtnStop
            // 
            BtnStop.Location = new Point(119, 174);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(75, 23);
            BtnStop.TabIndex = 1;
            BtnStop.Text = "Stop";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnOpenFile
            // 
            BtnOpenFile.Location = new Point(119, 203);
            BtnOpenFile.Name = "BtnOpenFile";
            BtnOpenFile.Size = new Size(156, 23);
            BtnOpenFile.TabIndex = 2;
            BtnOpenFile.Text = "Choose File";
            BtnOpenFile.UseVisualStyleBackColor = true;
            BtnOpenFile.Click += BtnOpenFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 238);
            Controls.Add(BtnOpenFile);
            Controls.Add(BtnStop);
            Controls.Add(BtnPlay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPlay;
        private Button BtnStop;
        private OpenFileDialog openFileDialog1;
        private Button BtnOpenFile;
    }
}
