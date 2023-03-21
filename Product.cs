using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    public Product(string name)
    {
        Name = name;
        var randomNumber = new Random();
        Code = randomNumber.Next(10, 500);
    }
    public int Code { get; private init; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public double Price { get; set; }
    public double Iva { get; set; }

    public string GetUntaxedPrice()
    {
        var untaxedPrice = Price + "$";
        return untaxedPrice;
    }

    public string GetTaxedPrice()
    {
        var taxedPrice = Math.Round(Price * (1 + Iva)) + "$";
        return taxedPrice;
    }

    public string GetExtendedName()
    {
        return Code + " " + Name;
    }

    public string GetPaddedCode()
    {
        var stringCode = Convert.ToString(Code);
        var zero = "0";
        var iterations = 8 - stringCode.Length;
        
        for (int i = 0; i < iterations; i++)
        {
            stringCode = zero + stringCode;
        }

        return stringCode; 
    }

}
