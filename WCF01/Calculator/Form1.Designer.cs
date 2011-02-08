namespace Calculator
{
	partial class Form1
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.btnSubtract = new System.Windows.Forms.Button();
			this.btnMultiply = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(26, 91);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "+ (ADD)";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(26, 35);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 20);
			this.txtNum1.TabIndex = 1;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(156, 35);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 20);
			this.txtNum2.TabIndex = 2;
			// 
			// btnSubtract
			// 
			this.btnSubtract.Location = new System.Drawing.Point(107, 91);
			this.btnSubtract.Name = "btnSubtract";
			this.btnSubtract.Size = new System.Drawing.Size(75, 23);
			this.btnSubtract.TabIndex = 3;
			this.btnSubtract.Text = "- (Subtract)";
			this.btnSubtract.UseVisualStyleBackColor = true;
			// 
			// btnMultiply
			// 
			this.btnMultiply.Location = new System.Drawing.Point(188, 91);
			this.btnMultiply.Name = "btnMultiply";
			this.btnMultiply.Size = new System.Drawing.Size(75, 23);
			this.btnMultiply.TabIndex = 4;
			this.btnMultiply.Text = "* (Multiply)";
			this.btnMultiply.UseVisualStyleBackColor = true;
			// 
			// btnDivide
			// 
			this.btnDivide.Location = new System.Drawing.Point(107, 135);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(75, 23);
			this.btnDivide.TabIndex = 5;
			this.btnDivide.Text = "\\ (Divide)";
			this.btnDivide.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 201);
			this.Controls.Add(this.btnDivide);
			this.Controls.Add(this.btnMultiply);
			this.Controls.Add(this.btnSubtract);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.btnAdd);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.Button btnSubtract;
		private System.Windows.Forms.Button btnMultiply;
		private System.Windows.Forms.Button btnDivide;
	}
}

