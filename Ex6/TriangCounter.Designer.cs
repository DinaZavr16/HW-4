namespace Ex6
{
    partial class TriangCounter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSideA = new System.Windows.Forms.Label();
            this.lbAngle = new System.Windows.Forms.Label();
            this.lbSideB = new System.Windows.Forms.Label();
            this.tbSideA = new System.Windows.Forms.TextBox();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.tbSideB = new System.Windows.Forms.TextBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbPerim = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSideA
            // 
            this.lbSideA.AutoSize = true;
            this.lbSideA.Location = new System.Drawing.Point(49, 51);
            this.lbSideA.Name = "lbSideA";
            this.lbSideA.Size = new System.Drawing.Size(75, 25);
            this.lbSideA.TabIndex = 0;
            this.lbSideA.Text = "Side A";
            // 
            // lbAngle
            // 
            this.lbAngle.AutoSize = true;
            this.lbAngle.Location = new System.Drawing.Point(425, 51);
            this.lbAngle.Name = "lbAngle";
            this.lbAngle.Size = new System.Drawing.Size(101, 25);
            this.lbAngle.TabIndex = 1;
            this.lbAngle.Text = "Angle AB";
            // 
            // lbSideB
            // 
            this.lbSideB.AutoSize = true;
            this.lbSideB.Location = new System.Drawing.Point(241, 51);
            this.lbSideB.Name = "lbSideB";
            this.lbSideB.Size = new System.Drawing.Size(75, 25);
            this.lbSideB.TabIndex = 2;
            this.lbSideB.Text = "Side B";
            // 
            // tbSideA
            // 
            this.tbSideA.Location = new System.Drawing.Point(33, 112);
            this.tbSideA.Name = "tbSideA";
            this.tbSideA.Size = new System.Drawing.Size(100, 31);
            this.tbSideA.TabIndex = 3;
            this.tbSideA.Text = "0";
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(430, 112);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(100, 31);
            this.tbAngle.TabIndex = 4;
            this.tbAngle.Text = "0";
            // 
            // tbSideB
            // 
            this.tbSideB.Location = new System.Drawing.Point(216, 112);
            this.tbSideB.Name = "tbSideB";
            this.tbSideB.Size = new System.Drawing.Size(100, 31);
            this.tbSideB.TabIndex = 5;
            this.tbSideB.Text = "0";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(142, 297);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(79, 25);
            this.lbArea.TabIndex = 6;
            this.lbArea.Text = "Area is";
            // 
            // lbPerim
            // 
            this.lbPerim.AutoSize = true;
            this.lbPerim.Location = new System.Drawing.Point(128, 242);
            this.lbPerim.Name = "lbPerim";
            this.lbPerim.Size = new System.Drawing.Size(114, 25);
            this.lbPerim.TabIndex = 7;
            this.lbPerim.Text = "Perimetr is";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(598, 39);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(215, 151);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Get result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(447, 263);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 25);
            this.lbError.TabIndex = 9;
            // 
            // TriangCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 447);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lbPerim);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.tbSideB);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.tbSideA);
            this.Controls.Add(this.lbSideB);
            this.Controls.Add(this.lbAngle);
            this.Controls.Add(this.lbSideA);
            this.Name = "TriangCounter";
            this.Text = "Triangle Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSideA;
        private System.Windows.Forms.Label lbAngle;
        private System.Windows.Forms.Label lbSideB;
        private System.Windows.Forms.TextBox tbSideA;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.TextBox tbSideB;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbPerim;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lbError;
    }
}

