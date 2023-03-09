


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Threading.Tasks.Sources;
using System.Xml.Linq;






namespace MeuprimeiroProjetoConsol
{
    public class Cachorro
    {
        public string Raça { get; set; }
        public string Porte { get; set; }
        public string Late { get; set; }
        public void DataNasc(int data)
        {
            var dataa = DateTime.Now.Year;
            Console.WriteLine("A idade do cachorro é " + (dataa - data) + " Anos");

        }



    }

    class Program
    {
        static void Main(string[] args)
        {

            Cachorro cachorro = new Cachorro();
            cachorro.Raça = "Pitbull";
            cachorro.Porte = "Grande";
            cachorro.Late = "Sim";
            cachorro.DataNasc(2013);

            var lista = getPropertyValues(cachorro);
            foreach (var item in lista)
            {
                Console.WriteLine(item.Key + ": " + item.Value.ToString());
            }

        }
        public static Dictionary<string, object> getPropertyValues(object o)
        {
            Dictionary<string, object> propertyValues = new Dictionary<string, object>();
            Type ObjectType = o.GetType();
            System.Reflection.PropertyInfo[] properties = ObjectType.GetProperties();
            foreach (System.Reflection.PropertyInfo property in properties)
            {
                propertyValues.Add(property.Name, property.GetValue(o, null));
            }
            return propertyValues;
        }
    }
}


