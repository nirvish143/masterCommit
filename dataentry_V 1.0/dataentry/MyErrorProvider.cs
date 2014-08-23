using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


class MyErrorProvider
{
    static Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
    static Regex charchk = new Regex(@"^[A-Za-z]+$", RegexOptions.None);
    static Regex emailchk = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
 

    public MyErrorProvider()
    {
        
    }
    static public bool requireField(ErrorProvider errorProvider1,Control control1,string value,string message ="Field Is Required")
    {
        if (value == string.Empty)
        {
            errorProvider1.SetError(control1, message);
            return false;
        }
        return true;

    }
    static public bool numberOnly(ErrorProvider errorProvider1, Control control1, string value, string message = "Number Only")
    {
        if (!numberchk.IsMatch(value))
        {
            errorProvider1.SetError(control1, message);
            return false;
        }
        return true;
    }
    static public bool charOnly(ErrorProvider errorProvider1, Control control1, string value, string message = "Character Only")
    {
        if (!charchk.IsMatch(value))
        {
            errorProvider1.SetError(control1, message);
            return false;
        }
        return true;
    }

    static public bool email(ErrorProvider errorProvider1, Control control1, string value, string message = "Invalid Email")
    {
        if (!emailchk.IsMatch(value))
        {
            errorProvider1.SetError(control1, message);
            return false;
        }
        return true;
    }
    static public bool lengthMin(ErrorProvider errorProvider1, Control control1, string value, int minlength, string message = "Invalid Length")
    {
        if (value.Length < minlength)
        {
            errorProvider1.SetError(control1, message);
            return false;
        }
        return true;
    }
    static public bool lengthMax(ErrorProvider errorProvider1, Control control1, string value, int maxlength, string message = "Invalid Length")
    {
        if (value.Length > maxlength)
        {
            errorProvider1.SetError(control1, message);
            return false;
        }
        return true;
    }
    static public bool lengthMaxMin(ErrorProvider errorProvider1, Control control1, string value, int maxlength,int minlength, string message = "Invalid Length")
    {
        if (value.Length < minlength || value.Length> maxlength)
        {
            errorProvider1.SetError(control1, message);
            return false;
        }
        return true;
    }
}

