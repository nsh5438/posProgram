namespace KIMBAM_Project
{
    partial class OrderDisplay
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
            this.components = new System.ComponentModel.Container();
            this.MenuItemImage = new System.Windows.Forms.ImageList(this.components);
            this.NowTimer = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Order_btn = new System.Windows.Forms.Button();
            this.OrderTime = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.RadioButton();
            this.Card = new System.Windows.Forms.RadioButton();
            this.Allprice = new System.Windows.Forms.Label();
            this.lstMenuitem = new System.Windows.Forms.ListView();
            this.MenuImage = new System.Windows.Forms.PictureBox();
            this.AllCancel = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.side = new System.Windows.Forms.Button();
            this.Bunsic = new System.Windows.Forms.Button();
            this.Dongas = new System.Windows.Forms.Button();
            this.Food = new System.Windows.Forms.Button();
            this.Kimbab = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OrderMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BuyBtn = new System.Windows.Forms.Button();
            this.MainBtn = new System.Windows.Forms.Button();
            this.NumTable = new System.Windows.Forms.Label();
            this.NowTime = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemImage
            // 
            this.MenuItemImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.MenuItemImage.ImageSize = new System.Drawing.Size(16, 16);
            this.MenuItemImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // NowTimer
            // 
            this.NowTimer.Interval = 42;
            this.NowTimer.Tick += new System.EventHandler(this.NowTimer_Tick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Order_btn);
            this.tabPage1.Controls.Add(this.OrderTime);
            this.tabPage1.Controls.Add(this.Money);
            this.tabPage1.Controls.Add(this.Card);
            this.tabPage1.Controls.Add(this.Allprice);
            this.tabPage1.Controls.Add(this.lstMenuitem);
            this.tabPage1.Controls.Add(this.MenuImage);
            this.tabPage1.Controls.Add(this.AllCancel);
            this.tabPage1.Controls.Add(this.minus);
            this.tabPage1.Controls.Add(this.plus);
            this.tabPage1.Controls.Add(this.side);
            this.tabPage1.Controls.Add(this.Bunsic);
            this.tabPage1.Controls.Add(this.Dongas);
            this.tabPage1.Controls.Add(this.Food);
            this.tabPage1.Controls.Add(this.Kimbab);
            this.tabPage1.Controls.Add(this.All);
            this.tabPage1.Controls.Add(this.Cancel);
            this.tabPage1.Controls.Add(this.OrderMenu);
            this.tabPage1.Controls.Add(this.BuyBtn);
            this.tabPage1.Controls.Add(this.NumTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "주문";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Order_btn
            // 
            this.Order_btn.BackColor = System.Drawing.Color.SeaShell;
            this.Order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_btn.Font = new System.Drawing.Font("HY헤드라인M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Order_btn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Order_btn.Location = new System.Drawing.Point(1, 393);
            this.Order_btn.Name = "Order_btn";
            this.Order_btn.Size = new System.Drawing.Size(172, 38);
            this.Order_btn.TabIndex = 8;
            this.Order_btn.Text = "주문";
            this.Order_btn.UseVisualStyleBackColor = false;
            // 
            // OrderTime
            // 
            this.OrderTime.BackColor = System.Drawing.Color.Brown;
            this.OrderTime.Font = new System.Drawing.Font("HY헤드라인M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderTime.ForeColor = System.Drawing.Color.White;
            this.OrderTime.Location = new System.Drawing.Point(9, 4);
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.Size = new System.Drawing.Size(278, 35);
            this.OrderTime.TabIndex = 1;
            this.OrderTime.Text = "label1";
            this.OrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(350, 401);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(65, 23);
            this.Money.TabIndex = 7;
            this.Money.TabStop = true;
            this.Money.Text = "현금";
            this.Money.UseVisualStyleBackColor = true;
            // 
            // Card
            // 
            this.Card.AutoSize = true;
            this.Card.Location = new System.Drawing.Point(269, 401);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(65, 23);
            this.Card.TabIndex = 7;
            this.Card.TabStop = true;
            this.Card.Text = "카드";
            this.Card.UseVisualStyleBackColor = true;
            // 
            // Allprice
            // 
            this.Allprice.BackColor = System.Drawing.Color.White;
            this.Allprice.ForeColor = System.Drawing.Color.Black;
            this.Allprice.Location = new System.Drawing.Point(253, 351);
            this.Allprice.Name = "Allprice";
            this.Allprice.Size = new System.Drawing.Size(187, 39);
            this.Allprice.TabIndex = 1;
            this.Allprice.Text = "label1";
            this.Allprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuItem
            // 
            this.lstMenuitem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMenuitem.Location = new System.Drawing.Point(448, 50);
            this.lstMenuitem.Name = "MenuItem";
            this.lstMenuitem.Size = new System.Drawing.Size(532, 617);
            this.lstMenuitem.TabIndex = 6;
            this.lstMenuitem.UseCompatibleStateImageBehavior = false;
            this.lstMenuitem.SelectedIndexChanged += new System.EventHandler(this.MenuItem_Click);
            // 
            // MenuImage
            // 
            this.MenuImage.Location = new System.Drawing.Point(3, 436);
            this.MenuImage.Name = "MenuImage";
            this.MenuImage.Size = new System.Drawing.Size(441, 231);
            this.MenuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuImage.TabIndex = 5;
            this.MenuImage.TabStop = false;
            // 
            // AllCancel
            // 
            this.AllCancel.BackColor = System.Drawing.Color.LightCoral;
            this.AllCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllCancel.Location = new System.Drawing.Point(70, 351);
            this.AllCancel.Name = "AllCancel";
            this.AllCancel.Size = new System.Drawing.Size(103, 39);
            this.AllCancel.TabIndex = 4;
            this.AllCancel.Text = "전체취소";
            this.AllCancel.UseVisualStyleBackColor = false;
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.LightCoral;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("HY헤드라인M", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minus.Location = new System.Drawing.Point(214, 351);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(39, 39);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.LightCoral;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("HY헤드라인M", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plus.Location = new System.Drawing.Point(174, 351);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(39, 39);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            // 
            // side
            // 
            this.side.BackColor = System.Drawing.Color.LightSalmon;
            this.side.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.side.Location = new System.Drawing.Point(895, 4);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(78, 39);
            this.side.TabIndex = 4;
            this.side.Text = "음료";
            this.side.UseVisualStyleBackColor = false;
            // 
            // Bunsic
            // 
            this.Bunsic.BackColor = System.Drawing.Color.LightSalmon;
            this.Bunsic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bunsic.Location = new System.Drawing.Point(811, 4);
            this.Bunsic.Name = "Bunsic";
            this.Bunsic.Size = new System.Drawing.Size(78, 39);
            this.Bunsic.TabIndex = 4;
            this.Bunsic.Text = "분식류";
            this.Bunsic.UseVisualStyleBackColor = false;
            // 
            // Dongas
            // 
            this.Dongas.BackColor = System.Drawing.Color.LightSalmon;
            this.Dongas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dongas.Location = new System.Drawing.Point(705, 4);
            this.Dongas.Name = "Dongas";
            this.Dongas.Size = new System.Drawing.Size(100, 39);
            this.Dongas.TabIndex = 4;
            this.Dongas.Text = "돈가스류";
            this.Dongas.UseVisualStyleBackColor = false;
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.LightSalmon;
            this.Food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Food.Location = new System.Drawing.Point(616, 4);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(83, 39);
            this.Food.TabIndex = 4;
            this.Food.Text = "식사류";
            this.Food.UseVisualStyleBackColor = false;
            // 
            // Kimbab
            // 
            this.Kimbab.BackColor = System.Drawing.Color.LightSalmon;
            this.Kimbab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kimbab.Location = new System.Drawing.Point(528, 4);
            this.Kimbab.Name = "Kimbab";
            this.Kimbab.Size = new System.Drawing.Size(83, 39);
            this.Kimbab.TabIndex = 4;
            this.Kimbab.Text = "김밥류";
            this.Kimbab.UseVisualStyleBackColor = false;
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.LightSalmon;
            this.All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.All.Location = new System.Drawing.Point(454, 4);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(68, 39);
            this.All.TabIndex = 4;
            this.All.Text = "전체";
            this.All.UseVisualStyleBackColor = false;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.LightCoral;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(1, 351);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(68, 39);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // OrderMenu
            // 
            this.OrderMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.OrderMenu.FullRowSelect = true;
            this.OrderMenu.Location = new System.Drawing.Point(1, 49);
            this.OrderMenu.Name = "OrderMenu";
            this.OrderMenu.Size = new System.Drawing.Size(442, 296);
            this.OrderMenu.TabIndex = 3;
            this.OrderMenu.UseCompatibleStateImageBehavior = false;
            this.OrderMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "상품명";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "수량";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "금액";
            this.columnHeader3.Width = 122;
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackColor = System.Drawing.Color.SeaShell;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Font = new System.Drawing.Font("HY헤드라인M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BuyBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BuyBtn.Location = new System.Drawing.Point(174, 393);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(79, 38);
            this.BuyBtn.TabIndex = 0;
            this.BuyBtn.Text = "결제";
            this.BuyBtn.UseVisualStyleBackColor = false;
            // 
            // MainBtn
            // 
            this.MainBtn.BackColor = System.Drawing.Color.SeaShell;
            this.MainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainBtn.Font = new System.Drawing.Font("HY헤드라인M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.MainBtn.Location = new System.Drawing.Point(902, 702);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(64, 38);
            this.MainBtn.TabIndex = 0;
            this.MainBtn.Text = "Main";
            this.MainBtn.UseVisualStyleBackColor = false;
            // 
            // NumTable
            // 
            this.NumTable.BackColor = System.Drawing.Color.Brown;
            this.NumTable.ForeColor = System.Drawing.Color.White;
            this.NumTable.Location = new System.Drawing.Point(0, 0);
            this.NumTable.Name = "NumTable";
            this.NumTable.Size = new System.Drawing.Size(444, 44);
            this.NumTable.TabIndex = 1;
            this.NumTable.Text = "label1";
            // 
            // NowTime
            // 
            this.NowTime.BackColor = System.Drawing.Color.RosyBrown;
            this.NowTime.Font = new System.Drawing.Font("HY헤드라인M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NowTime.ForeColor = System.Drawing.Color.White;
            this.NowTime.Location = new System.Drawing.Point(3, 693);
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(971, 55);
            this.NowTime.TabIndex = 1;
            this.NowTime.Text = "label1";
            this.NowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("HY헤드라인M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 696);
            this.tabControl1.TabIndex = 0;
            // 
            // OrderDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(978, 749);
            this.Controls.Add(this.MainBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.NowTime);
            this.KeyPreview = true;
            this.Name = "OrderDisplay";
            this.Text = "order";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList MenuItemImage;
        private System.Windows.Forms.Timer NowTimer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Order_btn;
        private System.Windows.Forms.RadioButton Money;
        private System.Windows.Forms.RadioButton Card;
        private System.Windows.Forms.Label NowTime;
        private System.Windows.Forms.Label Allprice;
        private System.Windows.Forms.ListView lstMenuitem;
        private System.Windows.Forms.PictureBox MenuImage;
        private System.Windows.Forms.Button AllCancel;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button side;
        private System.Windows.Forms.Button Bunsic;
        private System.Windows.Forms.Button Dongas;
        private System.Windows.Forms.Button Food;
        private System.Windows.Forms.Button Kimbab;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ListView OrderMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Button MainBtn;
        private System.Windows.Forms.Label NumTable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label OrderTime;
    }
}