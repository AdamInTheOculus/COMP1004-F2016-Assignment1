using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace COMP1004_F2016_Assignment1
{
    class ErrorManager
    {
        // PRIVATE INSTANCE VARIABLES -------------------------------------------------------------

        // Holds all error messages in a list.
        // Each element is its own error message.
        private List<String> _errorLog;

        // PUBLIC PROPERTIES ----------------------------------------------------------------------
        public Boolean HasErrors
        {
            // Read-only access.
            get {
                    if (this._errorLog.Count > 0) return true;
                    else return false;
                }
        }

        // CONSTRUCTOR ----------------------------------------------------------------------------
        public ErrorManager()
        {
            // Instantiate our list
            _errorLog = new List<String>();
        }

        // PUBLIC METHODS -------------------------------------------------------------------------
        public void validateEmployeeName(String employeeName)
        {
            // Ensure name isn't empty/null
            if(employeeName == null || employeeName == "")
            {
                addErrorEvent("Given employee name was either null or empty.");
            }

            else
            {
                // Ensure name has only characters; no numbers/symbols.
                // This regular expression accepts any alphabetical character or spaces. Case insensitive.
                Regex lettersOnly = new Regex(@"[a-z][A-Z]+[\s]*");
                if (!lettersOnly.IsMatch(employeeName))
                {
                    addErrorEvent("Given employee contains invalid characters. Do not use numbers or symbols.");
                }
            }
        }

        public void validateEmployeeID(String employeeID)
        {
            // Ensure ID isn't empty or null
            if(employeeID == null || employeeID == "")
            {
                addErrorEvent("Given employee ID was either null or empty.");
            }

            else
            {
                // Ensure ID has only digits.
                // This regular expressions accepts only digits. Minimum of one digit is required.
                Regex digitsOnly = new Regex(@"^[0-9]+$");
                if (!digitsOnly.IsMatch(employeeID))
                {
                    addErrorEvent("Given employee ID contains invalid characters. Only use numerical digits. No spaces.");
                }
            }
        }

        public void validateHoursWorked(String hoursString)
        {
            double hoursWorked;

            try
            {
                // Attempt to parse String to Double.
                hoursWorked = Double.Parse(hoursString);

                // Ensure hoursWorked is in valid range.
                if (hoursWorked <= 0 || hoursWorked > 160)
                {
                    addErrorEvent("Given hours worked is invalid. Enter a number between [1-160].");
                }
            }
            // Handle any exceptions from parsing string.
            catch (InvalidCastException e)
            {
                addErrorEvent("Attempted to parse hours worked and received InvalidCastException.");
            }
            catch(FormatException e)
            {
                addErrorEvent("Attempted to parse hours worked and received FormatException.");
            }
        }

        public void validateTotalSales(String totalString)
        {
            double totalSales;

            try
            {
                // Attempt to parse String to Double.
                totalSales = Double.Parse(totalString);

                // Ensure totalSales is in valid range.
                if(totalSales <= 0)
                {
                    addErrorEvent("Given total sales is invalid. Enter a number greater than zero.");
                }
            }
            // Handle any exceptions from parsing string.
            catch (InvalidCastException e)
            {
                addErrorEvent("Attempted to parse total sales and received InvalidCastException.");
            }
            catch (FormatException e)
            {
                addErrorEvent("Attempted to parse total sales and received FormatException.");
            }
        }

        public void displayErrorLog()
        {
            // Create temporary form that displays all error messages.
            Debug.WriteLine("Inside displayErrorLog()");

            // Form size will be dynamic to number of messages in error log.

            // Clear error log once form has been closed.
            _errorLog.Clear();
        }

        // PRIVATE METHODS ------------------------------------------------------------------------
        private void addErrorEvent(String error)
        {
            _errorLog.Add(error);
        }
    }
}
