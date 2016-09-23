using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assignment1
{
    public partial class SalesBonusForm : Form
    {
        // PRIVATE INSTANCE VARIABLES -------------------------------------------------------------
        private String currentLanguage;

        // PUBLIC PROPERTIES ----------------------------------------------------------------------
        public String CurrentLanguage
        {
            get { return this.currentLanguage; }
            set { this.currentLanguage = value; }
        }

        // CONSTRUCTOR ----------------------------------------------------------------------------
        public SalesBonusForm()
        {
            InitializeComponent();

            // Start language as english
            EnglishRadioButton.Checked = true;
            this.CurrentLanguage = "English";
        }

        // EVENT HANDLING METHODS -----------------------------------------------------------------
        private void EnglishRadioButton_Click(object sender, EventArgs e)
        {
            EnglishRadioButton.Checked = true;
            this.CurrentLanguage = "English";
            changeLabelLanguage();
        }

        private void GermanRadioButton_Click(object sender, EventArgs e)
        {
            GermanRadioButton.Checked = true;
            this.CurrentLanguage = "German";
            changeLabelLanguage();
        }

        private void FrenchRadioButton_Click(object sender, EventArgs e)
        {
            FrenchRadioButton.Checked = true;
            this.CurrentLanguage = "French";
            changeLabelLanguage();
        }

        private void SpanishRadioButton_Click(object sender, EventArgs e)
        {
            SpanishRadioButton.Checked = true;
            this.CurrentLanguage = "Spanish";
            changeLabelLanguage();
        }

        // UTILITY METHODS ------------------------------------------------------------------------
        private void changeLabelLanguage()
        {
            // Determine what the current language is and change labels accordingly
            switch (this.CurrentLanguage)
            {
                case "English":
                    // Update labels
                    EmployeeNameLabel.Text = "Employee Name:";
                    EmployeeIDLabel.Text = "Employee ID:";
                    HoursWorkedLabel.Text = "Hours Worked:";
                    TotalSalesLabel.Text = "Total Sales:";
                    SalesBonusLabel.Text = "Sales Bonus:";

                    // Update buttons
                    CalculateButton.Text = "Calculate";
                    PrintButton.Text = "Print";
                    ClearButton.Text = "Clear";

                    // Update language box title
                    LanguageGroupBox.Text = "Language";
                    break;

                case "French":
                    // Update labels
                    EmployeeNameLabel.Text = "Nom de l'employé:";
                    EmployeeIDLabel.Text = "ID de l'employé:";
                    HoursWorkedLabel.Text = "Heures travaillées:";
                    TotalSalesLabel.Text = "Ventes totales:";
                    SalesBonusLabel.Text = "Bonus de vente:";

                    // Update buttons
                    CalculateButton.Text = "Calculer";
                    PrintButton.Text = "Impression";
                    ClearButton.Text = "Effacer";

                    // Update language box title
                    LanguageGroupBox.Text = "La langue";
                    break;

                case "Spanish":
                    // Update labels
                    EmployeeNameLabel.Text = "Nombre de empleado:";
                    EmployeeIDLabel.Text = "Número de empleado:";
                    HoursWorkedLabel.Text = "Horas trabajadas:";
                    TotalSalesLabel.Text = "Ventas totales:";
                    SalesBonusLabel.Text = "Bono de ventas:";

                    // Update buttons
                    CalculateButton.Text = "Calcular:";
                    PrintButton.Text = "Impresión";
                    ClearButton.Text = "Borrar";

                    // Update language box title
                    LanguageGroupBox.Text = "Idioma";
                    break;

                case "German":
                    // Update labels
                    EmployeeNameLabel.Text = "Mitarbeitername:";
                    EmployeeIDLabel.Text = "Mitarbeiternummer:";
                    HoursWorkedLabel.Text = "Arbeitsstunden:";
                    TotalSalesLabel.Text = "Gesamtumsatz:";
                    SalesBonusLabel.Text = "Der Umsatz Bonus:";

                    // Update buttons
                    CalculateButton.Text = "Berechnen";
                    PrintButton.Text = "Drucken";
                    ClearButton.Text = "Löschen";

                    // Update language box title
                    LanguageGroupBox.Text = "Sprache";
                    break;
                default:
                    Debug.WriteLine("ERROR: Invalid language selected.");
                    break;
            }
        }
    }
}
