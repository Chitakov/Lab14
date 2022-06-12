namespace Lab14
{
    partial class Form_Input
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
            this.cB_Perimeter = new System.Windows.Forms.CheckBox();
            this.cB_Square = new System.Windows.Forms.CheckBox();
            this.tB_length_1 = new System.Windows.Forms.TextBox();
            this.tB_length_2 = new System.Windows.Forms.TextBox();
            this.tB_length_3 = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cB_Perimeter
            // 
            this.cB_Perimeter.AutoSize = true;
            this.cB_Perimeter.Location = new System.Drawing.Point(90, 122);
            this.cB_Perimeter.Name = "cB_Perimeter";
            this.cB_Perimeter.Size = new System.Drawing.Size(245, 21);
            this.cB_Perimeter.TabIndex = 0;
            this.cB_Perimeter.Text = "Считать периметр треугольника";
            this.cB_Perimeter.UseVisualStyleBackColor = true;
            // 
            // cB_Square
            // 
            this.cB_Square.AutoSize = true;
            this.cB_Square.Location = new System.Drawing.Point(90, 174);
            this.cB_Square.Name = "cB_Square";
            this.cB_Square.Size = new System.Drawing.Size(239, 21);
            this.cB_Square.TabIndex = 1;
            this.cB_Square.Text = "Считать площадь треугольника";
            this.cB_Square.UseVisualStyleBackColor = true;
            // 
            // tB_length_1
            // 
            this.tB_length_1.Location = new System.Drawing.Point(71, 49);
            this.tB_length_1.Name = "tB_length_1";
            this.tB_length_1.Size = new System.Drawing.Size(150, 22);
            this.tB_length_1.TabIndex = 2;
            this.tB_length_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_length_1_KeyPress);
            // 
            // tB_length_2
            // 
            this.tB_length_2.Location = new System.Drawing.Point(319, 49);
            this.tB_length_2.Name = "tB_length_2";
            this.tB_length_2.Size = new System.Drawing.Size(150, 22);
            this.tB_length_2.TabIndex = 3;
            this.tB_length_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_length_2_KeyPress);
            // 
            // tB_length_3
            // 
            this.tB_length_3.Location = new System.Drawing.Point(581, 49);
            this.tB_length_3.Name = "tB_length_3";
            this.tB_length_3.Size = new System.Drawing.Size(150, 22);
            this.tB_length_3.TabIndex = 4;
            this.tB_length_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_length_3_KeyPress);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(319, 228);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 23);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Записать данные";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Длина трегольника 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Длина трегольника 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Длина трегольника 3:";
            // 
            // Form_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.tB_length_3);
            this.Controls.Add(this.tB_length_2);
            this.Controls.Add(this.tB_length_1);
            this.Controls.Add(this.cB_Square);
            this.Controls.Add(this.cB_Perimeter);
            this.Name = "Form_Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cB_Perimeter;
        private System.Windows.Forms.CheckBox cB_Square;
        private System.Windows.Forms.TextBox tB_length_1;
        private System.Windows.Forms.TextBox tB_length_2;
        private System.Windows.Forms.TextBox tB_length_3;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}