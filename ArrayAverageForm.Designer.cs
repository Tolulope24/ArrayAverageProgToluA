namespace ArrayAverageProgToluA
{
    partial class frmArrayAverage
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstArrayList = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 334);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstArrayList
            // 
            this.lstArrayList.FormattingEnabled = true;
            this.lstArrayList.Location = new System.Drawing.Point(67, 41);
            this.lstArrayList.Name = "lstArrayList";
            this.lstArrayList.Size = new System.Drawing.Size(140, 264);
            this.lstArrayList.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(104, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(135, 338);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 16);
            this.lblAnswer.TabIndex = 3;
            // 
            // frmArrayAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 369);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstArrayList);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmArrayAverage";
            this.Text = "Array Average";
            this.Load += new System.EventHandler(this.frmArrayAverage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lstArrayList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblAnswer;
    }
}

