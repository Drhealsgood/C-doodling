namespace HelloWorldSourceControl
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
            this.buttonGoodbye = new System.Windows.Forms.Button();
            this.labelHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGoodbye
            // 
            this.buttonGoodbye.Location = new System.Drawing.Point(157, 125);
            this.buttonGoodbye.Name = "buttonGoodbye";
            this.buttonGoodbye.Size = new System.Drawing.Size(173, 51);
            this.buttonGoodbye.TabIndex = 0;
            this.buttonGoodbye.Text = "Goodbye";
            this.buttonGoodbye.UseVisualStyleBackColor = true;
            this.buttonGoodbye.Click += new System.EventHandler(this.buttonGoodbye_Click);
            // 
            // labelHelloWorld
            // 
            this.labelHelloWorld.AutoSize = true;
            this.labelHelloWorld.Location = new System.Drawing.Point(154, 91);
            this.labelHelloWorld.Name = "labelHelloWorld";
            this.labelHelloWorld.Size = new System.Drawing.Size(81, 17);
            this.labelHelloWorld.TabIndex = 1;
            this.labelHelloWorld.Text = "Hello World";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.labelHelloWorld);
            this.Controls.Add(this.buttonGoodbye);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoodbye;
        private System.Windows.Forms.Label labelHelloWorld;
    }
}

