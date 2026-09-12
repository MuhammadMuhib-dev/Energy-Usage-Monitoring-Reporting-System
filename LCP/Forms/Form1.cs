 // NuGet: Microsoft.Data.SqlClient
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCP
{
    public partial class Form1 : Form
    {
        private readonly string connString =
            @"Server=.\SQLEXPRESS;Database=LCP;Trusted_Connection=True;TrustServerCertificate=True;";

        private int? selectedPriceId = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMonths();
            LoadFuels();
            LoadPrices();
            ClearForm();
        }

        private void LoadMonths()
        {
            cmbMonth.Items.Clear();
            for (int m = 1; m <= 12; m++)
                cmbMonth.Items.Add(new MonthItem(m, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(m)));
            cmbMonth.DisplayMember = "Name";
        }

        private class MonthItem
        {
            public int Number { get; }
            public string Name { get; }
            public MonthItem(int number, string name) { Number = number; Name = name; }
            public override string ToString() => Name;
        }

        private void LoadFuels()
        {
            using (var conn = new SqlConnection(connString))
            using (var adapter = new SqlDataAdapter("SELECT FuelId, FuelName FROM Fuels ORDER BY FuelName", conn))
            {
                var table = new DataTable();
                adapter.Fill(table);
                cmbFuel.DataSource = table;
                cmbFuel.DisplayMember = "FuelName";
                cmbFuel.ValueMember = "FuelId";
            }
        }

        private void LoadPrices()
        {
            using (var conn = new SqlConnection(connString))
            using (var adapter = new SqlDataAdapter(@"
                SELECT fp.PriceId, f.FuelName, fp.MonthName, fp.MonthNumber, fp.Year, fp.PricePerUnit
                FROM FuelPrices fp
                JOIN Fuels f ON f.FuelId = fp.FuelId
                ORDER BY fp.Year DESC, fp.MonthNumber DESC", conn))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                if (dataGridView1.Columns["MonthNumber"] != null)
                    dataGridView1.Columns["MonthNumber"].Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            var month = (MonthItem)cmbMonth.SelectedItem;

            using (var conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO FuelPrices (FuelId, MonthNumber, MonthName, Year, PricePerUnit)
                    VALUES (@FuelId, @MonthNumber, @MonthName, @Year, @PricePerUnit)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    AddParameters(cmd, month);
                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("A price for this fuel in this month/year already exists. Use Update instead.",
                            "Duplicate entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            MessageBox.Show("Price saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPrices();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPriceId == null)
            {
                MessageBox.Show("Select a row from the grid first.", "No record selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;
            var month = (MonthItem)cmbMonth.SelectedItem;

            using (var conn = new SqlConnection(connString))
            {
                string query = @"UPDATE FuelPrices SET
                    FuelId = @FuelId, MonthNumber = @MonthNumber, MonthName = @MonthName,
                    Year = @Year, PricePerUnit = @PricePerUnit
                    WHERE PriceId = @PriceId";

                using (var cmd = new SqlCommand(query, conn))
                {
                    AddParameters(cmd, month);
                    cmd.Parameters.AddWithValue("@PriceId", selectedPriceId.Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Price updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPrices();
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            if (cmbFuel.Items.Count > 0) cmbFuel.SelectedIndex = 0;
            if (cmbMonth.Items.Count > 0) cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            nudYear.Value = DateTime.Now.Year;
            txtPrice.Clear();
            selectedPriceId = null;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            selectedPriceId = Convert.ToInt32(row.Cells["PriceId"].Value);

            string fuelName = row.Cells["FuelName"].Value.ToString();
            var fuelTable = (DataTable)cmbFuel.DataSource;
            foreach (DataRow fuelRow in fuelTable.Rows)
            {
                if (fuelRow["FuelName"].ToString() == fuelName)
                {
                    cmbFuel.SelectedValue = fuelRow["FuelId"];
                    break;
                }
            }

            int monthNum = Convert.ToInt32(row.Cells["MonthNumber"].Value);
            cmbMonth.SelectedIndex = monthNum - 1;

            nudYear.Value = Convert.ToInt32(row.Cells["Year"].Value);
            txtPrice.Text = row.Cells["PricePerUnit"].Value.ToString();
        }

        private void btnManageFuels_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open your Manage Fuels form here (add/edit Fuels table entries), " +
                "then call LoadFuels() again when it closes to refresh this dropdown.",
                "Manage Fuels", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateInput()
        {
            if (cmbFuel.SelectedValue == null || cmbMonth.SelectedItem == null ||
                !decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Select a fuel and month, and enter a valid price greater than 0.",
                    "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AddParameters(SqlCommand cmd, MonthItem month)
        {
            cmd.Parameters.AddWithValue("@FuelId", cmbFuel.SelectedValue);
            cmd.Parameters.AddWithValue("@MonthNumber", month.Number);
            cmd.Parameters.AddWithValue("@MonthName", month.Name);
            cmd.Parameters.AddWithValue("@Year", (int)nudYear.Value);
            cmd.Parameters.AddWithValue("@PricePerUnit", decimal.Parse(txtPrice.Text));
        }

        private void grpEntry_Enter(object sender, EventArgs e)
        {

        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
