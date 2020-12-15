
namespace Rectangle_Area___GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.sideATextBox = new System.Windows.Forms.TextBox();
            this.sideBTextBox = new System.Windows.Forms.TextBox();
            this.AreaOutputLabel = new System.Windows.Forms.Label();
            this.FindAreaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length of Side A";
            // 
            // sideATextBox
            // 
            this.sideATextBox.Location = new System.Drawing.Point(195, 83);
            this.sideATextBox.Name = "sideATextBox";
            this.sideATextBox.Size = new System.Drawing.Size(100, 20);
            this.sideATextBox.TabIndex = 2;
            // 
            // sideBTextBox
            // 
            this.sideBTextBox.Location = new System.Drawing.Point(195, 132);
            this.sideBTextBox.Name = "sideBTextBox";
            this.sideBTextBox.Size = new System.Drawing.Size(100, 20);
            this.sideBTextBox.TabIndex = 3;
            // 
            // AreaOutputLabel
            // 
            this.AreaOutputLabel.AutoSize = true;
            this.AreaOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AreaOutputLabel.Location = new System.Drawing.Point(190, 197);
            this.AreaOutputLabel.Name = "AreaOutputLabel";
            this.AreaOutputLabel.Size = new System.Drawing.Size(129, 25);
            this.AreaOutputLabel.TabIndex = 4;
            this.AreaOutputLabel.Text = "Area Output";
            this.AreaOutputLabel.Visible = false;
            // 
            // FindAreaButton
            // 
            this.FindAreaButton.Location = new System.Drawing.Point(195, 268);
            this.FindAreaButton.Name = "FindAreaButton";
            this.FindAreaButton.Size = new System.Drawing.Size(75, 23);
            this.FindAreaButton.TabIndex = 5;
            this.FindAreaButton.Text = "Find Area";
            this.FindAreaButton.UseVisualStyleBackColor = true;
            this.FindAreaButton.Click += new System.EventHandler(this.FindAreaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Length of Side B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FindAreaButton);
            this.Controls.Add(this.AreaOutputLabel);
            this.Controls.Add(this.sideBTextBox);
            this.Controls.Add(this.sideATextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Find Area of A Rectangle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sideATextBox;
        private System.Windows.Forms.TextBox sideBTextBox;
        private System.Windows.Forms.Label AreaOutputLabel;
        private System.Windows.Forms.Button FindAreaButton;
        private System.Windows.Forms.Label label2;
    }
}

