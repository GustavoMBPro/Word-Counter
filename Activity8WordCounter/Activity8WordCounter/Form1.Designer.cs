
namespace Activity8WordCounter
{
    partial class WordCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordCounter));
            this.richTextBoxSentence = new System.Windows.Forms.RichTextBox();
            this.labelWordCounter = new System.Windows.Forms.Label();
            this.labelNumberOfWords = new System.Windows.Forms.Label();
            this.labelAvgNumber = new System.Windows.Forms.Label();
            this.labelSetenceCapitalizer = new System.Windows.Forms.Label();
            this.richTextBoxCapitalizeSentence = new System.Windows.Forms.RichTextBox();
            this.labelDisplayNumberOfWords = new System.Windows.Forms.Label();
            this.labelDisplayAvhNumberOfWords = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxNumberExclusion = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxSentence
            // 
            this.richTextBoxSentence.Location = new System.Drawing.Point(143, 76);
            this.richTextBoxSentence.Name = "richTextBoxSentence";
            this.richTextBoxSentence.Size = new System.Drawing.Size(407, 124);
            this.richTextBoxSentence.TabIndex = 1;
            this.richTextBoxSentence.Text = "";
            // 
            // labelWordCounter
            // 
            this.labelWordCounter.AutoSize = true;
            this.labelWordCounter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelWordCounter.Font = new System.Drawing.Font("Bell MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordCounter.Location = new System.Drawing.Point(165, 9);
            this.labelWordCounter.Name = "labelWordCounter";
            this.labelWordCounter.Size = new System.Drawing.Size(360, 54);
            this.labelWordCounter.TabIndex = 2;
            this.labelWordCounter.Text = "Enter a Sentence";
            // 
            // labelNumberOfWords
            // 
            this.labelNumberOfWords.AutoSize = true;
            this.labelNumberOfWords.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelNumberOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfWords.Location = new System.Drawing.Point(139, 215);
            this.labelNumberOfWords.Name = "labelNumberOfWords";
            this.labelNumberOfWords.Size = new System.Drawing.Size(133, 20);
            this.labelNumberOfWords.TabIndex = 3;
            this.labelNumberOfWords.Text = "Number of words:";
            // 
            // labelAvgNumber
            // 
            this.labelAvgNumber.AutoSize = true;
            this.labelAvgNumber.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelAvgNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgNumber.Location = new System.Drawing.Point(139, 249);
            this.labelAvgNumber.Name = "labelAvgNumber";
            this.labelAvgNumber.Size = new System.Drawing.Size(202, 20);
            this.labelAvgNumber.TabIndex = 4;
            this.labelAvgNumber.Text = "Average number of Letters:";
            // 
            // labelSetenceCapitalizer
            // 
            this.labelSetenceCapitalizer.AutoSize = true;
            this.labelSetenceCapitalizer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelSetenceCapitalizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetenceCapitalizer.Location = new System.Drawing.Point(139, 281);
            this.labelSetenceCapitalizer.Name = "labelSetenceCapitalizer";
            this.labelSetenceCapitalizer.Size = new System.Drawing.Size(161, 20);
            this.labelSetenceCapitalizer.TabIndex = 5;
            this.labelSetenceCapitalizer.Text = "Capitalized sentence:";
            // 
            // richTextBoxCapitalizeSentence
            // 
            this.richTextBoxCapitalizeSentence.Location = new System.Drawing.Point(143, 308);
            this.richTextBoxCapitalizeSentence.Name = "richTextBoxCapitalizeSentence";
            this.richTextBoxCapitalizeSentence.ReadOnly = true;
            this.richTextBoxCapitalizeSentence.Size = new System.Drawing.Size(407, 124);
            this.richTextBoxCapitalizeSentence.TabIndex = 6;
            this.richTextBoxCapitalizeSentence.Text = "";
            // 
            // labelDisplayNumberOfWords
            // 
            this.labelDisplayNumberOfWords.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDisplayNumberOfWords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayNumberOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayNumberOfWords.Location = new System.Drawing.Point(289, 214);
            this.labelDisplayNumberOfWords.Name = "labelDisplayNumberOfWords";
            this.labelDisplayNumberOfWords.Size = new System.Drawing.Size(133, 20);
            this.labelDisplayNumberOfWords.TabIndex = 7;
            // 
            // labelDisplayAvhNumberOfWords
            // 
            this.labelDisplayAvhNumberOfWords.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDisplayAvhNumberOfWords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayAvhNumberOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayAvhNumberOfWords.Location = new System.Drawing.Point(358, 249);
            this.labelDisplayAvhNumberOfWords.Name = "labelDisplayAvhNumberOfWords";
            this.labelDisplayAvhNumberOfWords.Size = new System.Drawing.Size(133, 20);
            this.labelDisplayAvhNumberOfWords.TabIndex = 8;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(27, 393);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(92, 33);
            this.buttonEnter.TabIndex = 9;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(578, 393);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 33);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // checkBoxNumberExclusion
            // 
            this.checkBoxNumberExclusion.AutoSize = true;
            this.checkBoxNumberExclusion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBoxNumberExclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNumberExclusion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxNumberExclusion.Location = new System.Drawing.Point(439, 214);
            this.checkBoxNumberExclusion.Name = "checkBoxNumberExclusion";
            this.checkBoxNumberExclusion.Size = new System.Drawing.Size(190, 24);
            this.checkBoxNumberExclusion.TabIndex = 11;
            this.checkBoxNumberExclusion.Text = "Do not count numbers.";
            this.checkBoxNumberExclusion.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(27, 354);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(92, 33);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // WordCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 444);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxNumberExclusion);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelDisplayAvhNumberOfWords);
            this.Controls.Add(this.labelDisplayNumberOfWords);
            this.Controls.Add(this.richTextBoxCapitalizeSentence);
            this.Controls.Add(this.labelSetenceCapitalizer);
            this.Controls.Add(this.labelAvgNumber);
            this.Controls.Add(this.labelNumberOfWords);
            this.Controls.Add(this.labelWordCounter);
            this.Controls.Add(this.richTextBoxSentence);
            this.Name = "WordCounter";
            this.Text = "Word Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSentence;
        private System.Windows.Forms.Label labelWordCounter;
        private System.Windows.Forms.Label labelNumberOfWords;
        private System.Windows.Forms.Label labelAvgNumber;
        private System.Windows.Forms.Label labelSetenceCapitalizer;
        private System.Windows.Forms.RichTextBox richTextBoxCapitalizeSentence;
        private System.Windows.Forms.Label labelDisplayNumberOfWords;
        private System.Windows.Forms.Label labelDisplayAvhNumberOfWords;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox checkBoxNumberExclusion;
        private System.Windows.Forms.Button buttonClear;
    }
}

