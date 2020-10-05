namespace Triangle_HW
{
    partial class TriangleCounter
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
            this.tbSideA = new System.Windows.Forms.TextBox();
            this.tbSideB = new System.Windows.Forms.TextBox();
            this.tbSideC = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Button();
            this.side1 = new System.Windows.Forms.Label();
            this.side2 = new System.Windows.Forms.Label();
            this.side3 = new System.Windows.Forms.Label();
            this.lbAngles = new System.Windows.Forms.Label();
            this.lbPerimetr = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbNTriangle = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSideA
            // 
            this.tbSideA.Location = new System.Drawing.Point(103, 107);
            this.tbSideA.Name = "tbSideA";
            this.tbSideA.Size = new System.Drawing.Size(100, 31);
            this.tbSideA.TabIndex = 0;
            this.tbSideA.Text = "0";
            // 
            // tbSideB
            // 
            this.tbSideB.Location = new System.Drawing.Point(283, 107);
            this.tbSideB.Name = "tbSideB";
            this.tbSideB.Size = new System.Drawing.Size(100, 31);
            this.tbSideB.TabIndex = 1;
            this.tbSideB.Text = "0";
            // 
            // tbSideC
            // 
            this.tbSideC.Location = new System.Drawing.Point(481, 107);
            this.tbSideC.Name = "tbSideC";
            this.tbSideC.Size = new System.Drawing.Size(100, 31);
            this.tbSideC.TabIndex = 2;
            this.tbSideC.Text = "0";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(118, 259);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(324, 160);
            this.Result.TabIndex = 3;
            this.Result.Text = "Get result";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // side1
            // 
            this.side1.AutoSize = true;
            this.side1.Location = new System.Drawing.Point(103, 48);
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(75, 25);
            this.side1.TabIndex = 5;
            this.side1.Text = "Side A";
            // 
            // side2
            // 
            this.side2.AutoSize = true;
            this.side2.Location = new System.Drawing.Point(278, 48);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(75, 25);
            this.side2.TabIndex = 6;
            this.side2.Text = "Side B";
            // 
            // side3
            // 
            this.side3.AutoSize = true;
            this.side3.Location = new System.Drawing.Point(476, 48);
            this.side3.Name = "side3";
            this.side3.Size = new System.Drawing.Size(76, 25);
            this.side3.TabIndex = 7;
            this.side3.Text = "Side C";
            // 
            // lbAngles
            // 
            this.lbAngles.AutoSize = true;
            this.lbAngles.Location = new System.Drawing.Point(704, 132);
            this.lbAngles.Name = "lbAngles";
            this.lbAngles.Size = new System.Drawing.Size(78, 25);
            this.lbAngles.TabIndex = 8;
            this.lbAngles.Text = "Angles";
            // 
            // lbPerimetr
            // 
            this.lbPerimetr.AutoSize = true;
            this.lbPerimetr.Location = new System.Drawing.Point(704, 259);
            this.lbPerimetr.Name = "lbPerimetr";
            this.lbPerimetr.Size = new System.Drawing.Size(92, 25);
            this.lbPerimetr.TabIndex = 9;
            this.lbPerimetr.Text = "Perimetr";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(714, 347);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(57, 25);
            this.lbArea.TabIndex = 10;
            this.lbArea.Text = "Area";
            // 
            // lbNTriangle
            // 
            this.lbNTriangle.AutoSize = true;
            this.lbNTriangle.Location = new System.Drawing.Point(726, 455);
            this.lbNTriangle.Name = "lbNTriangle";
            this.lbNTriangle.Size = new System.Drawing.Size(0, 25);
            this.lbNTriangle.TabIndex = 11;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(204, 466);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(158, 70);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change sides";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // TriangleCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 597);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lbNTriangle);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbPerimetr);
            this.Controls.Add(this.lbAngles);
            this.Controls.Add(this.side3);
            this.Controls.Add(this.side2);
            this.Controls.Add(this.side1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.tbSideC);
            this.Controls.Add(this.tbSideB);
            this.Controls.Add(this.tbSideA);
            this.Name = "TriangleCounter";
            this.Text = "Triangle Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSideA;
        private System.Windows.Forms.TextBox tbSideB;
        private System.Windows.Forms.TextBox tbSideC;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label side1;
        private System.Windows.Forms.Label side2;
        private System.Windows.Forms.Label side3;
        private System.Windows.Forms.Label lbAngles;
        private System.Windows.Forms.Label lbPerimetr;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbNTriangle;
        private System.Windows.Forms.Button btnChange;
    }
}

