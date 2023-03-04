using Hospital;
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
        private List<Label> AllPricyMedicationLabels = new();
        public PaymentForm(Dictionary<Medication, int> medications)
        {
            this.medications = medications;
            CreateViewMedications();
            InitializeComponent();
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
                width += sizeX / 2 + 20;
                CreateLabels( width, height, "pricyMedicationLabels" + i, sizeX, sizeY,
                    (x) => pricyMedicationLabels.Add(x), () => medication.Pricy.ToString());
                width += sizeX / 2 + 20;
                //CreateNumericUpDowns(i, width, height, sizeX, sizeY);
            }
        }

        private void CreateLabels( int width, int height, string name,int sizeX, int sizeY, 
            Action<Label> addLabel ,Func<string> func)
        {
            Label label = new Label()
            {
                Name = name,
                Text = func(),
                Size = new Size(sizeX, sizeY),
                Location = new Point(width, height)
            };
            addLabel(label);

            Controls.Add(label);
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

            numericUpDown.ValueChanged += new EventHandler(NumericUpDown_ValueChanged);
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            if(numericUpDown.Value == 0)
            {
                RemoveControls(int.Parse(numericUpDown.Name[numericUpDown.Name.Length - 1] + ""));
            }
        }

        private void RemoveControls(int index)
        {
            Controls.Remove(countMedicationNumericUpDowns[index]);
            Controls.Remove(nameMedicationLabels[index]);
            Controls.Remove(pricyMedicationLabels[index]);
            Controls.Remove(AllPricyMedicationLabels[index]);
            //medications.Remove();


        }
        private void PayButton_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
