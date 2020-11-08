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
            this.bt2 = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.lab2 = new System.Windows.Forms.Label();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.bt4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("新細明體", 16F);
            this.btn1.Location = new System.Drawing.Point(414, 16);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(137, 85);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "洗牌";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lab1
            // 
            this.lab1.Font = new System.Drawing.Font("新細明體", 20F);
            this.lab1.Location = new System.Drawing.Point(294, 260);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(92, 35);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "手牌";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(267, 299);
            this.pb1.Margin = new System.Windows.Forms.Padding(4);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(140, 188);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("新細明體", 16F);
            this.bt2.Location = new System.Drawing.Point(415, 107);
            this.bt2.Margin = new System.Windows.Forms.Padding(4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(137, 85);
            this.bt2.TabIndex = 5;
            this.bt2.Text = "抽牌";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(267, 68);
            this.pb2.Margin = new System.Windows.Forms.Padding(4);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(140, 188);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 6;
            this.pb2.TabStop = false;
            // 
            // lab2
            // 
            this.lab2.Font = new System.Drawing.Font("新細明體", 20F);
            this.lab2.Location = new System.Drawing.Point(294, 22);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(113, 42);
            this.lab2.TabIndex = 7;
            this.lab2.Text = "牌庫";
            // 
            // rtb1
            // 
            this.rtb1.Font = new System.Drawing.Font("新細明體", 12F);
            this.rtb1.Location = new System.Drawing.Point(12, 48);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(240, 439);
            this.rtb1.TabIndex = 8;
            this.rtb1.Text = "";
            this.rtb1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "抽牌順序";
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("新細明體", 20F);
            this.btn3.Location = new System.Drawing.Point(767, 146);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 53);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "開";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(414, 215);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(480, 270);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 11;
            this.pb3.TabStop = false;
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("新細明體", 20F);
            this.bt4.Location = new System.Drawing.Point(837, 146);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(64, 53);
            this.bt4.TabIndex = 12;
            this.bt4.Text = "關";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(559, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "↓設計圖↓";
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.btn1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Label label2;
    }
}

