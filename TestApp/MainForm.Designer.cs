


namespace TestApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Reset = new Button();
            displayLog = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // Reset
            // 
            Reset.Location = new Point(13, 167);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 0;
            Reset.Text = "Reset All";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += ResetDrugCount;
            // 
            // displayLog
            // 
            displayLog.Location = new Point(94, 167);
            displayLog.Name = "displayLog";
            displayLog.Size = new Size(89, 23);
            displayLog.TabIndex = 1;
            displayLog.Text = "Display Log";
            displayLog.UseVisualStyleBackColor = true;
            displayLog.Click += DisplayLog;
            // 
            // Exit
            // 
            Exit.Location = new Point(189, 167);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += ExitClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 235);
            Controls.Add(Exit);
            Controls.Add(displayLog);
            Controls.Add(Reset);
            Name = "MainForm";
            Text = "Drugs";
            ResumeLayout(false);
        }


        #endregion
    }
}
