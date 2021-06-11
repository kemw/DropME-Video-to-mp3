namespace DropME_Video_to_mp3
{
    partial class DropMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropMe));
            this.Dir = new System.Windows.Forms.Label();
            this.DirLoc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileInput = new System.Windows.Forms.TextBox();
            this.done = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Videobox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Videobox)).BeginInit();
            this.SuspendLayout();
            // 
            // Dir
            // 
            this.Dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dir.Location = new System.Drawing.Point(8, 256);
            this.Dir.Name = "Dir";
            this.Dir.Size = new System.Drawing.Size(406, 29);
            this.Dir.TabIndex = 1;
            // 
            // DirLoc
            // 
            this.DirLoc.BackColor = System.Drawing.Color.PaleVioletRed;
            this.DirLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirLoc.Location = new System.Drawing.Point(155, 288);
            this.DirLoc.Name = "DirLoc";
            this.DirLoc.Size = new System.Drawing.Size(99, 29);
            this.DirLoc.TabIndex = 3;
            this.DirLoc.Text = "Convert";
            this.DirLoc.UseVisualStyleBackColor = false;
            this.DirLoc.Click += new System.EventHandler(this.DirLoc_Click);
            // 
            // fileInput
            // 
            this.fileInput.AllowDrop = true;
            this.fileInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInput.Location = new System.Drawing.Point(12, 214);
            this.fileInput.Name = "fileInput";
            this.fileInput.Size = new System.Drawing.Size(391, 22);
            this.fileInput.TabIndex = 5;
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.done.Location = new System.Drawing.Point(12, 175);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(391, 23);
            this.done.Step = 2;
            this.done.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("AcmeFont", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(51, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thank you for using This Software";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(314, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Indigo;
            this.linkLabel1.Location = new System.Drawing.Point(12, 33);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 17);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click  here to see your mp3";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.LightGreen;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Videobox
            // 
            this.Videobox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Videobox.ErrorImage")));
            this.Videobox.Image = global::DropME_Video_to_mp3.Properties.Resources.home5;
            this.Videobox.Location = new System.Drawing.Point(12, 66);
            this.Videobox.Name = "Videobox";
            this.Videobox.Size = new System.Drawing.Size(382, 103);
            this.Videobox.TabIndex = 0;
            this.Videobox.TabStop = false;
            this.Videobox.Click += new System.EventHandler(this.Videobox_Click);
            this.Videobox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Videobox_DragEnter);
            // 
            // DropMe
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 329);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.done);
            this.Controls.Add(this.fileInput);
            this.Controls.Add(this.DirLoc);
            this.Controls.Add(this.Dir);
            this.Controls.Add(this.Videobox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DropMe";
            this.Text = "DropME-Video to mp3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DropMe_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Videobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Videobox;
        private System.Windows.Forms.Label Dir;
        private System.Windows.Forms.Button DirLoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fileInput;
        private System.Windows.Forms.ProgressBar done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

