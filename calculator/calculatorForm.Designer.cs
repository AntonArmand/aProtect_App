namespace calculator
{
    partial class calculatorForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.textBoxNumberB = new System.Windows.Forms.TextBox();
            this.textBoxNumberA = new System.Windows.Forms.TextBox();
            this.labelNumberB = new System.Windows.Forms.Label();
            this.labelNumberA = new System.Windows.Forms.Label();
            this.labelMenuTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(122, 209);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(176, 20);
            this.textBoxResult.TabIndex = 24;
            this.textBoxResult.TextChanged += new System.EventHandler(this.TextBoxResult_TextChanged);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(34, 209);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(58, 17);
            this.labelResult.TabIndex = 23;
            this.labelResult.Text = "Result :";
            this.labelResult.Click += new System.EventHandler(this.LabelResult_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Location = new System.Drawing.Point(233, 152);
            this.buttonMultiplication.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(83, 25);
            this.buttonMultiplication.TabIndex = 22;
            this.buttonMultiplication.Text = "Multiplication";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.ButtonMultiplication_Click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Location = new System.Drawing.Point(122, 152);
            this.buttonSubtraction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(83, 25);
            this.buttonSubtraction.TabIndex = 21;
            this.buttonSubtraction.Text = "Subtraction";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            this.buttonSubtraction.Click += new System.EventHandler(this.ButtonSubtraction_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Location = new System.Drawing.Point(15, 152);
            this.buttonAddition.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(83, 25);
            this.buttonAddition.TabIndex = 20;
            this.buttonAddition.Text = "Addition";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.ButtonAddition_Click);
            // 
            // textBoxNumberB
            // 
            this.textBoxNumberB.Location = new System.Drawing.Point(122, 113);
            this.textBoxNumberB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumberB.Name = "textBoxNumberB";
            this.textBoxNumberB.Size = new System.Drawing.Size(176, 20);
            this.textBoxNumberB.TabIndex = 19;
            this.textBoxNumberB.TextChanged += new System.EventHandler(this.TextBoxNumberB_TextChanged);
            // 
            // textBoxNumberA
            // 
            this.textBoxNumberA.Location = new System.Drawing.Point(122, 74);
            this.textBoxNumberA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumberA.Name = "textBoxNumberA";
            this.textBoxNumberA.Size = new System.Drawing.Size(176, 20);
            this.textBoxNumberA.TabIndex = 18;
            this.textBoxNumberA.TextChanged += new System.EventHandler(this.TextBoxNumberA_TextChanged);
            // 
            // labelNumberB
            // 
            this.labelNumberB.AutoSize = true;
            this.labelNumberB.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberB.Location = new System.Drawing.Point(12, 113);
            this.labelNumberB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberB.Name = "labelNumberB";
            this.labelNumberB.Size = new System.Drawing.Size(82, 17);
            this.labelNumberB.TabIndex = 17;
            this.labelNumberB.Text = "Number B :";
            this.labelNumberB.Click += new System.EventHandler(this.LabelNumberB_Click);
            // 
            // labelNumberA
            // 
            this.labelNumberA.AutoSize = true;
            this.labelNumberA.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberA.Location = new System.Drawing.Point(12, 74);
            this.labelNumberA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberA.Name = "labelNumberA";
            this.labelNumberA.Size = new System.Drawing.Size(79, 17);
            this.labelNumberA.TabIndex = 16;
            this.labelNumberA.Text = "Number A :";
            this.labelNumberA.Click += new System.EventHandler(this.LabelNumberA_Click);
            // 
            // labelMenuTitle
            // 
            this.labelMenuTitle.AutoSize = true;
            this.labelMenuTitle.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuTitle.Location = new System.Drawing.Point(118, 12);
            this.labelMenuTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenuTitle.Name = "labelMenuTitle";
            this.labelMenuTitle.Size = new System.Drawing.Size(105, 22);
            this.labelMenuTitle.TabIndex = 15;
            this.labelMenuTitle.Text = "Calculator";
            this.labelMenuTitle.Click += new System.EventHandler(this.LabelMenuTitle_Click);
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 245);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.textBoxNumberB);
            this.Controls.Add(this.textBoxNumberA);
            this.Controls.Add(this.labelNumberB);
            this.Controls.Add(this.labelNumberA);
            this.Controls.Add(this.labelMenuTitle);
            this.Name = "calculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.TextBox textBoxNumberB;
        private System.Windows.Forms.TextBox textBoxNumberA;
        private System.Windows.Forms.Label labelNumberB;
        private System.Windows.Forms.Label labelNumberA;
        private System.Windows.Forms.Label labelMenuTitle;
    }
}

