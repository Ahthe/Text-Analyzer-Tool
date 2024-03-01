namespace TextAnalyzerTool
{
    partial class frmMain
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnNumberOfCharacters = new System.Windows.Forms.Button();
            this.btnNumberOfWords = new System.Windows.Forms.Button();
            this.btnFileNameAndExtension = new System.Windows.Forms.Button();
            this.btnWhatever = new System.Windows.Forms.Button();
            this.btnDownshift = new System.Windows.Forms.Button();
            this.btnUpshift = new System.Windows.Forms.Button();
            this.btnLastCharacter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 49);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(554, 22);
            this.txtInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 111);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(554, 153);
            this.txtOutput.TabIndex = 3;
            // 
            // btnNumberOfCharacters
            // 
            this.btnNumberOfCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberOfCharacters.Location = new System.Drawing.Point(19, 281);
            this.btnNumberOfCharacters.Name = "btnNumberOfCharacters";
            this.btnNumberOfCharacters.Size = new System.Drawing.Size(204, 42);
            this.btnNumberOfCharacters.TabIndex = 4;
            this.btnNumberOfCharacters.Text = "Number of Characters";
            this.btnNumberOfCharacters.UseVisualStyleBackColor = true;
            this.btnNumberOfCharacters.Click += new System.EventHandler(this.btnNumberOfCharacters_Click);
            // 
            // btnNumberOfWords
            // 
            this.btnNumberOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberOfWords.Location = new System.Drawing.Point(19, 344);
            this.btnNumberOfWords.Name = "btnNumberOfWords";
            this.btnNumberOfWords.Size = new System.Drawing.Size(204, 38);
            this.btnNumberOfWords.TabIndex = 5;
            this.btnNumberOfWords.Text = "Number of Words";
            this.btnNumberOfWords.UseVisualStyleBackColor = true;
            this.btnNumberOfWords.Click += new System.EventHandler(this.btnNumberOfWords_Click);
            // 
            // btnFileNameAndExtension
            // 
            this.btnFileNameAndExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileNameAndExtension.Location = new System.Drawing.Point(19, 405);
            this.btnFileNameAndExtension.Name = "btnFileNameAndExtension";
            this.btnFileNameAndExtension.Size = new System.Drawing.Size(204, 45);
            this.btnFileNameAndExtension.TabIndex = 6;
            this.btnFileNameAndExtension.Text = "File Name and Extension";
            this.btnFileNameAndExtension.UseVisualStyleBackColor = true;
            this.btnFileNameAndExtension.Click += new System.EventHandler(this.btnFileNameAndExtension_Click);
            // 
            // btnWhatever
            // 
            this.btnWhatever.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhatever.Location = new System.Drawing.Point(19, 470);
            this.btnWhatever.Name = "btnWhatever";
            this.btnWhatever.Size = new System.Drawing.Size(204, 40);
            this.btnWhatever.TabIndex = 7;
            this.btnWhatever.Text = "Whatever";
            this.btnWhatever.UseVisualStyleBackColor = true;
            this.btnWhatever.Click += new System.EventHandler(this.btnWhatever_Click);
            // 
            // btnDownshift
            // 
            this.btnDownshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownshift.Location = new System.Drawing.Point(378, 281);
            this.btnDownshift.Name = "btnDownshift";
            this.btnDownshift.Size = new System.Drawing.Size(188, 42);
            this.btnDownshift.TabIndex = 8;
            this.btnDownshift.Text = "Downshift";
            this.btnDownshift.UseVisualStyleBackColor = true;
            this.btnDownshift.Click += new System.EventHandler(this.btnDownshift_Click);
            // 
            // btnUpshift
            // 
            this.btnUpshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpshift.Location = new System.Drawing.Point(378, 345);
            this.btnUpshift.Name = "btnUpshift";
            this.btnUpshift.Size = new System.Drawing.Size(188, 38);
            this.btnUpshift.TabIndex = 9;
            this.btnUpshift.Text = "Upshift";
            this.btnUpshift.UseVisualStyleBackColor = true;
            this.btnUpshift.Click += new System.EventHandler(this.btnUpshift_Click);
            // 
            // btnLastCharacter
            // 
            this.btnLastCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastCharacter.Location = new System.Drawing.Point(378, 405);
            this.btnLastCharacter.Name = "btnLastCharacter";
            this.btnLastCharacter.Size = new System.Drawing.Size(188, 44);
            this.btnLastCharacter.TabIndex = 10;
            this.btnLastCharacter.Text = "Last Character";
            this.btnLastCharacter.UseVisualStyleBackColor = true;
            this.btnLastCharacter.Click += new System.EventHandler(this.btnLastCharacter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(378, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 40);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 535);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLastCharacter);
            this.Controls.Add(this.btnUpshift);
            this.Controls.Add(this.btnDownshift);
            this.Controls.Add(this.btnWhatever);
            this.Controls.Add(this.btnFileNameAndExtension);
            this.Controls.Add(this.btnNumberOfWords);
            this.Controls.Add(this.btnNumberOfCharacters);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "String Experiments ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnNumberOfCharacters;
        private System.Windows.Forms.Button btnNumberOfWords;
        private System.Windows.Forms.Button btnFileNameAndExtension;
        private System.Windows.Forms.Button btnWhatever;
        private System.Windows.Forms.Button btnDownshift;
        private System.Windows.Forms.Button btnUpshift;
        private System.Windows.Forms.Button btnLastCharacter;
        private System.Windows.Forms.Button btnExit;
    }
}

