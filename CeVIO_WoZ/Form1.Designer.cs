
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
            this.tab1_selfTalkButton = new System.Windows.Forms.Button();
            this.tab1_selfInputBox = new System.Windows.Forms.TextBox();
            this.複雑応答 = new System.Windows.Forms.TabPage();
            this.あいづち = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.edit_tab1 = new System.Windows.Forms.Button();
            this.tab1_namebox = new System.Windows.Forms.TextBox();
            this.tab1_setInputBox1 = new System.Windows.Forms.TextBox();
            this.tab1_setTalkButton1 = new System.Windows.Forms.Button();
            this.tab1_setTalkButton2 = new System.Windows.Forms.Button();
            this.tab1_setTalkButton3 = new System.Windows.Forms.Button();
            this.tab1_setTalkButton4 = new System.Windows.Forms.Button();
            this.tab1_setTalkButton5 = new System.Windows.Forms.Button();
            this.tab1_setTalkButton6 = new System.Windows.Forms.Button();
            this.tab1_setTalkButton7 = new System.Windows.Forms.Button();
            this.tab1_setInputBox2 = new System.Windows.Forms.TextBox();
            this.tab1_setInputBox3 = new System.Windows.Forms.TextBox();
            this.tab1_setInputBox4 = new System.Windows.Forms.TextBox();
            this.tab1_setInputBox5 = new System.Windows.Forms.TextBox();
            this.tab1_setInputBox6 = new System.Windows.Forms.TextBox();
            this.tab1_setInputBox7 = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(776, 364);
            this.tabControl1.TabIndex = 1;
            // 
            // 単純応答
            // 
            this.単純応答.Controls.Add(this.tab1_setTalkButton7);
            this.単純応答.Controls.Add(this.tab1_setTalkButton6);
            this.単純応答.Controls.Add(this.tab1_setTalkButton5);
            this.単純応答.Controls.Add(this.tab1_setTalkButton4);
            this.単純応答.Controls.Add(this.tab1_setTalkButton3);
            this.単純応答.Controls.Add(this.tab1_setTalkButton2);
            this.単純応答.Controls.Add(this.tab1_setTalkButton1);
            this.単純応答.Controls.Add(this.tab1_setInputBox7);
            this.単純応答.Controls.Add(this.tab1_setInputBox6);
            this.単純応答.Controls.Add(this.tab1_setInputBox5);
            this.単純応答.Controls.Add(this.tab1_setInputBox4);
            this.単純応答.Controls.Add(this.tab1_setInputBox3);
            this.単純応答.Controls.Add(this.tab1_setInputBox2);
            this.単純応答.Controls.Add(this.tab1_setInputBox1);
            this.単純応答.Controls.Add(this.tab1_namebox);
            this.単純応答.Controls.Add(this.edit_tab1);
            this.単純応答.Location = new System.Drawing.Point(4, 28);
            this.単純応答.Name = "単純応答";
            this.単純応答.Padding = new System.Windows.Forms.Padding(3);
            this.単純応答.Size = new System.Drawing.Size(768, 332);
            this.単純応答.TabIndex = 0;
            this.単純応答.Text = "単純応答";
            this.単純応答.UseVisualStyleBackColor = true;
            // 
            // tab1_selfTalkButton
            // 
            this.tab1_selfTalkButton.Location = new System.Drawing.Point(672, 398);
            this.tab1_selfTalkButton.Name = "tab1_selfTalkButton";
            this.tab1_selfTalkButton.Size = new System.Drawing.Size(106, 34);
            this.tab1_selfTalkButton.TabIndex = 2;
            this.tab1_selfTalkButton.Text = "←発話";
            this.tab1_selfTalkButton.UseVisualStyleBackColor = true;
            this.tab1_selfTalkButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tab1_selfInputBox
            // 
            this.tab1_selfInputBox.Location = new System.Drawing.Point(22, 403);
            this.tab1_selfInputBox.Name = "tab1_selfInputBox";
            this.tab1_selfInputBox.Size = new System.Drawing.Size(644, 25);
            this.tab1_selfInputBox.TabIndex = 1;
            // 
            // 複雑応答
            // 
            this.複雑応答.Location = new System.Drawing.Point(4, 28);
            this.複雑応答.Name = "複雑応答";
            this.複雑応答.Padding = new System.Windows.Forms.Padding(3);
            this.複雑応答.Size = new System.Drawing.Size(768, 394);
            this.複雑応答.TabIndex = 1;
            this.複雑応答.Text = "複雑応答";
            this.複雑応答.UseVisualStyleBackColor = true;
            // 
            // あいづち
            // 
            this.あいづち.Location = new System.Drawing.Point(4, 28);
            this.あいづち.Name = "あいづち";
            this.あいづち.Size = new System.Drawing.Size(768, 394);
            this.あいづち.TabIndex = 2;
            this.あいづち.Text = "あいづち";
            this.あいづち.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(768, 394);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // edit_tab1
            // 
            this.edit_tab1.Location = new System.Drawing.Point(656, 6);
            this.edit_tab1.Name = "edit_tab1";
            this.edit_tab1.Size = new System.Drawing.Size(106, 34);
            this.edit_tab1.TabIndex = 3;
            this.edit_tab1.Text = "編集";
            this.edit_tab1.UseVisualStyleBackColor = true;
            this.edit_tab1.Click += new System.EventHandler(this.edit_tab1_Click);
            // 
            // tab1_namebox
            // 
            this.tab1_namebox.Location = new System.Drawing.Point(439, 11);
            this.tab1_namebox.Name = "tab1_namebox";
            this.tab1_namebox.Size = new System.Drawing.Size(211, 25);
            this.tab1_namebox.TabIndex = 4;
            // 
            // tab1_setInputBox1
            // 
            this.tab1_setInputBox1.Location = new System.Drawing.Point(6, 51);
            this.tab1_setInputBox1.Name = "tab1_setInputBox1";
            this.tab1_setInputBox1.Size = new System.Drawing.Size(644, 25);
            this.tab1_setInputBox1.TabIndex = 5;
            // 
            // tab1_setTalkButton1
            // 
            this.tab1_setTalkButton1.Location = new System.Drawing.Point(656, 46);
            this.tab1_setTalkButton1.Name = "tab1_setTalkButton1";
            this.tab1_setTalkButton1.Size = new System.Drawing.Size(106, 34);
            this.tab1_setTalkButton1.TabIndex = 6;
            this.tab1_setTalkButton1.Text = "発話";
            this.tab1_setTalkButton1.UseVisualStyleBackColor = true;
            // 
            // tab1_setTalkButton2
            // 
            this.tab1_setTalkButton2.Location = new System.Drawing.Point(656, 86);
            this.tab1_setTalkButton2.Name = "tab1_setTalkButton2";
            this.tab1_setTalkButton2.Size = new System.Drawing.Size(106, 34);
            this.tab1_setTalkButton2.TabIndex = 6;
            this.tab1_setTalkButton2.Text = "発話";
            this.tab1_setTalkButton2.UseVisualStyleBackColor = true;
            // 
            // tab1_setTalkButton3
            // 
            this.tab1_setTalkButton3.Location = new System.Drawing.Point(656, 126);
            this.tab1_setTalkButton3.Name = "tab1_setTalkButton3";
            this.tab1_setTalkButton3.Size = new System.Drawing.Size(106, 34);
            this.tab1_setTalkButton3.TabIndex = 6;
            this.tab1_setTalkButton3.Text = "発話";
            this.tab1_setTalkButton3.UseVisualStyleBackColor = true;
            // 
            // tab1_setTalkButton4
            // 
            this.tab1_setTalkButton4.Location = new System.Drawing.Point(656, 166);
            this.tab1_setTalkButton4.Name = "tab1_setTalkButton4";
            this.tab1_setTalkButton4.Size = new System.Drawing.Size(106, 34);
            this.tab1_setTalkButton4.TabIndex = 6;
            this.tab1_setTalkButton4.Text = "発話";
            this.tab1_setTalkButton4.UseVisualStyleBackColor = true;
            // 
            // tab1_setTalkButton5
            // 
            this.tab1_setTalkButton5.Location = new System.Drawing.Point(656, 206);
            this.tab1_setTalkButton5.Name = "tab1_setTalkButton5";
            this.tab1_setTalkButton5.Size = new System.Drawing.Size(106, 34);
            this.tab1_setTalkButton5.TabIndex = 6;
            this.tab1_setTalkButton5.Text = "発話";
            this.tab1_setTalkButton5.UseVisualStyleBackColor = true;
            // 
            // tab1_setTalkButton6
            // 
            this.tab1_setTalkButton6.Location = new System.Drawing.Point(656, 246);
            this.tab1_setTalkButton6.Name = "tab1_setTalkButton6";
            this.tab1_setTalkButton6.Size = new System.Drawing.Size(106, 34);
            this.tab1_setTalkButton6.TabIndex = 6;
            this.tab1_setTalkButton6.Text = "発話";
            this.tab1_setTalkButton6.UseVisualStyleBackColor = true;
            // 
            // tab1_setTalkButton7
            // 
            this.tab1_setTalkButton7.Location = new System.Drawing.Point(656, 286);
            this.tab1_setTalkButton7.Name = "tab1_setTalkButton7";
            this.tab1_setTalkButton7.Size = new System.Drawing.Size(106, 34);
            this.tab1_setTalkButton7.TabIndex = 6;
            this.tab1_setTalkButton7.Text = "発話";
            this.tab1_setTalkButton7.UseVisualStyleBackColor = true;
            // 
            // tab1_setInputBox2
            // 
            this.tab1_setInputBox2.Location = new System.Drawing.Point(6, 91);
            this.tab1_setInputBox2.Name = "tab1_setInputBox2";
            this.tab1_setInputBox2.Size = new System.Drawing.Size(644, 25);
            this.tab1_setInputBox2.TabIndex = 5;
            // 
            // tab1_setInputBox3
            // 
            this.tab1_setInputBox3.Location = new System.Drawing.Point(6, 131);
            this.tab1_setInputBox3.Name = "tab1_setInputBox3";
            this.tab1_setInputBox3.Size = new System.Drawing.Size(644, 25);
            this.tab1_setInputBox3.TabIndex = 5;
            // 
            // tab1_setInputBox4
            // 
            this.tab1_setInputBox4.Location = new System.Drawing.Point(6, 171);
            this.tab1_setInputBox4.Name = "tab1_setInputBox4";
            this.tab1_setInputBox4.Size = new System.Drawing.Size(644, 25);
            this.tab1_setInputBox4.TabIndex = 5;
            // 
            // tab1_setInputBox5
            // 
            this.tab1_setInputBox5.Location = new System.Drawing.Point(6, 211);
            this.tab1_setInputBox5.Name = "tab1_setInputBox5";
            this.tab1_setInputBox5.Size = new System.Drawing.Size(644, 25);
            this.tab1_setInputBox5.TabIndex = 5;
            // 
            // tab1_setInputBox6
            // 
            this.tab1_setInputBox6.Location = new System.Drawing.Point(6, 251);
            this.tab1_setInputBox6.Name = "tab1_setInputBox6";
            this.tab1_setInputBox6.Size = new System.Drawing.Size(644, 25);
            this.tab1_setInputBox6.TabIndex = 5;
            // 
            // tab1_setInputBox7
            // 
            this.tab1_setInputBox7.Location = new System.Drawing.Point(6, 291);
            this.tab1_setInputBox7.Name = "tab1_setInputBox7";
            this.tab1_setInputBox7.Size = new System.Drawing.Size(644, 25);
            this.tab1_setInputBox7.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tab1_selfInputBox);
            this.Controls.Add(this.tab1_selfTalkButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.単純応答.ResumeLayout(false);
            this.単純応答.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 単純応答;
        private System.Windows.Forms.TabPage 複雑応答;
        private System.Windows.Forms.Button tab1_selfTalkButton;
        private System.Windows.Forms.TextBox tab1_selfInputBox;
        private System.Windows.Forms.TabPage あいづち;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tab1_namebox;
        private System.Windows.Forms.Button edit_tab1;
        private System.Windows.Forms.Button tab1_setTalkButton7;
        private System.Windows.Forms.Button tab1_setTalkButton6;
        private System.Windows.Forms.Button tab1_setTalkButton5;
        private System.Windows.Forms.Button tab1_setTalkButton4;
        private System.Windows.Forms.Button tab1_setTalkButton3;
        private System.Windows.Forms.Button tab1_setTalkButton2;
        private System.Windows.Forms.Button tab1_setTalkButton1;
        private System.Windows.Forms.TextBox tab1_setInputBox7;
        private System.Windows.Forms.TextBox tab1_setInputBox6;
        private System.Windows.Forms.TextBox tab1_setInputBox5;
        private System.Windows.Forms.TextBox tab1_setInputBox4;
        private System.Windows.Forms.TextBox tab1_setInputBox3;
        private System.Windows.Forms.TextBox tab1_setInputBox2;
        private System.Windows.Forms.TextBox tab1_setInputBox1;
    }
}

