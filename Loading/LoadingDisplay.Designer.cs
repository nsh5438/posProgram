namespace KIMBAM_Project
{
    partial class LoadingDisplay
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingDisplay));
            this.LoadingPgb = new System.Windows.Forms.ProgressBar();
            this.TimerLoad = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadingPgb
            // 
            this.LoadingPgb.ForeColor = System.Drawing.Color.Maroon;
            this.LoadingPgb.Location = new System.Drawing.Point(59, 412);
            this.LoadingPgb.Maximum = 30;
            this.LoadingPgb.Name = "LoadingPgb";
            this.LoadingPgb.Size = new System.Drawing.Size(584, 43);
            this.LoadingPgb.TabIndex = 0;
            // 
            // TimerLoad
            // 
            this.TimerLoad.Interval = 42;
            this.TimerLoad.Tick += new System.EventHandler(this.TimerLoad_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("HY헤드라인M", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(240, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "KIMBAP";
            // 
            // LoadingDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(711, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadingPgb);
            this.Name = "LoadingDisplay";
            this.Text = "KIMBAM_Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar LoadingPgb;
        private System.Windows.Forms.Timer TimerLoad;
        private System.Windows.Forms.Label label1;
    }
}

