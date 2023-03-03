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

        public StoryForm(Person people, List<Medication> medications)
        {
            this.medications = medications;
            this.people = people;
            InitializeComponent();
            CreateViewMedications();
            int count = medications.Count > 3 ? 3 : medications.Count; 
            AddControls(0,count);
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
                CreateLabel(i, width, height, medications[i]);
                height += infoLabels[i].Height;
                CreateButtons(i, width, height);
                width += addButtons[i].Width;
                CreateNumericUpDowns(i, width, height, medications[i]);
                height -= infoLabels[i].Height;
                width += 50;
            }
        }

        private void CreateNumericUpDowns(int count, int width, int height, Medication medication)
        {
            numericUpDowns.Add(new NumericUpDown()
            {
                Name = "NumericUpDown" + count,
                Size = new Size(42,27),
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
                Size = new Size(124, 138),
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
                Name = "MoreDetails",
                Location = new Point(width + 12, height + 33),
                Text = "Подробнее",
                Size = new Size(88, 29)
            });

            moreDetailsButtons[count].Click += new EventHandler(MoreDetailsButton_Click);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // ToDo
        }

        private void MoreDetailsButton_Click(object sender, EventArgs e)
        {
            // ToDo
        }
        private void CardButton_Click(object sender, EventArgs e)
        {

        }

        private void NextMedicationButton_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
