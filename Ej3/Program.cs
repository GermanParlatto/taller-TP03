using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            int op, tipo,cuotas, año, mes,dia;
            double salario, monto;
            String nombre, apellido;
            
            DateTime fechaNacimiento, fechaIngreso;

            do
            {
                Console.Clear();
                Console.WriteLine("Selecciones la accion:");
                Console.WriteLine("1---REGISTRAR CLIENTE");
                Console.WriteLine("2---VERIFICAR SOLICITUD");
                Console.WriteLine("3---MODIFICAR TIPO DE CLIENTE");
                Console.WriteLine("4---salir"); Console.WriteLine("");
                Console.Write("OPCION: ");
                op = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese las datos de cliente");
                        Console.Write("Nombre: "); nombre = Console.ReadLine();
                        Console.Write("Apellido: "); apellido = Console.ReadLine();
                        Console.WriteLine("Facha de nacimiento ");
                        Console.Write("Año: "); año = Convert.ToInt32(Console.ReadLine()); 
                        Console.Write("Mes: "); mes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Dia: "); dia= Convert.ToInt32(Console.ReadLine());  
                        fechaNacimiento = new DateTime(año, mes, dia);
                        Console.Write("Salario: "); salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Facha de inicio laboral ");
                        Console.Write("Año: "); año = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Mes: "); mes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Dia: "); dia = Convert.ToInt32(Console.ReadLine());
                        fechaIngreso = new DateTime(año, mes, dia);
                        fachada.RegistrarCliente(nombre, apellido, fechaNacimiento, salario, fechaIngreso);
                        Console.ReadKey();
                        break;
                    case 2:
                        if (fachada.MostrarCliente())
                        {
                            Console.WriteLine("Ingrese datos de solicitud");
                            Console.Write("Monto: "); monto = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Cuotas: "); cuotas = Convert.ToInt32(Console.ReadLine());
                            fachada.ValidarSolicitud(monto, cuotas);
                        }
                        
                        Console.ReadKey();
                        break;
                    case 3:
                        if (fachada.MostrarCliente())
                        {
                            Console.WriteLine("Ingrese la opcion");
                            Console.WriteLine("1-Tipo CLIENTE, 2-Tipo CLIENTE GOLD, 3-Tipo CLIENTE PREMIUM");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    fachada.ModificarTipoCliente(TipoCliente.Cliente);
                                    break;
                                case "2":
                                    fachada.ModificarTipoCliente(TipoCliente.ClienteGold);
                                    break;
                                case "3":
                                    fachada.ModificarTipoCliente(TipoCliente.ClientePremium);
                                    break;
                            }                     
                            
                        }

                        Console.ReadKey();
                        break;

                    default: break;

                }
            } while (op != 4);
        }
    }
}
