using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClosedXML.Excel;



namespace QR_CODE_DATA_CREATOR
{
    public partial class Form1 : Form
    {
        private int currentX = 0;
        private int currentY = 0;
        private int stepCounter = 0;
        private string finalvalue = "";
        private List<CoordinateStep> stepsHistory = new List<CoordinateStep>();

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
        }
        public class CoordinateStep
        {
            public int Step { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
        }
        private void SetupDataGridView()
        {
            dataGridViewSteps.DataSource = stepsHistory;
        }
        private void RefreshGrid()
        {
            dataGridViewSteps.DataSource = null;
            dataGridViewSteps.DataSource = stepsHistory;
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveBaseBTN_Click(object sender, EventArgs e)
        {
            if (int.TryParse(BaseX.Text, out int convBaseX) &&
                int.TryParse(BaseY.Text, out int convBaseY))
            {
                currentX = convBaseX;
                currentY = convBaseY;
                stepCounter = 0;

                stepsHistory.Clear();
                stepsHistory.Add(new CoordinateStep { Step = stepCounter, X = currentX, Y = currentY });
                RefreshGrid();
                MessageBox.Show("Wartoœci bazowe zosta³y ustawione");
            }
            else
            {
                MessageBox.Show("WprowadŸ poprawne wartoœci liczbowe dla bazy.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NextStepBTN_Click(object sender, EventArgs e)
        {
            int deltaX = string.IsNullOrWhiteSpace(NextX.Text) ? 0 : int.Parse(NextX.Text);
            int deltaY = string.IsNullOrWhiteSpace(NextY.Text) ? 0 : int.Parse(NextY.Text);

            if (deltaX == 0 && deltaY == 0)
            {
                MessageBox.Show("Nie mo¿esz wprowadziæ dwa razy zero do X i Y !!!");
            }
            else
            {
                currentX += deltaX;
                currentY += deltaY;
                stepCounter += 1;
                stepsHistory.Add(new CoordinateStep { Step = stepCounter, X = currentX, Y = currentY });
                RefreshGrid();
            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (stepsHistory.Count == 0)
            {
                MessageBox.Show("Brak danych do zapisu.", "Ostrze¿enie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Historia wspó³rzêdnych");
                            for (int i = 0; i < stepsHistory.Count; i++)
                            {
                                string X = stepsHistory[i].X.ToString();
                                string Y = stepsHistory[i].Y.ToString();
                                string finalvalue = X + Y;
                                worksheet.Cell(i + 1, 1).Value = int.Parse(finalvalue);
                            }
                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Zapisano pomyœlnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wyst¹pi³ b³¹d podczas zapisu: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }
    }
}
