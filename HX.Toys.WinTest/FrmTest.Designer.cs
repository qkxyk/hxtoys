namespace HX.Toys.WinTest
{
    partial class FrmTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateStu = new System.Windows.Forms.Button();
            this.btnGetStu = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateStu
            // 
            this.btnCreateStu.Location = new System.Drawing.Point(762, 24);
            this.btnCreateStu.Name = "btnCreateStu";
            this.btnCreateStu.Size = new System.Drawing.Size(86, 31);
            this.btnCreateStu.TabIndex = 0;
            this.btnCreateStu.Text = "创建学生";
            this.btnCreateStu.UseVisualStyleBackColor = true;
            this.btnCreateStu.Click += new System.EventHandler(this.btnCreateStu_Click);
            // 
            // btnGetStu
            // 
            this.btnGetStu.Location = new System.Drawing.Point(762, 61);
            this.btnGetStu.Name = "btnGetStu";
            this.btnGetStu.Size = new System.Drawing.Size(86, 31);
            this.btnGetStu.TabIndex = 0;
            this.btnGetStu.Text = "获取学生";
            this.btnGetStu.UseVisualStyleBackColor = true;
            this.btnGetStu.Click += new System.EventHandler(this.btnGetStu_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(762, 99);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "更新学生";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Location = new System.Drawing.Point(762, 140);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(108, 36);
            this.btnAddOrUpdate.TabIndex = 2;
            this.btnAddOrUpdate.Text = "添加或者更新";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(489, 148);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(177, 25);
            this.txtUser.TabIndex = 3;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(762, 183);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(108, 30);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(762, 220);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(108, 29);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "添加书籍";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(40, 61);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(120, 30);
            this.btnAsync.TabIndex = 6;
            this.btnAsync.Text = "异步Test";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 364);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetStu);
            this.Controls.Add(this.btnCreateStu);
            this.Name = "FrmTest";
            this.Text = "FrmTest";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateStu;
        private System.Windows.Forms.Button btnGetStu;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnAsync;
    }
}

