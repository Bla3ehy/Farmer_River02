namespace WindowsFormsApp11111
{
    partial class Form1
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
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LsbLeft = new System.Windows.Forms.ListBox();
            this.LsbRight = new System.Windows.Forms.ListBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(188, 74);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(91, 34);
            this.BtnGo.TabIndex = 0;
            this.BtnGo.Text = "=>";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(188, 221);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(91, 34);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "<=";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LsbLeft
            // 
            this.LsbLeft.FormattingEnabled = true;
            this.LsbLeft.ItemHeight = 12;
            this.LsbLeft.Location = new System.Drawing.Point(26, 52);
            this.LsbLeft.Name = "LsbLeft";
            this.LsbLeft.Size = new System.Drawing.Size(120, 244);
            this.LsbLeft.TabIndex = 2;
            // 
            // LsbRight
            // 
            this.LsbRight.FormattingEnabled = true;
            this.LsbRight.ItemHeight = 12;
            this.LsbRight.Location = new System.Drawing.Point(330, 52);
            this.LsbRight.Name = "LsbRight";
            this.LsbRight.Size = new System.Drawing.Size(120, 232);
            this.LsbRight.TabIndex = 3;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(350, 348);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(86, 31);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "重來";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(494, 420);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LsbRight);
            this.Controls.Add(this.LsbLeft);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnGo);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ListBox LsbLeft;
        private System.Windows.Forms.ListBox LsbRight;
        private System.Windows.Forms.Button BtnReset;
    }
}

