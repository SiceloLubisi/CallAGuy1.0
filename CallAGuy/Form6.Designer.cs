
namespace CallAGuy
{
    partial class frmHelpInformation
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
            this.btnHelpBack = new System.Windows.Forms.Button();
            this.gbxOrderDetails = new System.Windows.Forms.GroupBox();
            this.lblHelpInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelpBack
            // 
            this.btnHelpBack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnHelpBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHelpBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpBack.ForeColor = System.Drawing.Color.White;
            this.btnHelpBack.Location = new System.Drawing.Point(44, 371);
            this.btnHelpBack.Name = "btnHelpBack";
            this.btnHelpBack.Size = new System.Drawing.Size(197, 27);
            this.btnHelpBack.TabIndex = 31;
            this.btnHelpBack.Text = "BACK";
            this.btnHelpBack.UseVisualStyleBackColor = false;
            this.btnHelpBack.Click += new System.EventHandler(this.btnHelpBack_Click);
            // 
            // gbxOrderDetails
            // 
            this.gbxOrderDetails.Controls.Add(this.lblHelpInfo);
            this.gbxOrderDetails.Location = new System.Drawing.Point(25, 214);
            this.gbxOrderDetails.Name = "gbxOrderDetails";
            this.gbxOrderDetails.Size = new System.Drawing.Size(226, 118);
            this.gbxOrderDetails.TabIndex = 30;
            this.gbxOrderDetails.TabStop = false;
            this.gbxOrderDetails.Text = "HELP INFORMATION";
            // 
            // lblHelpInfo
            // 
            this.lblHelpInfo.AutoSize = true;
            this.lblHelpInfo.Location = new System.Drawing.Point(16, 27);
            this.lblHelpInfo.Name = "lblHelpInfo";
            this.lblHelpInfo.Size = new System.Drawing.Size(0, 13);
            this.lblHelpInfo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CallAGuy.Properties.Resources.Call_a_GUY_Flyers_360x;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frmHelpInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(276, 479);
            this.Controls.Add(this.btnHelpBack);
            this.Controls.Add(this.gbxOrderDetails);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHelpInformation";
            this.Text = "frmHelpInformation";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.gbxOrderDetails.ResumeLayout(false);
            this.gbxOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelpBack;
        private System.Windows.Forms.GroupBox gbxOrderDetails;
        private System.Windows.Forms.Label lblHelpInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}