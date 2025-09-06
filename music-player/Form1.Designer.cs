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
            ButtonPlay = new Button();
            openFileDialog1 = new OpenFileDialog();
            ButtonOpenFile = new Button();
            progressBar1 = new ProgressBar();
            labelCurrentTime = new Label();
            labelTotalTime = new Label();
            SuspendLayout();
            // 
            // ButtonPlay
            // 
            ButtonPlay.Location = new Point(401, 311);
            ButtonPlay.Name = "ButtonPlay";
            ButtonPlay.Size = new Size(156, 23);
            ButtonPlay.TabIndex = 0;
            ButtonPlay.Text = "Play";
            ButtonPlay.UseVisualStyleBackColor = true;
            ButtonPlay.Click += ButtonPlay_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButtonOpenFile
            // 
            ButtonOpenFile.Location = new Point(401, 340);
            ButtonOpenFile.Name = "ButtonOpenFile";
            ButtonOpenFile.Size = new Size(156, 23);
            ButtonOpenFile.TabIndex = 2;
            ButtonOpenFile.Text = "Choose File";
            ButtonOpenFile.UseVisualStyleBackColor = true;
            ButtonOpenFile.Click += ButtonOpenFile_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(545, 23);
            progressBar1.TabIndex = 3;
            // 
            // labelCurrentTime
            // 
            labelCurrentTime.AutoSize = true;
            labelCurrentTime.Location = new Point(12, 38);
            labelCurrentTime.Name = "labelCurrentTime";
            labelCurrentTime.Size = new Size(34, 15);
            labelCurrentTime.TabIndex = 4;
            labelCurrentTime.Text = "00:00";
            // 
            // labelTotalTime
            // 
            labelTotalTime.AutoSize = true;
            labelTotalTime.Location = new Point(523, 38);
            labelTotalTime.Name = "labelTotalTime";
            labelTotalTime.Size = new Size(34, 15);
            labelTotalTime.TabIndex = 5;
            labelTotalTime.Text = "00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 375);
            Controls.Add(labelTotalTime);
            Controls.Add(labelCurrentTime);
            Controls.Add(progressBar1);
            Controls.Add(ButtonOpenFile);
            Controls.Add(ButtonPlay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonPlay;
        private OpenFileDialog openFileDialog1;
        private Button ButtonOpenFile;
        private ProgressBar progressBar1;
        private Label labelCurrentTime;
        private Label labelTotalTime;
    }
}
