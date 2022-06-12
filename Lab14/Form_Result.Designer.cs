namespace Lab14
{
    partial class Form_Result
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
            this.label2 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_Perimeter = new System.Windows.Forms.Label();
            this.label_Square = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Периметр треугольника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Площадь трегольника:";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(179, 140);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_Perimeter
            // 
            this.label_Perimeter.AutoSize = true;
            this.label_Perimeter.Location = new System.Drawing.Point(256, 35);
            this.label_Perimeter.Name = "label_Perimeter";
            this.label_Perimeter.Size = new System.Drawing.Size(46, 17);
            this.label_Perimeter.TabIndex = 3;
            this.label_Perimeter.Text = "label3";
            // 
            // label_Square
            // 
            this.label_Square.AutoSize = true;
            this.label_Square.Location = new System.Drawing.Point(259, 85);
            this.label_Square.Name = "label_Square";
            this.label_Square.Size = new System.Drawing.Size(46, 17);
            this.label_Square.TabIndex = 4;
            this.label_Square.Text = "label4";
            // 
            // Form_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 190);
            this.Controls.Add(this.label_Square);
            this.Controls.Add(this.label_Perimeter);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_Perimeter;
        private System.Windows.Forms.Label label_Square;
    }
}