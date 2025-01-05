namespace genetics_algorithm
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
            this.textBox_population = new System.Windows.Forms.TextBox();
            this.textBox_crossover = new System.Windows.Forms.TextBox();
            this.textBox_mutation = new System.Windows.Forms.TextBox();
            this.textBox_elite = new System.Windows.Forms.TextBox();
            this.textBox_generation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_chromosome = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_population
            // 
            this.textBox_population.Location = new System.Drawing.Point(172, 12);
            this.textBox_population.Name = "textBox_population";
            this.textBox_population.Size = new System.Drawing.Size(100, 22);
            this.textBox_population.TabIndex = 0;
            this.textBox_population.Text = "100";
            // 
            // textBox_crossover
            // 
            this.textBox_crossover.Location = new System.Drawing.Point(172, 40);
            this.textBox_crossover.Name = "textBox_crossover";
            this.textBox_crossover.Size = new System.Drawing.Size(100, 22);
            this.textBox_crossover.TabIndex = 1;
            this.textBox_crossover.Text = "0.5";
            // 
            // textBox_mutation
            // 
            this.textBox_mutation.Location = new System.Drawing.Point(172, 68);
            this.textBox_mutation.Name = "textBox_mutation";
            this.textBox_mutation.Size = new System.Drawing.Size(100, 22);
            this.textBox_mutation.TabIndex = 2;
            this.textBox_mutation.Text = "0.20";
            // 
            // textBox_elite
            // 
            this.textBox_elite.Location = new System.Drawing.Point(172, 96);
            this.textBox_elite.Name = "textBox_elite";
            this.textBox_elite.Size = new System.Drawing.Size(100, 22);
            this.textBox_elite.TabIndex = 3;
            this.textBox_elite.Text = "5";
            // 
            // textBox_generation
            // 
            this.textBox_generation.Location = new System.Drawing.Point(172, 124);
            this.textBox_generation.Name = "textBox_generation";
            this.textBox_generation.Size = new System.Drawing.Size(100, 22);
            this.textBox_generation.TabIndex = 4;
            this.textBox_generation.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Popülasyon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Çaprazlama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mutasyon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seçkinlik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jenerasyon";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(145, 199);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 10;
            this.button_start.Text = "Çözümle";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(367, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 439);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = global::genetics_algorithm.Properties.Resources.function;
            this.pictureBox1.Location = new System.Drawing.Point(432, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fonksiyon = ";
            // 
            // textBox_chromosome
            // 
            this.textBox_chromosome.Location = new System.Drawing.Point(172, 152);
            this.textBox_chromosome.Name = "textBox_chromosome";
            this.textBox_chromosome.Size = new System.Drawing.Size(100, 22);
            this.textBox_chromosome.TabIndex = 15;
            this.textBox_chromosome.Text = "10";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 239);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 356);
            this.listBox1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kromozom Uzunluğu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 615);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_chromosome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_generation);
            this.Controls.Add(this.textBox_elite);
            this.Controls.Add(this.textBox_mutation);
            this.Controls.Add(this.textBox_crossover);
            this.Controls.Add(this.textBox_population);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_population;
        private System.Windows.Forms.TextBox textBox_crossover;
        private System.Windows.Forms.TextBox textBox_mutation;
        private System.Windows.Forms.TextBox textBox_elite;
        private System.Windows.Forms.TextBox textBox_generation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_chromosome;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
    }
}

