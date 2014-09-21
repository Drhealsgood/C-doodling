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
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoodbye
            // 
            this.buttonGoodbye.Location = new System.Drawing.Point(30, 258);
            this.buttonGoodbye.Name = "buttonGoodbye";
            this.buttonGoodbye.Size = new System.Drawing.Size(93, 51);
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
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(421, 261);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(86, 48);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.buttonClose);
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
        private System.Windows.Forms.Button buttonClose;
    }
}

