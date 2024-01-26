// See https://aka.ms/new-console-template for more information
using homework2;

Console.WriteLine("Task #1");
int holePart = 45;

int decPart = 89;

string currency = "dollars";

int discount = 50;

Product m1 = new Product(holePart, decPart, currency, discount);
 

Console.WriteLine(m1.ToString());

Console.WriteLine("Task #2");

Skripka s1 = new Skripka();
Console.WriteLine(s1.Sound() + "\n" + s1.Show() + "\n" + s1.Histoty());
Trambon t1 = new Trambon();
Console.WriteLine(t1);
Ukulele ukulele = new Ukulele();
Console.WriteLine(ukulele);
Violontchel violontchel = new Violontchel();
Console.WriteLine(violontchel);
 

Console.WriteLine("Task #3 ");
Console.WriteLine("Convert to octal");
DecimalToOctalConverter converter = new DecimalToOctalConverter(123);
string octalNumber = converter.ConvertToOctal();
Console.WriteLine($"Decimal {converter.DecimalNumber} is equivalent to octal {octalNumber}");
Console.WriteLine("Convert to binary");
DecimalToBinaryConverter converterBin = new DecimalToBinaryConverter(123);
string binaryNumber = converterBin.ConvertToBinary();
Console.WriteLine($"Decimal {converterBin.DecimalNumber} is equivalent to binary {binaryNumber}");
Console.WriteLine("Convert to hexidecimal");
DecimalToHexadecimalConverter converterHex = new DecimalToHexadecimalConverter(123);
string hexNumber = converterHex.ConvertToHexadecimal();
Console.WriteLine($"Decimal {converterHex.DecimalNumber} is equivalent to hexadecimal {hexNumber}");

public struct DecimalToOctalConverter
{
    public int DecimalNumber;

    public DecimalToOctalConverter(int decimalNumber)
    {
        DecimalNumber = decimalNumber;
    }

    public string ConvertToOctal()
    {
        string octalNumber = "";

        int decimalNumber = DecimalNumber;

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 8;
            octalNumber = remainder.ToString() + octalNumber;
            decimalNumber /= 8;
        }

        return octalNumber;
    }
}

public struct DecimalToBinaryConverter
{
    public int DecimalNumber;

    public DecimalToBinaryConverter(int decimalNumber)
    {
        DecimalNumber = decimalNumber;
    }

    public string ConvertToBinary()
    {
        string binaryNumber = "";

        int decimalNumber = DecimalNumber;

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder.ToString() + binaryNumber;
            decimalNumber /= 2;
        }

        return binaryNumber;
    }
}
public struct DecimalToHexadecimalConverter
{
    public int DecimalNumber;

    public DecimalToHexadecimalConverter(int decimalNumber)
    {
        DecimalNumber = decimalNumber;
    }

    public string ConvertToHexadecimal()
    {
        string hexNumber = "";

        int decimalNumber = DecimalNumber;

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 16;
            if (remainder < 10)
            {
                hexNumber = remainder.ToString() + hexNumber;
            }
            else
            {
                char hexValue = (char)(remainder - 10 + 'A');
                hexNumber = hexValue + hexNumber;
            }
            decimalNumber /= 16;
        }

        return hexNumber;
    }
}

