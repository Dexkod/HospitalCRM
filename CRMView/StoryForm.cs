using Hospital;
using HospitalCRM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMView
{
    public partial class StoryForm : Form
    {
        private Person people;
        private List<Medication> medications;
        private List<NumericUpDown> numericUpDowns = new();
        private List<Label> infoLabels = new();
        private List<Button> addButtons = new();
        private List<Button> moreDetailsButtons = new();
        private int countNext = 0;
        private Button previousMedicationButton;
        private Dictionary<Medication, int> payMedications = new();
        public StoryForm(Person people, List<Medication> medications)
        {
            this.medications = medications;
            AddChequeMedication();
            this.people = people;
            InitializeComponent();
            CreateViewMedications();
            countNext = medications.Count > 3 ? 3 : medications.Count; 
            AddControls(0,countNext);
        }

        private void AddChequeMedication()
        {
            //var cheque = 
            //foreach(var item in medications)
            //{
            //    item.Cheque = new Cheque(1,Data);
            //    item.ChequeId = 1;
            //}
        }
        private void RemoveControls(int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                Controls.Remove(numericUpDowns[i]);
                Controls.Remove(infoLabels[i]);
                Controls.Remove(moreDetailsButtons[i]);
                Controls.Remove(addButtons[i]);
            }
        }
        private void AddControls(int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                Controls.Add(infoLabels[i]);
                Controls.Add(addButtons[i]);
                Controls.Add(numericUpDowns[i]);
                Controls.Add(moreDetailsButtons[i]);
            }
        }
        private void CreateViewMedications()
        {
            int width = 200;
            int height = 192;
            for (int i = 0; i < medications.Count; i++)
            {
                if (i % 3 == 0) { width = 200; }
                CreateLabel(i, width, height, medications[i]);
                height += infoLabels[i].Height;
                CreateButtons(i, width, height);
                width += addButtons[i].Width;
                CreateNumericUpDowns(i, width, height, medications[i]);
                height -= infoLabels[i].Height;
                width += 80;

                
            }
        }

        private void CreateNumericUpDowns(int count, int width, int height, Medication medication)
        {
            numericUpDowns.Add(new NumericUpDown()
            {
                Name = "NumericUpDown" + count,
                Size = new Size(68,27),
                Location = new Point(width, height),
                Maximum = medication.Count,
                Minimum = 0
            });
        }
        private void CreateLabel(int count, int width, int height, Medication medication)
        {
            infoLabels.Add(new Label()
            {
                Name = "InfoLabel" + count.ToString(),
                Text = "Название: " + medication.Name + "\n" +
                "Вид: " + medication.ViewInfo + "\n" +
                "Цена: " + medication.Pricy + "\n" +
                "Количество: " + medication.Count,
                AutoSize = false,
                Size = new Size(150, 138),
                Location = new Point(width, height)
            });
        }
        private void CreateButtons(int count, int width, int height)
        {
            addButtons.Add(new Button()
            {
                Name = "AddButtons" + count.ToString(),
                Location = new System.Drawing.Point(width, height),
                Text = "Добавить",
                Size = new System.Drawing.Size(87, 27)
            });
            addButtons[count].Click += new System.EventHandler(AddButton_Click);

            moreDetailsButtons.Add(new Button()
            {
                Name = "MoreDetails" + count.ToString(),
                Location = new Point(width + 12, height + 33),
                Text = "Подробнее",
                Size = new Size(100, 29)
            });

            moreDetailsButtons[count].Click += new EventHandler(MoreDetailsButton_Click);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int count = int.Parse(button.Name[button.Name.Length - 1] + "");
            if (numericUpDowns[count].Value > 0 && payMedications.Keys.FirstOrDefault(x => x.Equals(medications[count])) == default)
            {
                payMedications.Add(medications[count], Convert.ToInt32(numericUpDowns[count].Value));
            }
            else if (numericUpDowns[count].Value > 0)
            {
                if(payMedications[medications[count]] + Convert.ToInt32(numericUpDowns[count].Value)
                    <= medications[count].Count)
                {
                    payMedications[medications[count]] += Convert.ToInt32(numericUpDowns[count].Value);
                }
                else
                {
                    payMedications[medications[count]] = medications[count].Count;
                }
            }
            else
            {
                MessageBox.Show("Нельзя добавить препарат в количестве 0 штук", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MoreDetailsButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int count = int.Parse(button.Name[button.Name.Length - 1] + "");
            MessageBox.Show(medications[count].Info, "Подробности", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CardButton_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new(payMedications);
            if(paymentForm.ShowDialog() == DialogResult.OK)
            {
                payMedications.Clear();
            }
            
        }

        private void NextMedicationButton_Click(object sender, EventArgs e)
        {
            if(countNext < medications.Count)
            {
                RemoveControls(countNext - 3, countNext);

                var countPrevious = countNext;
                countNext = medications.Count - countNext >= 3 ? countNext + 3 : medications.Count;
                AddControls(countPrevious, countNext );

                CreatePreviousButton();
            }
        }

        private void CreatePreviousButton()
        {
            if(previousMedicationButton == null)
            {
                previousMedicationButton = new Button
                {
                    Name = "PreviousMedicationButton",
                    Text = "Предыдущие",
                    Size = new Size(118, 29),
                    Location = new Point(546, 409)
                };

                previousMedicationButton.Click += new EventHandler(PreviousMedicationButton_Click);
            }

            Controls.Add(previousMedicationButton);
        }

        private void PreviousMedicationButton_Click(object sender, EventArgs e)
        {
            int countPrevious;
            if (countNext == medications.Count)
            {
                countPrevious = countNext % 3 == 0 ? countNext - 3 : countNext - countNext % 3;
            }
            else
            {
                countPrevious = countNext - 3;
            }
            RemoveControls(countPrevious, countNext);
            countNext = countPrevious;
            AddControls(countNext - 3, countNext);
            if(countNext <= 3)
            {
                Controls.Remove(previousMedicationButton);
            }
        }
    }
}
