using Hospital;
using HospitalCRM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMView
{
    public partial class PaymentForm : Form
    {
        private Dictionary<Medication, int> medications;
        private List<Label> nameMedicationLabels = new();
        private List<Label> pricyMedicationLabels = new();
        private List<NumericUpDown> countMedicationNumericUpDowns = new();
        private List<Label> allPricyMedicationLabels = new();
        public PaymentForm(Dictionary<Medication, int> medications)
        {
            this.medications = medications;
            InitializeComponent();
            CreateViewMedications();
        }

        private void CreateViewMedications()
        {
            int height = 60;
            int width = 25;
            int sizeX = 146;
            int sizeY = 36;
            int i = 0;
            foreach(var medication in medications.Keys) 
            { 
                CreateLabels( width, height, "nameMedicationLabels" + i, sizeX, sizeY,
                    (x) => nameMedicationLabels.Add(x), () => medication.Name);
                width += sizeX + 40;
                CreateLabels( width, height, "pricyMedicationLabels" + i, sizeX, sizeY,
                    (x) => pricyMedicationLabels.Add(x), () => medication.Pricy.ToString());
                width += sizeX + 40;
                CreateNumericUpDowns(i, width, height, sizeX, sizeY, medication, medications[medication]);
                width += sizeX + 40;
                CreateLabels(width, height, "AllPricyMedicationLabels" + i, sizeX, sizeY,
                    (x) => allPricyMedicationLabels.Add(x), () => (medication.Pricy * medications[medication]).ToString());
                height += sizeY + 20;
                width -= Convert.ToInt32(3 * sizeX + 120);
                i++;
            }

            ChangeNumberAllSumLabel();
        }

        private void CreateLabels( int width, int height, string name,int sizeX, int sizeY, 
            Action<Label> addLabel ,Func<string> func)
        {
            Label label = new Label()
            {
                Name = name,
                Text = func(),
                Size = new Size(sizeX, sizeY),
                Location = new Point(width, height),
                TextAlign = ContentAlignment.MiddleCenter
            };
            addLabel(label);

            Controls.Add(label);
        }

        private void ChangeNumberAllSumLabel()
        {
            int sum = 0;
            foreach(var medication in medications.Keys)
            {
                sum += medication.Pricy * medications[medication];
            }

            NumberAllSumLabel.Text = sum.ToString();
        }

        private void CreateNumericUpDowns(int index, int width, int height, int sizeX, int sizeY, Medication medication, int value)
        {
            NumericUpDown numericUpDown = new()
            {
                Name = "countMedicationNumericUpDowns" + index,
                Size = new Size(sizeX, sizeY),
                Location = new Point(width, height),
                Maximum = medication.Count,
                Value = value
            };

            countMedicationNumericUpDowns.Add(numericUpDown);
            numericUpDown.ValueChanged += new EventHandler(NumericUpDown_ValueChanged);
            Controls.Add(numericUpDown);
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            int index = int.Parse(numericUpDown.Name[numericUpDown.Name.Length - 1] + "");
            int i = 0;

            foreach(var medication in medications.Keys)
            {
                if (i == index)
                {
                    medications[medication] = Convert.ToInt32(numericUpDown.Value);
                    break;
                }
                i++;
            }
            allPricyMedicationLabels[index].Text = Convert.ToString(int.Parse(pricyMedicationLabels[index].Text + "") * numericUpDown.Value);
            ChangeNumberAllSumLabel();

            if (numericUpDown.Value == 0)
            {
                RemoveControls(int.Parse(numericUpDown.Name[numericUpDown.Name.Length - 1] + ""));
            }

            
        }

        private void RemoveControls(int indexRemove)
        {
            int swapRemoveIndex = medications.Count - 1;
            Controls.Remove(countMedicationNumericUpDowns[indexRemove]);
            Controls.Remove(nameMedicationLabels[indexRemove]);
            Controls.Remove(pricyMedicationLabels[indexRemove]);
            Controls.Remove(allPricyMedicationLabels[indexRemove]);

            if (indexRemove != swapRemoveIndex)
            {

                nameMedicationLabels[swapRemoveIndex].Location = nameMedicationLabels[indexRemove].Location;
                pricyMedicationLabels[swapRemoveIndex].Location = pricyMedicationLabels[indexRemove].Location;
                countMedicationNumericUpDowns[swapRemoveIndex].Location = 
                    countMedicationNumericUpDowns[indexRemove].Location;
                allPricyMedicationLabels[swapRemoveIndex].Location = allPricyMedicationLabels[indexRemove].Location;

                nameMedicationLabels[indexRemove] = nameMedicationLabels[swapRemoveIndex];
                pricyMedicationLabels[indexRemove] = pricyMedicationLabels[swapRemoveIndex];
                countMedicationNumericUpDowns[indexRemove] = countMedicationNumericUpDowns[swapRemoveIndex];
                allPricyMedicationLabels[indexRemove] = allPricyMedicationLabels[swapRemoveIndex];

            }
            swapRemoveIndex = indexRemove;
            nameMedicationLabels.RemoveAt(swapRemoveIndex);
            pricyMedicationLabels.RemoveAt(swapRemoveIndex);
            countMedicationNumericUpDowns.RemoveAt(swapRemoveIndex);
            allPricyMedicationLabels.RemoveAt(swapRemoveIndex);
            medications.Remove(medications.FirstOrDefault(x => x.Value == 0).Key);
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (medications.Count > 0)
            {
                CardForm cardForm = new();
                if(cardForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Оплата прошла успешна, можете забрать свой заказ", "Оплата",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Вы не можете заказать ничего", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
