using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Task1
{
    public class ComplexNumber 
    {
        public double A { get; set; }
        public double B { get; set; }
        public ComplexNumber()
        {

        }
        public ComplexNumber(double A, double B)
        {
            this.A = A;
            this.B = B;
        }
        
        public string ToString()
        {
            return string.Format("The Complex Number has the real number {0} and the imaginary number {1}", A, B);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber cn = new ComplexNumber(522, 32.3);
            XmlSerializer sr = new XmlSerializer(typeof(ComplexNumber));
            using (FileStream fs = File.Create(@"C:\Users\asus\Desktop\pp2\file.xml"))
            {
                sr.Serialize(fs, cn);//куда, что
            }
            cn = null;// стрирается+
            using (FileStream fs = File.Open(@"C:\Users\asus\Desktop\pp2\file.xml", FileMode.Open))
            {
                cn = (ComplexNumber)sr.Deserialize(fs);// cn-куда, fs-откуда
            }

            Console.WriteLine(cn.ToString());
            Console.ReadLine();
        }
    }
}