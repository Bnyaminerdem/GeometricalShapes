using System.Drawing;
public class Square
{
    public double KenarUzunluğu {get ; set;}
    public double AlanHesapla()
    {
        return KenarUzunluğu * KenarUzunluğu;
    }
}
public class Triangle
{
    public double Kenar1 { get; set;}
    public double Kenar2 { get; set;}
    public double Kenar3 { get; set;}
    public  double AlanHesapla()
    {
        double k = (Kenar1 + Kenar2 + Kenar3 ) / 2;
        return Math.Sqrt(k * (k - Kenar1) * (k - Kenar2) * (k - Kenar3));
    }
} 
public class Apartment
{
    public double Yaricap { get; set;}

    public double AlanHesapla()
    {
     return Math.PI * Yaricap * Yaricap;
    }
}
public class Rectangle
{
    public double UzunKenar { get; set; }
    public double KısaKenar { get; set; }
    public double AlanHesapla()
    {
        return UzunKenar * KısaKenar;
    }
   
}