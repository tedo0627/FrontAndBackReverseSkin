namespace FrontAndBackReverseSkin
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.basePath = new System.Windows.Forms.TextBox();
            this.createPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.slimCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 19);
            this.button2.TabIndex = 1;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "実行";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "元のスキンを選択してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "保存先を選択してください";
            // 
            // basePath
            // 
            this.basePath.Location = new System.Drawing.Point(61, 74);
            this.basePath.Name = "basePath";
            this.basePath.Size = new System.Drawing.Size(279, 19);
            this.basePath.TabIndex = 5;
            // 
            // createPath
            // 
            this.createPath.Location = new System.Drawing.Point(61, 177);
            this.createPath.Name = "createPath";
            this.createPath.Size = new System.Drawing.Size(279, 19);
            this.createPath.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // slimCheck
            // 
            this.slimCheck.AutoSize = true;
            this.slimCheck.Location = new System.Drawing.Point(61, 232);
            this.slimCheck.Name = "slimCheck";
            this.slimCheck.Size = new System.Drawing.Size(300, 16);
            this.slimCheck.TabIndex = 8;
            this.slimCheck.Text = "スリムスキンかどうか(スキンの腕の一部が黒くなったらチェック)";
            this.slimCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 372);
            this.Controls.Add(this.slimCheck);
            this.Controls.Add(this.createPath);
            this.Controls.Add(this.basePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "FrontAndBackReverseSkin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox basePath;
        private System.Windows.Forms.TextBox createPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox slimCheck;
    }
}

