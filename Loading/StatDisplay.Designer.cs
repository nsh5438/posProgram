namespace KIMBAM_Project
{
    partial class StatDisplay
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
            this.MenuCategory = new System.Windows.Forms.Panel();
            this.pay_stat = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category_stat = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuName = new System.Windows.Forms.Panel();
            this.Menu_stat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.MenuCategory.SuspendLayout();
            this.MenuName.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuCategory
            // 
            this.MenuCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuCategory.Controls.Add(this.pay_stat);
            this.MenuCategory.Controls.Add(this.category_stat);
            this.MenuCategory.Controls.Add(this.label3);
            this.MenuCategory.Controls.Add(this.label1);
            this.MenuCategory.Location = new System.Drawing.Point(2, 1);
            this.MenuCategory.Name = "MenuCategory";
            this.MenuCategory.Size = new System.Drawing.Size(457, 589);
            this.MenuCategory.TabIndex = 2;
            // 
            // pay_stat
            // 
            this.pay_stat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pay_stat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader8});
            this.pay_stat.Font = new System.Drawing.Font("HY헤드라인M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pay_stat.FullRowSelect = true;
            this.pay_stat.Location = new System.Drawing.Point(49, 410);
            this.pay_stat.Name = "pay_stat";
            this.pay_stat.Size = new System.Drawing.Size(351, 155);
            this.pay_stat.TabIndex = 10;
            this.pay_stat.UseCompatibleStateImageBehavior = false;
            this.pay_stat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "결제방법";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "매출액";
            this.columnHeader8.Width = 100;
            // 
            // category_stat
            // 
            this.category_stat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.category_stat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader3});
            this.category_stat.Font = new System.Drawing.Font("HY헤드라인M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.category_stat.FullRowSelect = true;
            this.category_stat.Location = new System.Drawing.Point(49, 79);
            this.category_stat.Name = "category_stat";
            this.category_stat.Size = new System.Drawing.Size(351, 240);
            this.category_stat.TabIndex = 10;
            this.category_stat.UseCompatibleStateImageBehavior = false;
            this.category_stat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "카테고리";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "판매량";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "매출액";
            this.columnHeader3.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY헤드라인M", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(17, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "결제방법별";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY헤드라인M", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "카테고리별";
            // 
            // MenuName
            // 
            this.MenuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuName.Controls.Add(this.Menu_stat);
            this.MenuName.Controls.Add(this.label2);
            this.MenuName.Location = new System.Drawing.Point(478, 1);
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(457, 589);
            this.MenuName.TabIndex = 3;
            // 
            // Menu_stat
            // 
            this.Menu_stat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Menu_stat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader9});
            this.Menu_stat.Font = new System.Drawing.Font("HY헤드라인M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Menu_stat.FullRowSelect = true;
            this.Menu_stat.Location = new System.Drawing.Point(38, 79);
            this.Menu_stat.Name = "Menu_stat";
            this.Menu_stat.Size = new System.Drawing.Size(380, 450);
            this.Menu_stat.TabIndex = 10;
            this.Menu_stat.UseCompatibleStateImageBehavior = false;
            this.Menu_stat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "메뉴이름";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "판매량";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "매출액";
            this.columnHeader9.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY헤드라인M", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "메뉴별";
            // 
            // StmtDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 593);
            this.Controls.Add(this.MenuCategory);
            this.Controls.Add(this.MenuName);
            this.Name = "StmtDisplay";
            this.Text = "StmtDisplay";
            this.MenuCategory.ResumeLayout(false);
            this.MenuCategory.PerformLayout();
            this.MenuName.ResumeLayout(false);
            this.MenuName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuCategory;
        private System.Windows.Forms.ListView category_stat;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MenuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView Menu_stat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView pay_stat;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}