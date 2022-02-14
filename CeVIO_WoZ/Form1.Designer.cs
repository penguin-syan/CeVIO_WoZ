
namespace CeVIO_WoZ
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.単純応答 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.複雑応答 = new System.Windows.Forms.TabPage();
            this.あいづち = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.edit_simpleReturn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.単純応答.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.単純応答);
            this.tabControl1.Controls.Add(this.複雑応答);
            this.tabControl1.Controls.Add(this.あいづち);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // 単純応答
            // 
            this.単純応答.Controls.Add(this.edit_simpleReturn);
            this.単純応答.Controls.Add(this.button2);
            this.単純応答.Controls.Add(this.textBox1);
            this.単純応答.Location = new System.Drawing.Point(4, 22);
            this.単純応答.Name = "単純応答";
            this.単純応答.Padding = new System.Windows.Forms.Padding(3);
            this.単純応答.Size = new System.Drawing.Size(768, 400);
            this.単純応答.TabIndex = 0;
            this.単純応答.Text = "単純応答";
            this.単純応答.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "手入力";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(644, 19);
            this.textBox1.TabIndex = 1;
            // 
            // 複雑応答
            // 
            this.複雑応答.Location = new System.Drawing.Point(4, 22);
            this.複雑応答.Name = "複雑応答";
            this.複雑応答.Padding = new System.Windows.Forms.Padding(3);
            this.複雑応答.Size = new System.Drawing.Size(768, 400);
            this.複雑応答.TabIndex = 1;
            this.複雑応答.Text = "複雑応答";
            this.複雑応答.UseVisualStyleBackColor = true;
            // 
            // あいづち
            // 
            this.あいづち.Location = new System.Drawing.Point(4, 22);
            this.あいづち.Name = "あいづち";
            this.あいづち.Size = new System.Drawing.Size(768, 400);
            this.あいづち.TabIndex = 2;
            this.あいづち.Text = "あいづち";
            this.あいづち.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // edit_simpleReturn
            // 
            this.edit_simpleReturn.Location = new System.Drawing.Point(687, 6);
            this.edit_simpleReturn.Name = "edit_simpleReturn";
            this.edit_simpleReturn.Size = new System.Drawing.Size(75, 23);
            this.edit_simpleReturn.TabIndex = 3;
            this.edit_simpleReturn.Text = "編集";
            this.edit_simpleReturn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.単純応答.ResumeLayout(false);
            this.単純応答.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 単純応答;
        private System.Windows.Forms.TabPage 複雑応答;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage あいづち;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button edit_simpleReturn;
    }
}

