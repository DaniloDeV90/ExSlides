

            using System;
            using System.Collections.Generic;
            using System.ComponentModel;
            using System.Globalization;
            using System.Text;
            using System.Threading.Tasks.Sources;
            using System.Xml.Linq;
            
            
            namespace MeuprimeiroProjetoConsole
            {
                public class Carro
                {
                    public string placa { get; set; }
                    public string modelo { get; set; }
                    public int anoDfabrica { get; set; }
                    public string Marca { get; set; }
            
                    public string Acelerar()
                    {
                        return "O carro está em movimento";
                    }
                    public string Freiar ()
                    {
                        return ("O carro está parado");
                    }
            
                }
            
                class Program
                {
                    static void Main(string[] args)
                    {
                        ;
            
            
            
            
            
                        Carro objcarro = new Carro();
                        objcarro.placa = "8323";
                        objcarro.modelo = "FUSCA";
                        objcarro.anoDfabrica = 1987;
                        objcarro.Marca = "VOLKSWAGEN";
            
            
            
                        var retorno = getPropertyValues(objcarro);
            
                        foreach (var item in retorno)
                        {
                            Console.WriteLine(item.Value.ToString() + "\n");
                            
            
                        }
                        Console.WriteLine (objcarro.Acelerar());
            
                        Console.WriteLine("-------");
            
                        Carro objcarro2 = new Carro();
                        objcarro2.placa = "83ASD";
                        objcarro2.modelo = "LA FERRARI";
                        objcarro2.anoDfabrica = 2018;
                        objcarro2.Marca = "FERRARI";
                      
            
            
                        var retorno2 = getPropertyValues(objcarro2);
            
                        foreach (var item in retorno2)
                        {
                            Console.WriteLine(item.Value.ToString() + "\n");
            
            
                        }
                        Console.WriteLine(objcarro2.Freiar());
                        Console.WriteLine("-------");
            
                        Carro objcarro3 = new Carro();
                        objcarro3.placa = "8QWE";
                        objcarro3.modelo = "MUSTANG";
                        objcarro3.anoDfabrica = 2005;
                        objcarro3.Marca = "FORD";
                  
            
            
                        var retorno3 = getPropertyValues(objcarro3);
            
                  
                        foreach (var item in retorno3)
                        {
                            Console.WriteLine(item.Value.ToString() + "\n");
            
            
                        }
                        Console.WriteLine (objcarro3.Acelerar());
            
                    }
            
                    public static Dictionary <string, object> getPropertyValues(object o)
                    {
                        Dictionary  <string, object> propertyValues = new Dictionary <string, object>();
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
            
        