using System;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        // The variables for questions and answer (store in arrays)
        private string[] questions = {
            "Kysymus 1: Mik‰ on Suomen p‰‰kaupunki?",
            "Kysymus 2: Montako kuukautta on vuodessa?",
            "Kysymus 3: Mik‰ on maailman suurin valtameri?",
            "Kysymus 4: Mik‰ el‰in on suomen kansallisel‰in?",
            "Kysymus 5: Mik‰ on 5 + 7?",
            "Kysymus 6: Kuka on suomen presidentti vuonna 2024?",
            "Kysymus 7: Mik‰ on maailman korkein vuori?",
            "Kysymus 8: Montako jalkaa h‰m‰h‰kill‰ on?",
            "Kysymus 9: Mink‰ v‰rinen on taivas kirkkaana p‰iv‰n‰?",
            "Kysymus10: Mit‰ kielt‰ puhutaan Espanjassa?"
        };
        private char[] correctAnswers = { 'C', 'B', 'A', 'D', 'B', 'C', 'A', 'D', 'C', 'B' };
        private char[] userAnswers = new char[10];

        private int currentQuestion = 0;
        private int correctCount = 0;
        public Form1()
        {
            // Constructor (Runs When Form Opens)
            InitializeComponent();
            LoadQuestion();
            // Attach an event handler to all the answer buttons
            rbA.CheckedChanged += RadioButton_CheckedChanged;
            rbB.CheckedChanged += RadioButton_CheckedChanged;
            rbC.CheckedChanged += RadioButton_CheckedChanged;
            rbD.CheckedChanged += RadioButton_CheckedChanged;
        }
        private void LoadQuestion()
        {
            if (currentQuestion < 10)
            {
                QuestionLB.Text = questions[currentQuestion];
                // Reset radio button selections so they appear unchecked
                rbA.Checked = false;
                rbB.Checked = false;
                rbC.Checked = false;
                rbD.Checked = false;

                switch (currentQuestion)
                {
                    case 0:
                        rbA.Text = "A) Tampere";
                        rbB.Text = "B) Turku";
                        rbC.Text = "C) Helsinki";
                        rbD.Text = "D) Oulu";
                        break;
                    case 1:
                        rbA.Text = "A) 10";
                        rbB.Text = "B) 12";
                        rbC.Text = "C) 14";
                        rbD.Text = "D) 11";
                        break;
                    case 2:
                        rbA.Text = "A) Tyynimeri";
                        rbB.Text = "B) Atlantti";
                        rbC.Text = "C) Intian valtameri";
                        rbD.Text = "D) J‰‰meri";
                        break;
                    case 3:
                        rbA.Text = "A) Karhu";
                        rbB.Text = "B) Ilves";
                        rbC.Text = "C) Susi";
                        rbD.Text = "D) Hirvi";
                        break;
                    case 4:
                        rbA.Text = "A) 10";
                        rbB.Text = "B) 12";
                        rbC.Text = "C) 15";
                        rbD.Text = "D) 17";
                        break;
                    case 5:
                        rbA.Text = "A) Sauli Niinistˆ";
                        rbB.Text = "B) Alexander Stubb";
                        rbC.Text = "C) Pekka Haavisto";
                        rbD.Text = "D) Sanna Marin";
                        break;
                    case 6:
                        rbA.Text = "A) Mount Everest";
                        rbB.Text = "B) K2";
                        rbC.Text = "C) Kilimanjaro";
                        rbD.Text = "D) Mont Blanc";
                        break;
                    case 7:
                        rbA.Text = "A) 6";
                        rbB.Text = "B) 8";
                        rbC.Text = "C) 10";
                        rbD.Text = "D) 12";
                        break;
                    case 8:
                        rbA.Text = "A) Punainen";
                        rbB.Text = "B) Keltainen";
                        rbC.Text = "C) Sininen";
                        rbD.Text = "D) Vihre‰";
                        break;
                    case 9:
                        rbA.Text = "A) Englanti";
                        rbB.Text = "B) Espanja";
                        rbC.Text = "C) Ranska";
                        rbD.Text = "D) Italia";
                        break;
                }
            }
            else
            {
                rbA.Enabled = rbB.Enabled = rbC.Enabled = rbD.Enabled = false;
                NextBT.Enabled = false;

                correctCount = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (userAnswers[i] == correctAnswers[i])
                        correctCount++;
                }

                ResultLB.Text = $"Sait {correctCount}/10 oikein!";
            }
        }


        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbA.Checked) userAnswers[currentQuestion] = 'A';
            if (rbB.Checked) userAnswers[currentQuestion] = 'B';
            if (rbC.Checked) userAnswers[currentQuestion] = 'C';
            if (rbD.Checked) userAnswers[currentQuestion] = 'D';
        }

        private void NextBT_Click(object sender, EventArgs e)
        {
            currentQuestion++;
            LoadQuestion();
        }
    }
}
