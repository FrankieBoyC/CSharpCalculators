namespace homework_4
{
    partial class compareForm
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
            this.txtBxCalc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.bttnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxCalc
            // 
            this.txtBxCalc.Location = new System.Drawing.Point(227, 100);
            this.txtBxCalc.Name = "txtBxCalc";
            this.txtBxCalc.Size = new System.Drawing.Size(100, 23);
            this.txtBxCalc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(101, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value from Calculator";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(390, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Second Value";
            // 
            // txtBxInput
            // 
            this.txtBxInput.Location = new System.Drawing.Point(522, 103);
            this.txtBxInput.Name = "txtBxInput";
            this.txtBxInput.Size = new System.Drawing.Size(100, 23);
            this.txtBxInput.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(373, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Largest";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResult.Location = new System.Drawing.Point(363, 272);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 23);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnCompare
            // 
            this.bttnCompare.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnCompare.Location = new System.Drawing.Point(654, 340);
            this.bttnCompare.Name = "bttnCompare";
            this.bttnCompare.Size = new System.Drawing.Size(76, 30);
            this.bttnCompare.TabIndex = 5;
            this.bttnCompare.Text = "Compare";
            this.bttnCompare.UseVisualStyleBackColor = true;
            this.bttnCompare.Click += new System.EventHandler(this.bttnCompare_Click);
            // 
            // compareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnCompare);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxInput);
            this.Controls.Add(this.txtBxCalc);
            this.Name = "compareForm";
            this.Text = "compareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBxCalc;
        private Label label1;
        private Label label2;
        private TextBox txtBxInput;
        private Label label3;
        private Label lblResult;
        private Button bttnCompare;
    }
}