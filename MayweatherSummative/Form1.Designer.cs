namespace MayweatherSummative
{
    partial class boxingGame
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
            this.questionOutput = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.redOutput = new System.Windows.Forms.Label();
            this.blueOutput = new System.Windows.Forms.Label();
            this.greenOutput = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // questionOutput
            // 
            this.questionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionOutput.Location = new System.Drawing.Point(12, 45);
            this.questionOutput.Name = "questionOutput";
            this.questionOutput.Size = new System.Drawing.Size(784, 204);
            this.questionOutput.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(322, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(177, 25);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Mayweather Game";
            // 
            // redOutput
            // 
            this.redOutput.Location = new System.Drawing.Point(103, 331);
            this.redOutput.Name = "redOutput";
            this.redOutput.Size = new System.Drawing.Size(224, 11);
            this.redOutput.TabIndex = 6;
            // 
            // blueOutput
            // 
            this.blueOutput.Location = new System.Drawing.Point(103, 277);
            this.blueOutput.Name = "blueOutput";
            this.blueOutput.Size = new System.Drawing.Size(224, 11);
            this.blueOutput.TabIndex = 7;
            // 
            // greenOutput
            // 
            this.greenOutput.Location = new System.Drawing.Point(103, 400);
            this.greenOutput.Name = "greenOutput";
            this.greenOutput.Size = new System.Drawing.Size(224, 11);
            this.greenOutput.TabIndex = 8;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Location = new System.Drawing.Point(358, 219);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(438, 219);
            this.imageBox.TabIndex = 9;
            this.imageBox.TabStop = false;
            // 
            // greenLabel
            // 
            this.greenLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenLabel.Image = global::MayweatherSummative.Properties.Resources.green_50x50;
            this.greenLabel.Location = new System.Drawing.Point(29, 375);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(58, 59);
            this.greenLabel.TabIndex = 2;
            // 
            // blueLabel
            // 
            this.blueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueLabel.Image = global::MayweatherSummative.Properties.Resources.blue_50x50;
            this.blueLabel.Location = new System.Drawing.Point(29, 249);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(55, 62);
            this.blueLabel.TabIndex = 1;
            // 
            // redLabel
            // 
            this.redLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redLabel.Image = global::MayweatherSummative.Properties.Resources.red_50x50;
            this.redLabel.Location = new System.Drawing.Point(29, 311);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(55, 61);
            this.redLabel.TabIndex = 0;
            // 
            // boxingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.greenOutput);
            this.Controls.Add(this.blueOutput);
            this.Controls.Add(this.redOutput);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.questionOutput);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Name = "boxingGame";
            this.Text = "Mayweather Summative";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxingGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label questionOutput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label redOutput;
        private System.Windows.Forms.Label blueOutput;
        private System.Windows.Forms.Label greenOutput;
        private System.Windows.Forms.PictureBox imageBox;
    }
}

