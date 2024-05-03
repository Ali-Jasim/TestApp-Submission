namespace TestApp
{
    partial class Drug
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            drugName = new Label();
            Counter = new Label();
            Increment = new Button();
            SuspendLayout();
            // 
            // drugName
            // 
            drugName.AutoSize = true;
            drugName.Font = new Font("Segoe UI", 12F);
            drugName.Location = new Point(0, 5);
            drugName.Name = name;
            drugName.Size = new Size(0, 21);
            drugName.TabIndex = 0;
            drugName.Text = name;
            // 
            // Counter
            // 
            Counter.AutoSize = true;
            Counter.Font = new Font("Segoe UI", 12F);
            Counter.Location = new Point(150, 5);
            Counter.Name = "Counter";
            Counter.Size = new Size(0, 21);
            Counter.TabIndex = 1;
            Counter.Text = Count.ToString();
            // 
            // Increment
            // 
            Increment.Location = new Point(200, 3);
            Increment.Name = "Increment";
            Increment.Size = new Size(75, 23);
            Increment.TabIndex = 2;
            Increment.Text = "Increment";
            Increment.UseVisualStyleBackColor = true;
            Increment.Click += IncrementCounter;
            // 
            // Drug
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Increment);
            Controls.Add(Counter);
            Controls.Add(drugName);
            Name = "Drug";
            Size = new Size(300, 34);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

    }
}
