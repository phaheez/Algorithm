Console.WriteLine("Hello, World!");
//TheyBelong(2, 2, 7, 2, 5, 4, 4, 3, 7, 4);
//TheyBelong(452, 476, 46, 1790, 184, 1656, 1, 1, 2, 2);
//TheyBelong(0, 0, 2, 0, 4, 0, 2, 0, 4, 0);
//TheyBelong(3, 1, 7, 1, 5, 5, 1, 1, 2, 2);
TheyBelong(0, 0, 2, 0, 4, 0, 2, 0, 4, 0);

static double Area(int x1, int y1, int x2, int y2, int x3, int y3)
{
    return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
}

static bool IsInside(int x1, int y1, int x2, int y2, int x3, int y3, int p, int q)
{
    double A = Area(x1, y1, x2, y2, x3, y3);
    double A1 = Area(p, q, x2, y2, x3, y3);
    double A2 = Area(x1, y1, p, q, x3, y3);
    double A3 = Area(x1, y1, x2, y2, p, q);

    return (A == A1 + A2 + A3);
}

static void TheyBelong(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int x5, int y5)
{
    var ab = Convert.ToDouble(Math.Abs(x2 - x1));
    var bc = Convert.ToDouble(Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y3 - y2, 2)).ToString("#.##"));
    var ac = Convert.ToDouble(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y3 - y1, 2)).ToString("#.##"));

    var pInside = IsInside(x1, y1, x2, y2, x3, y3, x4, y4);
    var qInside = IsInside(x1, y1, x2, y2, x3, y3, x5, y5);
    
    string res;

    if (!(ab + bc > ac && bc + ac > ab && ab + ac > bc))
    {
        res = "0";
    }
    else if (pInside && !qInside)
    {
        res = "1";
    }
    else if (qInside && !pInside)
    {
        res = "2";
    }
    else if (pInside && qInside)
    {
        res = "3";
    }
    else if (!pInside && !qInside)
    {
        res = "4";
    }
    else
    {
        res = "NULL";
    }

    Console.WriteLine(res);
}
