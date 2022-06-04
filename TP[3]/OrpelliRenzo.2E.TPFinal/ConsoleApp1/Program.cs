using System;
using System.Collections.Generic;
using Entidades;
using Entidades.GestorDeArchivos;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancio un Cliente
            Cliente empresa = new ClienteEmpresa(Cliente.categoriaCliente.Premium, "Andreani", "123123123123", "lobos 123");
            Cliente empresa2 = new ClienteEmpresa(Cliente.categoriaCliente.Premium, "oca", "312312", "lobos 124");
            //Instancio Un Servicio
            Servicio servico = new Servicio(20000, Servicio.dificultadVirus.Dificil, Servicio.tipoVirus.Adware, new System.DateTime(2020, 03, 23));

            //Instancio una admanistracion
            AdministracionEmpresa administracion = new AdministracionEmpresa(20);
            
            
            //instancio un archivo txt
            ArchivoTxt archivo = new ArchivoTxt();


            Serializador<List<Cliente>> serializer = new Serializador<List<Cliente>>(GestorDeArchivo.ETipo.ClienteXML);

            //List<ClienteEmpresa> lista = new List<ClienteEmpresa>();
            //lista.Add(empresa);
            //lista.Add(empresa2);
            // si agrego el servicio, escribo un archivo txt con el cliente y el servicio
            if (administracion + empresa && administracion + empresa2)
            {
                // crea un archivo de tipo txt en el path ConsoleApp1\bin\Debug\net5.0\ArchivoClientes\ClienteTXT
                //archivo.Escribir("cliente.txt", empresa.MostrarCliente());

                //CREA UN ARHICOV XML 
                Console.WriteLine(serializer.Escribir("clientes2.xml", administracion.ListaClientes));


                // lee el archivo creeado de tipo txt en el path ConsoleApp1\bin\Debug\net5.0\ArchivoClientes\ClienteTXT
                //Console.WriteLine(archivo.Leer("cliente.txt"));

                Console.WriteLine("Cliente creado Exitosamente");
            }


        }
    }
}
