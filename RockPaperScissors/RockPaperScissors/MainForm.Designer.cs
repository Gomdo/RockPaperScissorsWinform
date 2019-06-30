namespace RockPaperScissors
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.Label();
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.scissors = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.comSelect = new System.Windows.Forms.Label();
            this.comText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(551, 102);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(42, 15);
            this.result.TabIndex = 0;
            this.result.Text = "result";
            // 
            // rock
            // 
            this.rock.Location = new System.Drawing.Point(136, 246);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(75, 23);
            this.rock.TabIndex = 1;
            this.rock.Text = "Rock";
            this.rock.UseVisualStyleBackColor = true;
            // 
            // paper
            // 
            this.paper.Location = new System.Drawing.Point(340, 246);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(75, 23);
            this.paper.TabIndex = 2;
            this.paper.Text = "Paper";
            this.paper.UseVisualStyleBackColor = true;
            // 
            // scissors
            // 
            this.scissors.Location = new System.Drawing.Point(543, 246);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(75, 23);
            this.scissors.TabIndex = 3;
            this.scissors.Text = "Scissors";
            this.scissors.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(340, 338);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // comSelect
            // 
            this.comSelect.AutoSize = true;
            this.comSelect.Location = new System.Drawing.Point(349, 102);
            this.comSelect.Name = "comSelect";
            this.comSelect.Size = new System.Drawing.Size(78, 15);
            this.comSelect.TabIndex = 6;
            this.comSelect.Text = "ComSelect";
            // 
            // comText
            // 
            this.comText.AutoSize = true;
            this.comText.Location = new System.Drawing.Point(153, 102);
            this.comText.Name = "comText";
            this.comText.Size = new System.Drawing.Size(37, 15);
            this.comText.TabIndex = 7;
            this.comText.Text = "Com";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comText);
            this.Controls.Add(this.comSelect);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.result);
            this.Name = "MainForm";
            this.Text = "RockPaperScissors";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label comSelect;
        private System.Windows.Forms.Label comText;
    }
}

