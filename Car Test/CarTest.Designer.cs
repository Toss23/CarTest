
namespace Car_Test
{
    partial class CarTest
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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_end = new System.Windows.Forms.Button();
            this.label_iteration = new System.Windows.Forms.Label();
            this.label_step = new System.Windows.Forms.Label();
            this.label_best = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_speed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(13, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(870, 724);
            this.panel.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(892, 12);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(221, 27);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add Sign";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(892, 45);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(221, 27);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Delete Sign";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(889, 87);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(54, 13);
            this.label_info.TabIndex = 3;
            this.label_info.Text = "Позиция:";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(892, 231);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(221, 27);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Start Learn";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(892, 264);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(221, 27);
            this.button_end.TabIndex = 5;
            this.button_end.Text = "End Learn";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // label_iteration
            // 
            this.label_iteration.AutoSize = true;
            this.label_iteration.Location = new System.Drawing.Point(889, 303);
            this.label_iteration.Name = "label_iteration";
            this.label_iteration.Size = new System.Drawing.Size(109, 13);
            this.label_iteration.TabIndex = 6;
            this.label_iteration.Text = "Номер итерации = 0";
            // 
            // label_step
            // 
            this.label_step.AutoSize = true;
            this.label_step.Location = new System.Drawing.Point(889, 331);
            this.label_step.Name = "label_step";
            this.label_step.Size = new System.Drawing.Size(90, 13);
            this.label_step.TabIndex = 7;
            this.label_step.Text = "Текущий ход = 0";
            // 
            // label_best
            // 
            this.label_best.AutoSize = true;
            this.label_best.Location = new System.Drawing.Point(889, 358);
            this.label_best.Name = "label_best";
            this.label_best.Size = new System.Drawing.Size(101, 13);
            this.label_best.TabIndex = 8;
            this.label_best.Text = "Лучший проход = 0";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(892, 452);
            this.trackBar.Maximum = 9;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(221, 45);
            this.trackBar.TabIndex = 9;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Location = new System.Drawing.Point(889, 436);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(102, 13);
            this.label_speed.TabIndex = 10;
            this.label_speed.Text = "Скорость: 1000 мс";
            // 
            // CarTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 748);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label_best);
            this.Controls.Add(this.label_step);
            this.Controls.Add(this.label_iteration);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CarTest";
            this.Text = "CarTest";
            this.Load += new System.EventHandler(this.CarTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Label label_iteration;
        private System.Windows.Forms.Label label_step;
        private System.Windows.Forms.Label label_best;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_speed;
    }
}

