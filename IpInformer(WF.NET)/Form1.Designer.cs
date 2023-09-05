namespace IpInformer_WF.NET_
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
            this.IpField = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.Ip_field = new System.Windows.Forms.Label();
            this.Ip_lb = new System.Windows.Forms.Label();
            this.country_lb = new System.Windows.Forms.Label();
            this.country_field = new System.Windows.Forms.Label();
            this.city_lb = new System.Windows.Forms.Label();
            this.city_field = new System.Windows.Forms.Label();
            this.flagPicture = new System.Windows.Forms.PictureBox();
            this.lat_field = new System.Windows.Forms.Label();
            this.coordinates_lb = new System.Windows.Forms.Label();
            this.long_field = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flagPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // IpField
            // 
            this.IpField.BackColor = System.Drawing.Color.Silver;
            this.IpField.Location = new System.Drawing.Point(147, 28);
            this.IpField.Name = "IpField";
            this.IpField.Size = new System.Drawing.Size(202, 20);
            this.IpField.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Gray;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBtn.Font = new System.Drawing.Font("W3$iP", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(147, 54);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(202, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Показать инфо по IP";
            this.startBtn.UseVisualStyleBackColor = false;
            // 
            // Ip_field
            // 
            this.Ip_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ip_field.Font = new System.Drawing.Font("Disket Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ip_field.ForeColor = System.Drawing.Color.Yellow;
            this.Ip_field.Location = new System.Drawing.Point(144, 97);
            this.Ip_field.Name = "Ip_field";
            this.Ip_field.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Ip_field.Size = new System.Drawing.Size(205, 23);
            this.Ip_field.TabIndex = 3;
            this.Ip_field.Text = "label1";
            this.Ip_field.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ip_lb
            // 
            this.Ip_lb.Font = new System.Drawing.Font("W3$iP", 9.75F);
            this.Ip_lb.Location = new System.Drawing.Point(23, 96);
            this.Ip_lb.Name = "Ip_lb";
            this.Ip_lb.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Ip_lb.Size = new System.Drawing.Size(115, 23);
            this.Ip_lb.TabIndex = 2;
            this.Ip_lb.Text = "IP:";
            this.Ip_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // country_lb
            // 
            this.country_lb.Font = new System.Drawing.Font("W3$iP", 9.75F);
            this.country_lb.Location = new System.Drawing.Point(23, 130);
            this.country_lb.Name = "country_lb";
            this.country_lb.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.country_lb.Size = new System.Drawing.Size(115, 23);
            this.country_lb.TabIndex = 2;
            this.country_lb.Text = "Страна:";
            this.country_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // country_field
            // 
            this.country_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.country_field.Font = new System.Drawing.Font("Disket Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_field.ForeColor = System.Drawing.Color.Yellow;
            this.country_field.Location = new System.Drawing.Point(144, 131);
            this.country_field.Name = "country_field";
            this.country_field.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.country_field.Size = new System.Drawing.Size(205, 23);
            this.country_field.TabIndex = 3;
            this.country_field.Text = "label1";
            this.country_field.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // city_lb
            // 
            this.city_lb.Font = new System.Drawing.Font("W3$iP", 9.75F);
            this.city_lb.Location = new System.Drawing.Point(23, 165);
            this.city_lb.Name = "city_lb";
            this.city_lb.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.city_lb.Size = new System.Drawing.Size(115, 23);
            this.city_lb.TabIndex = 2;
            this.city_lb.Text = "Город:";
            this.city_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // city_field
            // 
            this.city_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.city_field.Font = new System.Drawing.Font("Disket Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_field.ForeColor = System.Drawing.Color.Yellow;
            this.city_field.Location = new System.Drawing.Point(144, 166);
            this.city_field.Name = "city_field";
            this.city_field.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.city_field.Size = new System.Drawing.Size(205, 23);
            this.city_field.TabIndex = 3;
            this.city_field.Text = "label1";
            this.city_field.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flagPicture
            // 
            this.flagPicture.ImageLocation = "";
            this.flagPicture.Location = new System.Drawing.Point(355, 129);
            this.flagPicture.Name = "flagPicture";
            this.flagPicture.Size = new System.Drawing.Size(32, 24);
            this.flagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flagPicture.TabIndex = 4;
            this.flagPicture.TabStop = false;
            // 
            // lat_field
            // 
            this.lat_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lat_field.Font = new System.Drawing.Font("Disket Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lat_field.ForeColor = System.Drawing.Color.Yellow;
            this.lat_field.Location = new System.Drawing.Point(144, 201);
            this.lat_field.Name = "lat_field";
            this.lat_field.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lat_field.Size = new System.Drawing.Size(100, 25);
            this.lat_field.TabIndex = 3;
            this.lat_field.Text = "label1";
            this.lat_field.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordinates_lb
            // 
            this.coordinates_lb.Font = new System.Drawing.Font("W3$iP", 9.75F);
            this.coordinates_lb.Location = new System.Drawing.Point(23, 201);
            this.coordinates_lb.Name = "coordinates_lb";
            this.coordinates_lb.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.coordinates_lb.Size = new System.Drawing.Size(115, 23);
            this.coordinates_lb.TabIndex = 2;
            this.coordinates_lb.Text = "Координаты:";
            this.coordinates_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // long_field
            // 
            this.long_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.long_field.Font = new System.Drawing.Font("Disket Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.long_field.ForeColor = System.Drawing.Color.Yellow;
            this.long_field.Location = new System.Drawing.Point(249, 201);
            this.long_field.Name = "long_field";
            this.long_field.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.long_field.Size = new System.Drawing.Size(100, 25);
            this.long_field.TabIndex = 3;
            this.long_field.Text = "label1";
            this.long_field.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(469, 346);
            this.Controls.Add(this.flagPicture);
            this.Controls.Add(this.country_field);
            this.Controls.Add(this.country_lb);
            this.Controls.Add(this.long_field);
            this.Controls.Add(this.lat_field);
            this.Controls.Add(this.city_field);
            this.Controls.Add(this.coordinates_lb);
            this.Controls.Add(this.city_lb);
            this.Controls.Add(this.Ip_field);
            this.Controls.Add(this.Ip_lb);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.IpField);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.flagPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpField;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label Ip_field;
        private System.Windows.Forms.Label Ip_lb;
        private System.Windows.Forms.Label country_lb;
        private System.Windows.Forms.Label country_field;
        private System.Windows.Forms.Label city_lb;
        private System.Windows.Forms.Label city_field;
        private System.Windows.Forms.PictureBox flagPicture;
        private System.Windows.Forms.Label lat_field;
        private System.Windows.Forms.Label coordinates_lb;
        private System.Windows.Forms.Label long_field;
    }
}

