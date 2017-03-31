﻿namespace Example02
{
    partial class WeatherStation
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
            this.components = new System.ComponentModel.Container();
            this.tempLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.humidyTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tempLabel.Location = new System.Drawing.Point(9, 18);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(52, 20);
            this.tempLabel.TabIndex = 0;
            this.tempLabel.Text = "Temp";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pressureLabel.Location = new System.Drawing.Point(95, 18);
            this.pressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(73, 20);
            this.pressureLabel.TabIndex = 1;
            this.pressureLabel.Text = "Pressure";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.humidityLabel.Location = new System.Drawing.Point(182, 18);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(78, 20);
            this.humidityLabel.TabIndex = 2;
            this.humidityLabel.Text = "Humidity";
            // 
            // tempTextBox
            // 
            this.tempTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tempTextBox.Location = new System.Drawing.Point(13, 65);
            this.tempTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(76, 29);
            this.tempTextBox.TabIndex = 3;
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pressureTextBox.Location = new System.Drawing.Point(99, 65);
            this.pressureTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(76, 29);
            this.pressureTextBox.TabIndex = 4;
            // 
            // humidyTextBox
            // 
            this.humidyTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.humidyTextBox.Location = new System.Drawing.Point(186, 65);
            this.humidyTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.humidyTextBox.Name = "humidyTextBox";
            this.humidyTextBox.Size = new System.Drawing.Size(76, 29);
            this.humidyTextBox.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(274, 65);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 27);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.messageLabel.Location = new System.Drawing.Point(13, 109);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(370, 77);
            this.messageLabel.TabIndex = 7;
            this.messageLabel.Text = "message";
            // 
            // dataTimer
            // 
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // WeatherStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 193);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.humidyTextBox);
            this.Controls.Add(this.pressureTextBox);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.tempLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WeatherStation";
            this.Text = "WeatherStation";
            this.Load += new System.EventHandler(this.WeatherStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.TextBox humidyTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Timer dataTimer;
    }
}