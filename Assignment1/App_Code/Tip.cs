using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Tip
/// </summary>
public class Tip
{
    //fields: Fields are class level variabels that describe the class
    public double MealAmount { set; get; } // This is a short cut to write 'set' and 'get' methods
    public double TipPercent { set; get; }
    private const double TAXPERCENT = 0.096;
    public Tip()  // Constructor: Have no return type
    {
        MealAmount = 0;
        TipPercent = 0;
    }

    public Tip(double meal, double percent)
    {
        MealAmount = meal;
        TipPercent = percent;
        // 'this' is a keyword that will access 'this' object. A self referencing object keyword.
    }
    public double CalculateTax()
    {
        return MealAmount * TAXPERCENT;
           
    }

    public double CalculateTip()
    {
        return MealAmount * TipPercent;
    }

    public double CalculateTotal()
    {
        return MealAmount + CalculateTax() + CalculateTip();
    }
}