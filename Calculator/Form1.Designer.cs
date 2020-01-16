namespace Calculator
{
    partial class calculatorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculatorForm));
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.processOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.calculationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.substractionButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.operationGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.codedPictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.inputGroupBox.SuspendLayout();
            this.processOutputGroupBox.SuspendLayout();
            this.operationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.inputGroupBox.Controls.Add(this.textBox1);
            this.inputGroupBox.Controls.Add(this.textBox2);
            this.inputGroupBox.Controls.Add(this.label2);
            this.inputGroupBox.Controls.Add(this.label1);
            this.inputGroupBox.Location = new System.Drawing.Point(43, 150);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(352, 296);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number";
            // 
            // processOutputGroupBox
            // 
            this.processOutputGroupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.processOutputGroupBox.Controls.Add(this.calculationLabel);
            this.processOutputGroupBox.Controls.Add(this.label6);
            this.processOutputGroupBox.Controls.Add(this.label5);
            this.processOutputGroupBox.Controls.Add(this.label4);
            this.processOutputGroupBox.Controls.Add(this.label3);
            this.processOutputGroupBox.Controls.Add(this.substractionButton);
            this.processOutputGroupBox.Controls.Add(this.divisionButton);
            this.processOutputGroupBox.Controls.Add(this.additionButton);
            this.processOutputGroupBox.Controls.Add(this.multiplicationButton);
            this.processOutputGroupBox.Location = new System.Drawing.Point(439, 150);
            this.processOutputGroupBox.Name = "processOutputGroupBox";
            this.processOutputGroupBox.Size = new System.Drawing.Size(352, 296);
            this.processOutputGroupBox.TabIndex = 1;
            this.processOutputGroupBox.TabStop = false;
            this.processOutputGroupBox.Text = "Process Output";
            // 
            // calculationLabel
            // 
            this.calculationLabel.AutoSize = true;
            this.calculationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationLabel.Location = new System.Drawing.Point(197, 123);
            this.calculationLabel.Name = "calculationLabel";
            this.calculationLabel.Size = new System.Drawing.Size(0, 46);
            this.calculationLabel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 46);
            this.label6.TabIndex = 7;
            this.label6.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 46);
            this.label5.TabIndex = 6;
            this.label5.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            // 
            // substractionButton
            // 
            this.substractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substractionButton.Location = new System.Drawing.Point(19, 220);
            this.substractionButton.Name = "substractionButton";
            this.substractionButton.Size = new System.Drawing.Size(59, 45);
            this.substractionButton.TabIndex = 3;
            this.substractionButton.Text = "-";
            this.myToolTip.SetToolTip(this.substractionButton, "Substraction sign");
            this.substractionButton.UseVisualStyleBackColor = true;
            this.substractionButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(19, 161);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(59, 45);
            this.divisionButton.TabIndex = 2;
            this.divisionButton.Text = "/";
            this.myToolTip.SetToolTip(this.divisionButton, "Division sign");
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // additionButton
            // 
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionButton.Location = new System.Drawing.Point(19, 102);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(59, 45);
            this.additionButton.TabIndex = 1;
            this.additionButton.Text = "+";
            this.myToolTip.SetToolTip(this.additionButton, "Addition sign");
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.Location = new System.Drawing.Point(19, 43);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(59, 45);
            this.multiplicationButton.TabIndex = 0;
            this.multiplicationButton.Text = "X";
            this.myToolTip.SetToolTip(this.multiplicationButton, "Multiplication sign");
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // operationGroupBox
            // 
            this.operationGroupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.operationGroupBox.Controls.Add(this.exitButton);
            this.operationGroupBox.Controls.Add(this.clearButton);
            this.operationGroupBox.Location = new System.Drawing.Point(43, 471);
            this.operationGroupBox.Name = "operationGroupBox";
            this.operationGroupBox.Size = new System.Drawing.Size(748, 100);
            this.operationGroupBox.TabIndex = 8;
            this.operationGroupBox.TabStop = false;
            this.operationGroupBox.Text = "Operation";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(527, 43);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 28);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Exit";
            this.myToolTip.SetToolTip(this.exitButton, "Exits the program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(18, 34);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 32);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "&Clear";
            this.myToolTip.SetToolTip(this.clearButton, "Clears all the content");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // codedPictureBox
            // 
            this.codedPictureBox.Location = new System.Drawing.Point(43, 62);
            this.codedPictureBox.Name = "codedPictureBox";
            this.codedPictureBox.Size = new System.Drawing.Size(85, 82);
            this.codedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codedPictureBox.TabIndex = 8;
            this.codedPictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(164, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "My calculator";
            // 
            // calculatorForm
            // 
            this.AcceptButton = this.multiplicationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(864, 593);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.codedPictureBox);
            this.Controls.Add(this.operationGroupBox);
            this.Controls.Add(this.processOutputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculatorForm";
            this.Text = "Calculator";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.processOutputGroupBox.ResumeLayout(false);
            this.processOutputGroupBox.PerformLayout();
            this.operationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox processOutputGroupBox;
        private System.Windows.Forms.Button substractionButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Label calculationLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox operationGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox codedPictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Button exitButton;
    }
}

