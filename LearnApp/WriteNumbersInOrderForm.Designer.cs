namespace MathGame
{
    partial class WriteNumbersInOrderForm
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.trfl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(167, 74);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(671, 48);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Arrange the numbers in ascending order:";
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(167, 185);
            this.txtNumbers.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(991, 55);
            this.txtNumbers.TabIndex = 1;
            this.txtNumbers.TextChanged += new System.EventHandler(this.txtNumbers_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(167, 295);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(250, 85);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // trfl
            // 
            this.trfl.BackColor = System.Drawing.Color.White;
            this.trfl.Location = new System.Drawing.Point(476, 311);
            this.trfl.Name = "trfl";
            this.trfl.Size = new System.Drawing.Size(61, 69);
            this.trfl.TabIndex = 7;
            this.trfl.UseVisualStyleBackColor = false;
            this.trfl.Click += new System.EventHandler(this.trfl_Click);
            // 
            // WriteNumbersInOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 1108);
            this.Controls.Add(this.trfl);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.lblInstruction);
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Name = "WriteNumbersInOrderForm";
            this.Text = "Write Numbers in Order";
            this.Load += new System.EventHandler(this.WriteNumbersInOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button trfl;
    }
}