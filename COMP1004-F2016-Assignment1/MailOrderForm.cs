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
    public partial class MailOrderForm : Form
    {
        // PRIVATE INSTANCE VARIABLES -------------------------------------------------------------
        private String _currentLanguage;
        private ErrorManager _errorHandler;

        // PUBLIC PROPERTIES ----------------------------------------------------------------------
        public String CurrentLanguage
        {
            get { return this._currentLanguage; }
            set { this._currentLanguage = value; }
        }

        // CONSTRUCTOR ----------------------------------------------------------------------------
        public MailOrderForm()
        {
            InitializeComponent();

            // Start language as english
            EnglishRadioButton.Checked = true;
            this.CurrentLanguage = "English";

            // Instantiate error handler
            this._errorHandler = new ErrorManager();
        }

        // EVENT HANDLING METHODS -----------------------------------------------------------------
        private void EnglishRadioButton_Click(object sender, EventArgs e)
        {
            EnglishRadioButton.Checked = true;
            this.CurrentLanguage = "English";
            _changeLabelLanguage();
        }

        private void GermanRadioButton_Click(object sender, EventArgs e)
        {
            GermanRadioButton.Checked = true;
            this.CurrentLanguage = "German";
            _changeLabelLanguage();
        }

        private void FrenchRadioButton_Click(object sender, EventArgs e)
        {
            FrenchRadioButton.Checked = true;
            this.CurrentLanguage = "French";
            _changeLabelLanguage();
        }

        private void SpanishRadioButton_Click(object sender, EventArgs e)
        {
            SpanishRadioButton.Checked = true;
            this.CurrentLanguage = "Spanish";
            _changeLabelLanguage();
        }

        /// <summary>
        /// This method will take all input from text boxes and ensure they contain valid data.
        /// 
        /// IF the data is NOT valid
        ///     Create an error window and display all errors found
        /// ELSE
        ///     Calculate the numbers and update textboxes to display calculated value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // No errors were found. Perform calculation and update form.
            if (_isDataValid())
            {
                // Perform bonus calculation
                String bonusSales = _calculateBonusSales();
                SalesBonusTextBox.Text = bonusSales;
            }

            // Errors were found. Print alert window and restart form.
            else
            {
                // Disable interaction with form when displaying error window.
                this.Enabled = false;
                _errorHandler.displayErrorLog();
                this.Enabled = true;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Display MessageBox with current information
            // Include message that says the document has been sent to the printer
            if (_isDataValid())
            {
                MessageBox.Show("Document sent to printer.", "Print Document Message", MessageBoxButtons.OK);
            }
            else
            {
                _errorHandler.displayErrorLog();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _clearForm();
        }

        // UTILITY METHODS ------------------------------------------------------------------------

        /// <summary>
        /// This method takes the value of CurrentLanguage and 
        /// changes the Label.Text values to the corresponding language.
        /// </summary>
        private void _changeLabelLanguage()
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

        /// <summary>
        /// This method clears all TextBox fields EXCEPT for TotalSalesTextBox.
        /// This is following assignment spec.
        /// </summary>
        private void _clearForm()
        {
            // Update text boxes to empty strings
            EmployeeNameTextBox.Text = "";
            EmployeeIDTextBox.Text = "";
            HoursWorkedTextBox.Text = "";
            SalesBonusTextBox.Text = "";
        }

        private Boolean _isDataValid()
        {
            // Validate all text fields.
            // If errors are found, they will be added to ErrorManager's error queue.
            _errorHandler.validateEmployeeName(EmployeeNameTextBox.Text);
            _errorHandler.validateEmployeeID(EmployeeIDTextBox.Text);
            _errorHandler.validateHoursWorked(HoursWorkedTextBox.Text);
            _errorHandler.validateTotalSales(TotalSalesTextBox.Text);

            // Return false if errors were found
            if (_errorHandler.HasErrors) { return false; }
            else { return true; }
        }

        private String _calculateBonusSales()
        {
            double salesBonus;
            try
            {
                // Convert values
                double hoursWorked = Double.Parse(HoursWorkedTextBox.Text);
                double totalSales = Double.Parse(TotalSalesTextBox.Text);

                // Perform calculation
                double percentageOfHours = hoursWorked / 160;
                double totalBonusAmount = totalSales * 0.02;
                salesBonus = percentageOfHours * totalBonusAmount;
            }
            catch (InvalidCastException e)
            {
                salesBonus = 0;
                MessageBox.Show("_calculateBonusSales() error: InvalidCastException thrown.");
            }
            catch (FormatException e)
            {
                salesBonus = 0;
                MessageBox.Show("_calculateBonusSales() error: FormatException thrown.");
            }

            // Return string in currency format (Ex. $1235.56)
            return salesBonus.ToString("C2");
        }
    }
}
