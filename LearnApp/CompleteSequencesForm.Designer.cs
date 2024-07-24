namespace MathGame
{
    partial class CompleteSequencesForm
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
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
            this.lblInstruction.Size = new System.Drawing.Size(0, 48);
            this.lblInstruction.TabIndex = 0;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(167, 185);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(157, 55);
            this.txtNumber1.TabIndex = 1;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(400, 185);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(157, 55);
            this.txtNumber2.TabIndex = 2;
            this.txtNumber2.TextChanged += new System.EventHandler(this.txtNumber2_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(167, 295);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(250, 85);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // trfl
            // 
            this.trfl.BackColor = System.Drawing.Color.White;
            this.trfl.Location = new System.Drawing.Point(442, 311);
            this.trfl.Name = "trfl";
            this.trfl.Size = new System.Drawing.Size(61, 69);
            this.trfl.TabIndex = 4;
            this.trfl.UseVisualStyleBackColor = false;
            this.trfl.Click += new System.EventHandler(this.trfl_Click);
            // 
            // CompleteSequencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 1108);
            this.Controls.Add(this.trfl);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblInstruction);
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Name = "CompleteSequencesForm";
            this.Text = "Complete Sequences";
            this.Load += new System.EventHandler(this.CompleteSequencesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button trfl;
    }
}