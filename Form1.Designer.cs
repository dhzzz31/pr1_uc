namespace УП
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCombin = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnPermut = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCombin = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblPermut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCombin
            // 
            this.btnCombin.Location = new System.Drawing.Point(16, 12);
            this.btnCombin.Name = "btnCombin";
            this.btnCombin.Size = new System.Drawing.Size(103, 43);
            this.btnCombin.TabIndex = 0;
            this.btnCombin.Text = "Сочетание";
            this.btnCombin.UseVisualStyleBackColor = true;
            this.btnCombin.Click += new System.EventHandler(this.btnCombin_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(172, 12);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(103, 43);
            this.btnPlace.TabIndex = 0;
            this.btnPlace.Text = "Размещение";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnPermut
            // 
            this.btnPermut.Location = new System.Drawing.Point(325, 12);
            this.btnPermut.Name = "btnPermut";
            this.btnPermut.Size = new System.Drawing.Size(103, 43);
            this.btnPermut.TabIndex = 0;
            this.btnPermut.Text = "Перестановка";
            this.btnPermut.UseVisualStyleBackColor = true;
            this.btnPermut.Click += new System.EventHandler(this.btnPermut_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(304, 87);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(84, 20);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(85, 86);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(84, 20);
            this.txtM.TabIndex = 1;
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(284, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "m";
            // 
            // lblCombin
            // 
            this.lblCombin.AutoSize = true;
            this.lblCombin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCombin.Location = new System.Drawing.Point(139, 25);
            this.lblCombin.Name = "lblCombin";
            this.lblCombin.Size = new System.Drawing.Size(0, 24);
            this.lblCombin.TabIndex = 3;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlace.Location = new System.Drawing.Point(281, 25);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(0, 24);
            this.lblPlace.TabIndex = 3;
            // 
            // lblPermut
            // 
            this.lblPermut.AutoSize = true;
            this.lblPermut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPermut.Location = new System.Drawing.Point(434, 25);
            this.lblPermut.Name = "lblPermut";
            this.lblPermut.Size = new System.Drawing.Size(0, 24);
            this.lblPermut.TabIndex = 3;
            this.lblPermut.Click += new System.EventHandler(this.lblPermut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 145);
            this.Controls.Add(this.lblPermut);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblCombin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnPermut);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.btnCombin);
            this.Name = "Form1";
            this.Text = "Элементы комбинаторики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCombin;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnPermut;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCombin;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblPermut;
    }
}

