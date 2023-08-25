using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Estacionamento
    {
        public List<string> cars = new List<string>();
        string car;
        float time;
        float value;
        int escolha;
        int count;
        int indexPlate;
        int auxCar;
        string carAux;
        //int index;
        

        public Estacionamento()
        {
            
        }

        public void Parking(List<string> cars)
        {
            do {
                Console.WriteLine("What do you want?");
                Console.WriteLine("1 - Register a vehicle");
                Console.WriteLine("2 - Remove a vehicle");
                Console.WriteLine("3 - List the veicles");
                Console.WriteLine("4 - exit");
                escolha = Int16.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine(" Type de vehicle: \n");
                        cars.Add(Console.ReadLine().ToString());
                        break;

                    case 2:
                        Console.WriteLine("Which vehicle do you want remove?");
                        foreach (string cart in cars)
                        {
                            Console.WriteLine($"To remove {cart} type index {count}");
                            //index = count;
                            count++;
                        }
                        count = 0;


                        Console.WriteLine("\nEnter the car index or the license plate");
                        car = Console.ReadLine().ToString();
                        indexPlate = cars.FindIndex(name => name == car);
                        

                        try
                        {
                            if (string.Equals(cars[indexPlate], car, StringComparison.OrdinalIgnoreCase))
                            {
                                carAux = car;
                                cars.Remove(car);
                            }
                            else
                            {
                                auxCar = Int16.Parse(car);
                                carAux = cars[auxCar];
                                cars.RemoveAt(Int16.Parse(car));
                                //cars.RemoveAt(indexPlate);
                            }
                        }
                        catch
                        {
                            auxCar = Int16.Parse(car);
                            carAux = cars[auxCar];
                            cars.RemoveAt(Int16.Parse(car));
                            //cars.RemoveAt(indexPlate);
                        }

                        Console.WriteLine("\n How much time does the car stayed in the parking?");
                        time = Int16.Parse(Console.ReadLine());
                        value = time * 2;

                        Console.WriteLine($"\n The removed car was {carAux} and total cost was {value}");

                        Console.WriteLine($"\n Cars in the parking\n");
                        foreach (string cart in cars)
                        {
                            Console.WriteLine($"-- {cart} ");
                        }

                        car = "noOne";

                        break;

                    case 3:
                        foreach (string cart in cars)
                        {
                            Console.WriteLine($"{cart} ");
                        }
                        break;
                    case 4:
                        break;
                }

                Console.WriteLine("\n\n Press any key to coninue");
                Console.ReadKey();
                Console.Clear();
               } while (escolha != 4);
        }
    }
}
