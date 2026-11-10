using System.ComponentModel;
using System.Globalization;
using Microsoft.VisualBasic;

namespace GestiondeFactures
{
    public partial class Form1 : Form
    {
        private BindingList<Facture> Factures = new BindingList<Facture>();

        public Form1()
        {
            InitializeComponent();
            DTG_main.AutoGenerateColumns = false;
            DTG_main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTG_main.MultiSelect = false;
            DTG_main.AllowUserToAddRows = false;
            DTG_main.ReadOnly = true;
            DTG_main.RowHeadersVisible = false;
            DTG_main.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DTG_main.DataSource = Factures;
            DTG_main.CellClick += DTG_main_CellClick;
            TXT_ListeTotaleFacture.ReadOnly = true;
            TXT_TotalFactureJours.ReadOnly = true;
        }

        private void BTN_ajt_Click(object sender, EventArgs e)
        {
            string numero = TXT_num.Text.Trim();
            decimal montant;

            if (numero == "" || LireMontant(out montant) == false)
            {
                MessageBox.Show("Entrez un numero et un montant valide.");
                return;
            }

            for (int i = 0; i < Factures.Count; i++)
            {
                if (Factures[i].NUM_DATA.ToLower() == numero.ToLower())
                {
                    MessageBox.Show("Ce numero de facture existe deja.");
                    return;
                }
            }

            Factures.Add(new Facture(numero, montant));
            TXT_num.Clear();
            TXT_mnt.Clear();
        }

        private void BTN_sup_Click(object sender, EventArgs e)
        {
            if (DTG_main.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectionnez une facture a supprimer.");
                return;
            }

            DialogResult reponse = MessageBox.Show(
                "Voulez-vous vraiment supprimer cette facture ?",
                "Confirmer la suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (reponse == DialogResult.No)
            {
                return;
            }

            int index = DTG_main.SelectedRows[0].Index;
            Factures.RemoveAt(index);
        }

        private void BTN_rch_Click(object sender, EventArgs e)
        {
            string numero = Interaction.InputBox("Entrez le numero de la facture :", "Rechercher une facture").Trim();

            if (numero == "")
            {
                return;
            }

            for (int i = 0; i < Factures.Count; i++)
            {
                if (Factures[i].NUM_DATA.ToLower() == numero.ToLower())
                {
                    DTG_main.ClearSelection();
                    DTG_main.Rows[i].Selected = true;
                    DTG_main.CurrentCell = DTG_main.Rows[i].Cells[0];
                    TXT_num.Text = Factures[i].NUM_DATA;
                    TXT_mnt.Text = Factures[i].MNT_DATA.ToString("0.00", CultureInfo.GetCultureInfo("fr-FR"));
                    return;
                }
            }

            MessageBox.Show("Facture introuvable.");
        }

        private void BTN_mdf_Click(object sender, EventArgs e)
        {
            int index = -1;

            if (DTG_main.SelectedRows.Count > 0)
            {
                index = DTG_main.SelectedRows[0].Index;
            }
            else
            {
                for (int i = 0; i < Factures.Count; i++)
                {
                    if (Factures[i].NUM_DATA.ToLower() == TXT_num.Text.Trim().ToLower())
                    {
                        index = i;
                        break;
                    }
                }
            }

            if (index == -1)
            {
                MessageBox.Show("Selectionnez ou recherchez une facture a modifier.");
                return;
            }

            string numero = TXT_num.Text.Trim();
            decimal montant;

            if (numero == "" || LireMontant(out montant) == false)
            {
                MessageBox.Show("Entrez un numero et un montant valide.");
                return;
            }

            for (int i = 0; i < Factures.Count; i++)
            {
                if (i != index && Factures[i].NUM_DATA.ToLower() == numero.ToLower())
                {
                    MessageBox.Show("Ce numero de facture existe deja.");
                    return;
                }
            }

            Factures[index].NUM_DATA = numero;
            Factures[index].MNT_DATA = montant;
            DTG_main.Refresh();
        }

        private void BTN_aff_Click(object sender, EventArgs e)
        {
            AfficherFactures();
        }

        private void BTN_frm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DTG_main_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TXT_num.Text = Factures[e.RowIndex].NUM_DATA;
                TXT_mnt.Text = Factures[e.RowIndex].MNT_DATA.ToString("0.00", CultureInfo.GetCultureInfo("fr-FR"));
            }
        }

        private void AfficherFactures()
        {
            TXT_ListeTotaleFacture.Clear();
            decimal total = 0;

            for (int i = 0; i < Factures.Count; i++)
            {
                TXT_ListeTotaleFacture.AppendText(Factures[i].NUM_DATA + " : " + Factures[i].MNT_DATA.ToString("0.00", CultureInfo.GetCultureInfo("fr-FR")) + Environment.NewLine);
                total = total + Factures[i].MNT_DATA;
            }

            TXT_TotalFactureJours.Text = total.ToString("0.00", CultureInfo.GetCultureInfo("fr-FR"));
        }

        private bool LireMontant(out decimal montant)
        {
            string texte = TXT_mnt.Text.Trim().Replace(" ", "");

            if (texte.Contains(","))
            {
                texte = texte.Replace(".", "");
                texte = texte.Replace(",", ".");
            }

            if (decimal.TryParse(texte, NumberStyles.Number, CultureInfo.InvariantCulture, out montant) == false)
            {
                return false;
            }

            return montant >= 0;
        }
    }
}
