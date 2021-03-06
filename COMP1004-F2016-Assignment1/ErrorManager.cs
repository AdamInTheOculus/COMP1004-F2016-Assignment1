﻿/*
 * APP NAME: Sharp Mail Order - ORDER FORM
 * AUTHOR NAME: Adam Sinclair
 * AUTHOR ID: 200321984
 * APP CREATION DATE: September 20th 2016
 * APP DESCRIPTION: 
 *    A small form application that takes in employee information, # of hours worked, and the total sales amount.
 *    A Calculate button will determine the amount of sales bonus an employee receives.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<String> ErrorLog
        {
            get { return this._errorLog; }
        }

        // CONSTRUCTOR ----------------------------------------------------------------------------
        public ErrorManager()
        {
            // Instantiate our list
            _errorLog = new List<String>();
        }

        // PUBLIC METHODS -------------------------------------------------------------------------

        /// <summary>
        /// Error validation. Validates employee name is only characters and spaces.
        /// If it's not, add error to error list.
        /// </summary>
        /// <param name="employeeName"></param>
        public void validateEmployeeName(String employeeName)
        {
            // Ensure name isn't empty/null
            if(employeeName == null || employeeName == "")
            {
                _addErrorEvent("Given employee name was either null or empty.");
            }

            else
            {
                // Ensure name has only characters; no numbers/symbols.
                // This regular expression accepts any alphabetical character or spaces. Case insensitive.
                Regex lettersOnly = new Regex(@"^[a-zA-Z ]+$");
                if (!lettersOnly.IsMatch(employeeName))
                {
                    _addErrorEvent("Given employee contains invalid characters. Do not use numbers or symbols.");
                }
            }
        }

        /// <summary>
        /// Error validation. Validate employeeID is only positive numbers.
        /// If it's not, add error to error list
        /// </summary>
        /// <param name="employeeID"></param>
        public void validateEmployeeID(String employeeID)
        {
            // Ensure ID isn't empty or null
            if(employeeID == null || employeeID == "")
            {
                _addErrorEvent("Given employee ID was either null or empty.");
            }

            else
            {
                // Ensure ID has only digits.
                // This regular expressions accepts only digits. Minimum of one digit is required.
                Regex digitsOnly = new Regex(@"^[0-9]+$");
                if (!digitsOnly.IsMatch(employeeID))
                {
                    _addErrorEvent("Given employee ID contains invalid characters. Only use numerical digits. No spaces.");
                }
            }
        }

        /// <summary>
        /// Error validation. Validate hoursWorked is truly a double.
        /// If it's not, add error to error list.
        /// </summary>
        /// <param name="hoursString"></param>
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
                    _addErrorEvent("Given hours worked is invalid. Enter a number between [1-160].");
                }
            }
            // Handle any exceptions from parsing string.
            catch (InvalidCastException e)
            {
                _addErrorEvent("Given hours worked was the wrong type. Enter a number between [1-160].");
            }
            catch(FormatException e)
            {
                _addErrorEvent("Given hours worked generated an error. Enter a number between [1-160].");
            }
        }

        /// <summary>
        /// Error validation. Validate totalSales is truly a double.
        /// If it's not, add error to error list.
        /// </summary>
        /// <param name="totalString"></param>
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
                    _addErrorEvent("Given total sales is invalid. Enter a number greater than zero.");
                }
            }
            // Handle any exceptions from parsing string.
            catch (InvalidCastException e)
            {
                _addErrorEvent("Given total sales was the wrong type. Enter a number greater than zero.");
            }
            catch (FormatException e)
            {
                _addErrorEvent("Given total sales was the wrong type. Enter a number greater than zero.");
            }
        }

        /// <summary>
        /// Display message box of all errors in error log
        /// </summary>
        public void displayErrorLog()
        {
            // Create and open our Message Box
            String errorText = _generateErrorString();
            MessageBox.Show(errorText, "Errors Found", MessageBoxButtons.OK);

            // Empty our error log
            this._errorLog.Clear();
        }

        // PRIVATE METHODS ------------------------------------------------------------------------
        /// <summary>
        /// Add error message to the error list
        /// </summary>
        /// <param name="error"></param>
        private void _addErrorEvent(String error)
        {
            _errorLog.Add(error);
        }

        /// <summary>
        /// Take current error list and generate a single string to add to text box.
        /// Return generated string.
        /// </summary>
        /// <param name="errorList"></param>
        /// <returns></returns>
        private String _generateErrorString()
        {
            String errorText = "";

            // Append each error message into one big string
            foreach (String text in this._errorLog)
            {
                errorText += "- " + text + "\n";
            }

            // Return generated error message
            return errorText;
        }

    }
}
