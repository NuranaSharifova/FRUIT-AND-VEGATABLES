
namespace HM1.ADO.NET
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
            this.button1 = new System.Windows.Forms.Button();
            this.conbox = new System.Windows.Forms.TextBox();
            this.allbn = new System.Windows.Forms.Button();
            this.namebn = new System.Windows.Forms.Button();
            this.Colourbn = new System.Windows.Forms.Button();
            this.maxclbn = new System.Windows.Forms.Button();
            this.minclbn = new System.Windows.Forms.Button();
            this.avgclbn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.countvbn = new System.Windows.Forms.Button();
            this.countfbn = new System.Windows.Forms.Button();
            this.chosebn = new System.Windows.Forms.Button();
            this.chooseclbn = new System.Windows.Forms.TextBox();
            this.minbn = new System.Windows.Forms.Button();
            this.minbox = new System.Windows.Forms.TextBox();
            this.maxbn = new System.Windows.Forms.Button();
            this.betweenbn = new System.Windows.Forms.Button();
            this.redbn = new System.Windows.Forms.Button();
            this.maxbox = new System.Windows.Forms.TextBox();
            this.mind = new System.Windows.Forms.TextBox();
            this.maxd = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupbn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connection State";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // conbox
            // 
            this.conbox.Location = new System.Drawing.Point(163, 14);
            this.conbox.Name = "conbox";
            this.conbox.Size = new System.Drawing.Size(132, 20);
            this.conbox.TabIndex = 1;
            // 
            // allbn
            // 
            this.allbn.Location = new System.Drawing.Point(13, 42);
            this.allbn.Name = "allbn";
            this.allbn.Size = new System.Drawing.Size(93, 23);
            this.allbn.TabIndex = 2;
            this.allbn.Text = "All Information";
            this.allbn.UseVisualStyleBackColor = true;
            this.allbn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // namebn
            // 
            this.namebn.Location = new System.Drawing.Point(112, 42);
            this.namebn.Name = "namebn";
            this.namebn.Size = new System.Drawing.Size(72, 23);
            this.namebn.TabIndex = 3;
            this.namebn.Text = "Names";
            this.namebn.UseVisualStyleBackColor = true;
            this.namebn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // Colourbn
            // 
            this.Colourbn.Location = new System.Drawing.Point(190, 42);
            this.Colourbn.Name = "Colourbn";
            this.Colourbn.Size = new System.Drawing.Size(66, 23);
            this.Colourbn.TabIndex = 4;
            this.Colourbn.Text = "Colours";
            this.Colourbn.UseVisualStyleBackColor = true;
            this.Colourbn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // maxclbn
            // 
            this.maxclbn.Location = new System.Drawing.Point(262, 42);
            this.maxclbn.Name = "maxclbn";
            this.maxclbn.Size = new System.Drawing.Size(83, 23);
            this.maxclbn.TabIndex = 5;
            this.maxclbn.Text = "Max Calory";
            this.maxclbn.UseVisualStyleBackColor = true;
            this.maxclbn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // minclbn
            // 
            this.minclbn.Location = new System.Drawing.Point(351, 42);
            this.minclbn.Name = "minclbn";
            this.minclbn.Size = new System.Drawing.Size(74, 23);
            this.minclbn.TabIndex = 6;
            this.minclbn.Text = "Min Calory";
            this.minclbn.UseVisualStyleBackColor = true;
            this.minclbn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // avgclbn
            // 
            this.avgclbn.Location = new System.Drawing.Point(431, 42);
            this.avgclbn.Name = "avgclbn";
            this.avgclbn.Size = new System.Drawing.Size(96, 23);
            this.avgclbn.TabIndex = 7;
            this.avgclbn.Text = "Average Calory";
            this.avgclbn.UseVisualStyleBackColor = true;
            this.avgclbn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 150);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(767, 251);
            this.dataGrid.TabIndex = 8;
            // 
            // countvbn
            // 
            this.countvbn.Location = new System.Drawing.Point(533, 42);
            this.countvbn.Name = "countvbn";
            this.countvbn.Size = new System.Drawing.Size(116, 23);
            this.countvbn.TabIndex = 9;
            this.countvbn.Text = "Count of Vegetables";
            this.countvbn.UseVisualStyleBackColor = true;
            this.countvbn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // countfbn
            // 
            this.countfbn.Location = new System.Drawing.Point(655, 42);
            this.countfbn.Name = "countfbn";
            this.countfbn.Size = new System.Drawing.Size(124, 23);
            this.countfbn.TabIndex = 10;
            this.countfbn.Text = "Count of fruits";
            this.countfbn.UseVisualStyleBackColor = true;
            this.countfbn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // chosebn
            // 
            this.chosebn.Location = new System.Drawing.Point(13, 72);
            this.chosebn.Name = "chosebn";
            this.chosebn.Size = new System.Drawing.Size(93, 23);
            this.chosebn.TabIndex = 11;
            this.chosebn.Text = "Choose Colour";
            this.chosebn.UseVisualStyleBackColor = true;
            this.chosebn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // chooseclbn
            // 
            this.chooseclbn.Location = new System.Drawing.Point(112, 74);
            this.chooseclbn.Name = "chooseclbn";
            this.chooseclbn.Size = new System.Drawing.Size(113, 20);
            this.chooseclbn.TabIndex = 12;
            // 
            // minbn
            // 
            this.minbn.Location = new System.Drawing.Point(13, 102);
            this.minbn.Name = "minbn";
            this.minbn.Size = new System.Drawing.Size(93, 23);
            this.minbn.TabIndex = 13;
            this.minbn.Text = "Set Calory (Min)";
            this.minbn.UseVisualStyleBackColor = true;
            this.minbn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // minbox
            // 
            this.minbox.Location = new System.Drawing.Point(113, 104);
            this.minbox.Name = "minbox";
            this.minbox.Size = new System.Drawing.Size(112, 20);
            this.minbox.TabIndex = 14;
            // 
            // maxbn
            // 
            this.maxbn.Location = new System.Drawing.Point(243, 72);
            this.maxbn.Name = "maxbn";
            this.maxbn.Size = new System.Drawing.Size(102, 23);
            this.maxbn.TabIndex = 15;
            this.maxbn.Text = "Set Calory (Max)";
            this.maxbn.UseVisualStyleBackColor = true;
            this.maxbn.MouseCaptureChanged += new System.EventHandler(this.allbn_Click);
            // 
            // betweenbn
            // 
            this.betweenbn.Location = new System.Drawing.Point(243, 100);
            this.betweenbn.Name = "betweenbn";
            this.betweenbn.Size = new System.Drawing.Size(102, 23);
            this.betweenbn.TabIndex = 16;
            this.betweenbn.Text = "Between";
            this.betweenbn.UseVisualStyleBackColor = true;
            this.betweenbn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // redbn
            // 
            this.redbn.Location = new System.Drawing.Point(655, 74);
            this.redbn.Name = "redbn";
            this.redbn.Size = new System.Drawing.Size(124, 23);
            this.redbn.TabIndex = 17;
            this.redbn.Text = "Red and Yellow";
            this.redbn.UseVisualStyleBackColor = true;
            this.redbn.Click += new System.EventHandler(this.allbn_Click);
            // 
            // maxbox
            // 
            this.maxbox.Location = new System.Drawing.Point(368, 74);
            this.maxbox.Name = "maxbox";
            this.maxbox.Size = new System.Drawing.Size(159, 20);
            this.maxbox.TabIndex = 18;
            // 
            // mind
            // 
            this.mind.Location = new System.Drawing.Point(368, 104);
            this.mind.Name = "mind";
            this.mind.Size = new System.Drawing.Size(46, 20);
            this.mind.TabIndex = 19;
            // 
            // maxd
            // 
            this.maxd.Location = new System.Drawing.Point(479, 105);
            this.maxd.Name = "maxd";
            this.maxd.Size = new System.Drawing.Size(46, 20);
            this.maxd.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "and";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupbn
            // 
            this.groupbn.Location = new System.Drawing.Point(533, 74);
            this.groupbn.Name = "groupbn";
            this.groupbn.Size = new System.Drawing.Size(116, 23);
            this.groupbn.TabIndex = 22;
            this.groupbn.Text = "Group By Colour";
            this.groupbn.UseVisualStyleBackColor = true;
            this.groupbn.MouseCaptureChanged += new System.EventHandler(this.allbn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.groupbn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.maxd);
            this.Controls.Add(this.mind);
            this.Controls.Add(this.maxbox);
            this.Controls.Add(this.redbn);
            this.Controls.Add(this.betweenbn);
            this.Controls.Add(this.maxbn);
            this.Controls.Add(this.minbox);
            this.Controls.Add(this.minbn);
            this.Controls.Add(this.chooseclbn);
            this.Controls.Add(this.chosebn);
            this.Controls.Add(this.countfbn);
            this.Controls.Add(this.countvbn);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.avgclbn);
            this.Controls.Add(this.minclbn);
            this.Controls.Add(this.maxclbn);
            this.Controls.Add(this.Colourbn);
            this.Controls.Add(this.namebn);
            this.Controls.Add(this.allbn);
            this.Controls.Add(this.conbox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox conbox;
        private System.Windows.Forms.Button allbn;
        private System.Windows.Forms.Button namebn;
        private System.Windows.Forms.Button Colourbn;
        private System.Windows.Forms.Button maxclbn;
        private System.Windows.Forms.Button minclbn;
        private System.Windows.Forms.Button avgclbn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button countvbn;
        private System.Windows.Forms.Button countfbn;
        private System.Windows.Forms.Button chosebn;
        private System.Windows.Forms.TextBox chooseclbn;
        private System.Windows.Forms.Button minbn;
        private System.Windows.Forms.TextBox minbox;
        private System.Windows.Forms.Button maxbn;
        private System.Windows.Forms.Button betweenbn;
        private System.Windows.Forms.Button redbn;
        private System.Windows.Forms.TextBox maxbox;
        private System.Windows.Forms.TextBox mind;
        private System.Windows.Forms.TextBox maxd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button groupbn;
    }
}

