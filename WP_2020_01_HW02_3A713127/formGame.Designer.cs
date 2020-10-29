namespace WP_2020_01_HW02_3A713127
{
    partial class formGame
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn1.Location = new System.Drawing.Point(292, 342);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(129, 60);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "抽牌";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lab1
            // 
            this.lab1.Font = new System.Drawing.Font("新細明體", 20F);
            this.lab1.Location = new System.Drawing.Point(16, 9);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(139, 46);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "手牌";
            this.lab1.Click += new System.EventHandler(this.lab1_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(22, 117);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(129, 219);
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(157, 117);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(129, 219);
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(292, 117);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(129, 219);
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(427, 117);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(129, 219);
            this.pb4.TabIndex = 6;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(562, 117);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(129, 219);
            this.pb5.TabIndex = 7;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.btn1);
            this.Name = "formGame";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
    }
}

