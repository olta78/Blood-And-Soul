namespace Sbor
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.trDelay = new System.Windows.Forms.Timer(this.components);
            this.minDes = new System.Windows.Forms.Label();
            this.minEd = new System.Windows.Forms.Label();
            this.secDes = new System.Windows.Forms.Label();
            this.secEd = new System.Windows.Forms.Label();
            this.lbTire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.ForeColor = System.Drawing.Color.Green;
            this.btStart.Location = new System.Drawing.Point(8, 56);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(100, 22);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "С Т А Р Т";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.ForeColor = System.Drawing.Color.Red;
            this.btStop.Location = new System.Drawing.Point(127, 56);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(100, 22);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "С Т О П";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // trDelay
            // 
            this.trDelay.Tick += new System.EventHandler(this.trDelay_Tick);
            // 
            // minDes
            // 
            this.minDes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minDes.ForeColor = System.Drawing.Color.Blue;
            this.minDes.Location = new System.Drawing.Point(8, 8);
            this.minDes.Name = "minDes";
            this.minDes.Size = new System.Drawing.Size(35, 37);
            this.minDes.TabIndex = 2;
            this.minDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minEd
            // 
            this.minEd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minEd.ForeColor = System.Drawing.Color.Blue;
            this.minEd.Location = new System.Drawing.Point(56, 8);
            this.minEd.Name = "minEd";
            this.minEd.Size = new System.Drawing.Size(35, 37);
            this.minEd.TabIndex = 3;
            this.minEd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secDes
            // 
            this.secDes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secDes.ForeColor = System.Drawing.Color.Blue;
            this.secDes.Location = new System.Drawing.Point(144, 8);
            this.secDes.Name = "secDes";
            this.secDes.Size = new System.Drawing.Size(35, 37);
            this.secDes.TabIndex = 4;
            this.secDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secEd
            // 
            this.secEd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secEd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secEd.ForeColor = System.Drawing.Color.Blue;
            this.secEd.Location = new System.Drawing.Point(192, 8);
            this.secEd.Name = "secEd";
            this.secEd.Size = new System.Drawing.Size(35, 37);
            this.secEd.TabIndex = 5;
            this.secEd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTire
            // 
            this.lbTire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTire.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTire.ForeColor = System.Drawing.Color.Blue;
            this.lbTire.Location = new System.Drawing.Point(98, 8);
            this.lbTire.Name = "lbTire";
            this.lbTire.Size = new System.Drawing.Size(35, 37);
            this.lbTire.TabIndex = 6;
            this.lbTire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 81);
            this.Controls.Add(this.lbTire);
            this.Controls.Add(this.secEd);
            this.Controls.Add(this.secDes);
            this.Controls.Add(this.minEd);
            this.Controls.Add(this.minDes);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Sbor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer trDelay;
        private System.Windows.Forms.Label minDes;
        private System.Windows.Forms.Label minEd;
        private System.Windows.Forms.Label secDes;
        private System.Windows.Forms.Label secEd;
        private System.Windows.Forms.Label lbTire;
    }
}

