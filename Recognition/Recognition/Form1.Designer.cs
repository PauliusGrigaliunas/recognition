namespace Recognition
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
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.ibProcessed = new Emgu.CV.UI.ImageBox();
            this.btnPauseOrResume = new System.Windows.Forms.Button();
            this.txtXYradius = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibProcessed)).BeginInit();
            this.SuspendLayout();
            // 
            // ibOriginal
            // 
            this.ibOriginal.Location = new System.Drawing.Point(26, 36);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(640, 480);
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            // 
            // ibProcessed
            // 
            this.ibProcessed.Location = new System.Drawing.Point(672, 36);
            this.ibProcessed.Name = "ibProcessed";
            this.ibProcessed.Size = new System.Drawing.Size(640, 480);
            this.ibProcessed.TabIndex = 2;
            this.ibProcessed.TabStop = false;
            // 
            // btnPauseOrResume
            // 
            this.btnPauseOrResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnPauseOrResume.Location = new System.Drawing.Point(26, 522);
            this.btnPauseOrResume.Name = "btnPauseOrResume";
            this.btnPauseOrResume.Size = new System.Drawing.Size(273, 159);
            this.btnPauseOrResume.TabIndex = 3;
            this.btnPauseOrResume.Text = "Pause";
            this.btnPauseOrResume.UseVisualStyleBackColor = true;
            this.btnPauseOrResume.Click += new System.EventHandler(this.PauseOrResume_Click);
            // 
            // txtXYradius
            // 
            this.txtXYradius.Location = new System.Drawing.Point(305, 522);
            this.txtXYradius.Multiline = true;
            this.txtXYradius.Name = "txtXYradius";
            this.txtXYradius.ReadOnly = true;
            this.txtXYradius.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXYradius.Size = new System.Drawing.Size(1006, 159);
            this.txtXYradius.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 693);
            this.Controls.Add(this.txtXYradius);
            this.Controls.Add(this.btnPauseOrResume);
            this.Controls.Add(this.ibProcessed);
            this.Controls.Add(this.ibOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibProcessed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibOriginal;
        private Emgu.CV.UI.ImageBox ibProcessed;
        private System.Windows.Forms.Button btnPauseOrResume;
        private System.Windows.Forms.TextBox txtXYradius;
    }
}

