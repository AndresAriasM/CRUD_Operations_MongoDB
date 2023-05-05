using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using ProgramaMongo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaMongo
{
    public class AccesoDatos
    {
        static ProgramaBeneficiariosDatabaseSettings configDB = ObtenerDBSettings();

        public static ProgramaBeneficiariosDatabaseSettings ObtenerDBSettings()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration miConfiguracion = builder.Build();

            ProgramaBeneficiariosDatabaseSettings miConfigDB = new ProgramaBeneficiariosDatabaseSettings()
            {
                ConnectionString = miConfiguracion["ProgramaBeneficiariosDatabase:ConnectionString"]!,
                DatabaseName = miConfiguracion["ProgramaBeneficiariosDatabase:DatabaseName"]!,
                DepartamentosCollectionName = miConfiguracion["ProgramaBeneficiariosDatabase:DepartamentosCollectionName"]!,
                MunicipiosCollectionName = miConfiguracion["ProgramaBeneficiariosDatabase:MunicipiosCollectionName"]!,
                ProgramasCollectionName = miConfiguracion["ProgramaBeneficiariosDatabase:ProgramasCollectionName"]!,
                BeneficiariosCollectionName = miConfiguracion["ProgramaBeneficiariosDatabase:BeneficiariosCollectionName"]!,
                SubsidiosCollectionName = miConfiguracion["ProgramaBeneficiariosDatabase:SubsidiosCollectionName"]!
            };

            return miConfigDB;
        }

        public static List<string> ObtenerListaNombresMunicipios()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.MunicipiosCollectionName;

            var listaMunicipios = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(new BsonDocument())
                .SortBy(mpio => mpio.Nombre_Municipio)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Municipio unMunicipio in listaMunicipios)
            {
                string nombreMunicipio = unMunicipio.Nombre_Municipio!;
                string nombreDepartamento = unMunicipio.Departamento!;

                string nombreValor = $"{nombreMunicipio} - {nombreDepartamento}";
                listaNombres.Add(nombreValor);
            }

            return listaNombres;
        }

        public static List<string> ObtenerListaNombresBeneficiarios()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.BeneficiariosCollectionName;

            var listaMunicipios = miDB.GetCollection<Beneficiario>(coleccionMunicipios)
                .Find(new BsonDocument())
                .SortBy(mpio => mpio.Nombre_Beneficiario)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Beneficiario unMunicipio in listaMunicipios)
            {
                string nombreMunicipio = unMunicipio.Nombre_Beneficiario!;
                string nombreDepartamento = unMunicipio.Municipio!;

                string nombreValor = $"{nombreMunicipio} - {nombreDepartamento}";
                listaNombres.Add(nombreValor);
            }

            return listaNombres;
        }
        public static List<Departamento> ObtenerListaDepartamentos()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionDepartamentos = configDB.DepartamentosCollectionName;

            var lista = miDB.GetCollection<Departamento>(coleccionDepartamentos)
                .Find(new BsonDocument())
                .SortBy(depto => depto.Nombre_Departamento)
                .ToList();

            return lista;
        }

        /*public static List<Departamento> ObtenerListaNombreProgramas1()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionDepartamentos = configDB.DepartamentosCollectionName;

            var lista = miDB.GetCollection<Departamento>(coleccionDepartamentos)
                .Find(new BsonDocument())
                .SortBy(depto => depto.Nombre_Departamento)
                .ToList();

            return lista;
        }*/

        public static List<string> ObtenerListaNombreBeneficiarios1()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.BeneficiariosCollectionName;

            var listaMunicipios = miDB.GetCollection<Beneficiario>(coleccionMunicipios)
                .Find(new BsonDocument())
                .SortBy(mpio => mpio.Nombre_Beneficiario)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Beneficiario unMunicipio in listaMunicipios)
            {
                string nombreMunicipio = unMunicipio.Nombre_Beneficiario!;
                string nombreDepartamento = unMunicipio.Municipio!;

                string nombreValor = $"{nombreMunicipio}";
                listaNombres.Add(nombreValor);
            }

            return listaNombres;
        }

        public static List<string> ObtenerListaNombresProgramas()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.ProgramasCollectionName;

            var listaMunicipios = miDB.GetCollection<Programa>(coleccionMunicipios)
                .Find(new BsonDocument())
                .SortBy(mpio => mpio.Nombre_Programa)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Programa unMunicipio in listaMunicipios)
            {
                string nombreMunicipio = unMunicipio.Nombre_Programa!;
                string nombreDepartamento = unMunicipio.Valor.ToString()!;

                string nombreValor = $"{nombreMunicipio} - {nombreDepartamento}";
                listaNombres.Add(nombreValor);
            }

            return listaNombres;
        }
        public static List<string> ObtenerListaNombresProgramas1()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.ProgramasCollectionName;

            var listaMunicipios = miDB.GetCollection<Programa>(coleccionMunicipios)
                .Find(new BsonDocument())
                .SortBy(mpio => mpio.Nombre_Programa)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Programa unMunicipio in listaMunicipios)
            {
                string nombreMunicipio = unMunicipio.Nombre_Programa!;
                string nombreDepartamento = unMunicipio.Valor.ToString()!;

                string nombreValor = $"{nombreMunicipio}";
                listaNombres.Add(nombreValor);
            }

            return listaNombres;
        }
        public static List<string> ObtenerListaNombresSubsidios()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.SubsidiosCollectionName;

            var listaMunicipios = miDB.GetCollection<Subsidio>(coleccionMunicipios)
                .Find(new BsonDocument())
                .SortBy(mpio => mpio.Id)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Subsidio unMunicipio in listaMunicipios)
            {
                string nombreMunicipio = unMunicipio.Beneficiario!;
                string nombreDepartamento = unMunicipio.Programa!;
                DateTime fecha = unMunicipio.Fecha!;
                string Id = unMunicipio.ID_Subsidio!;

                string nombreValor = $"{nombreMunicipio} ~ {nombreDepartamento} ~ {Id}";
                listaNombres.Add(nombreValor);
            }

            return listaNombres;
        }

        public static string ObtenerIdMunicipio(string nombreMunicipio, string nombreDepartamento)
        {
            Municipio municipioEncontrado = ObtenerMunicipio(nombreMunicipio, nombreDepartamento);
            return municipioEncontrado.Id!;
        }

        public static string ObtenerIdBeneficiario(string nombreMunicipio, string nombreDepartamento)
        {
            Beneficiario municipioEncontrado = ObtenerBeneficiario(nombreMunicipio, nombreDepartamento);
            return municipioEncontrado.Id!;
        }

        public static string ObtenerIdPrograma(string nombreMunicipio, int nombreDepartamento)
        {
            Programa municipioEncontrado = ObtenerPrograma(nombreMunicipio, nombreDepartamento.ToString());
            return municipioEncontrado.Id!;
        }

        public static Municipio ObtenerMunicipio(string idMunicipio)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.MunicipiosCollectionName;
            var filtroMunicipio = new BsonDocument { { "_id", new ObjectId(idMunicipio) } };

            Municipio municipioEncontrado = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(filtroMunicipio)
                .FirstOrDefault();

            return municipioEncontrado;
        }

        public static Municipio ObtenerMunicipio(string nombreMunicipio, string nombreDepartamento)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.MunicipiosCollectionName;
            var filtroMunicipio = new BsonDocument
                                    {
                                        { "Nombre_Municipio", nombreMunicipio},
                                        { "Departamento", nombreDepartamento }
                                    };

            Municipio municipioEncontrado = miDB.GetCollection<Municipio>(coleccionMunicipios)
                .Find(filtroMunicipio)
                .FirstOrDefault();

            return municipioEncontrado;
        }
        public static Beneficiario ObtenerBeneficiario(string nombreMunicipio, string nombreDepartamento)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.BeneficiariosCollectionName;
            var filtroMunicipio = new BsonDocument
                                    {
                                        { "Nombre_Beneficiario", nombreMunicipio},
                                        { "Municipio", nombreDepartamento }
                                    };

            Beneficiario municipioEncontrado = miDB.GetCollection<Beneficiario>(coleccionMunicipios)
                .Find(filtroMunicipio)
                .FirstOrDefault();

            return municipioEncontrado;
        }
        public static Beneficiario ObtenerBeneficiario(string idMunicipio)
        {

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.BeneficiariosCollectionName;
            var filtroMunicipio = new BsonDocument { { "_id", new ObjectId(idMunicipio) } };

            Beneficiario municipioEncontrado = miDB.GetCollection<Beneficiario>(coleccionMunicipios)
                .Find(filtroMunicipio)
                .FirstOrDefault();

            return municipioEncontrado;
        }
        public static Programa ObtenerPrograma(string nombreMunicipio, string nombreDepartamento)
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.ProgramasCollectionName;
            var filtroMunicipio = new BsonDocument
                                    {
                                        { "Nombre_Programa", nombreMunicipio},
                                        { "Valor", nombreDepartamento }
                                    };

            Programa municipioEncontrado = miDB.GetCollection<Programa>(coleccionMunicipios)
                .Find(filtroMunicipio)
                .FirstOrDefault();

            return municipioEncontrado;
        }

        public static bool InsertarMunicipio(Municipio unMunicipio, out string mensajeInsercion)
        {
            mensajeInsercion = string.Empty;

            //Primero se debe validar que no exista ya un municipio para ese departamento con ese nombre
            Municipio municipioExistente = ObtenerMunicipio(unMunicipio.Nombre_Municipio!, unMunicipio.Departamento!);

            if (municipioExistente != null)
            {
                mensajeInsercion = $"Ya existe un municipio con el nombre {unMunicipio.Nombre_Municipio} " +
                    $"para el departamento {unMunicipio.Departamento}";
                return false;
            }

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.MunicipiosCollectionName;

            var miColeccion = miDB.GetCollection<Municipio>(coleccionMunicipios);
            miColeccion.InsertOne(unMunicipio);

            //Necesitamos corroborar que la inserción fue exitosa
            string? idMunicipio = ObtenerIdMunicipio(unMunicipio.Nombre_Municipio!, unMunicipio.Departamento!);

            if (string.IsNullOrEmpty(idMunicipio))
            {
                mensajeInsercion = "Fallo al realizar la inserción.";
                return false;
            }
            else
            {
                mensajeInsercion = $"Inserción exitosa para el municipio {unMunicipio.Nombre_Municipio} en el departamento {unMunicipio.Departamento}";
                return true;
            }
        }

        public static bool InsertarBeneficiario(Beneficiario unMunicipio, out string mensajeInsercion)
        {
            mensajeInsercion = string.Empty;

            //Primero se debe validar que no exista ya un municipio para ese departamento con ese nombre
            Beneficiario municipioExistente = ObtenerBeneficiario(unMunicipio.Nombre_Beneficiario!, unMunicipio.Municipio!);

            if (municipioExistente != null)
            {
                mensajeInsercion = $"Ya existe un beneficiario con el nombre {unMunicipio.Nombre_Beneficiario} " +
                    $"para el municipio {unMunicipio.Municipio}";
                return false;
            }

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.BeneficiariosCollectionName;

            var miColeccion = miDB.GetCollection<Beneficiario>(coleccionMunicipios);
            miColeccion.InsertOne(unMunicipio);

            //Necesitamos corroborar que la inserción fue exitosa
            string? idMunicipio = ObtenerIdBeneficiario(unMunicipio.Nombre_Beneficiario!, unMunicipio.Municipio!);

            if (string.IsNullOrEmpty(idMunicipio))
            {
                mensajeInsercion = "Fallo al realizar la inserción.";
                return false;
            }
            else
            {
                mensajeInsercion = $"Inserción exitosa para el municipio {unMunicipio.Nombre_Beneficiario} en el departamento {unMunicipio.Municipio}";
                return true;
            }
        }

        public static bool InsertarPrograma(Programa unMunicipio, out string mensajeInsercion)
        {
            mensajeInsercion = string.Empty;

            //Primero se debe validar que no exista ya un municipio para ese departamento con ese nombre
            Programa municipioExistente = ObtenerPrograma(unMunicipio.Nombre_Programa!, unMunicipio.Valor.ToString()!);

            if (municipioExistente != null)
            {
                mensajeInsercion = $"Ya existe un municipio con el nombre {unMunicipio.Nombre_Programa} " +
                    $"para el departamento {unMunicipio.Valor}";
                return false;
            }

            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionMunicipios = configDB.MunicipiosCollectionName;

            var miColeccion = miDB.GetCollection<Programa>(coleccionMunicipios);
            miColeccion.InsertOne(unMunicipio!);

            //Necesitamos corroborar que la inserción fue exitosa
            string? idMunicipio = ObtenerIdPrograma(unMunicipio.Nombre_Programa!, unMunicipio.Valor!);

            if (string.IsNullOrEmpty(idMunicipio))
            {
                mensajeInsercion = "Fallo al realizar la inserción.";
                return false;
            }
            else
            {
                mensajeInsercion = $"Inserción exitosa para el municipio {unMunicipio.Nombre_Programa} en el departamento {unMunicipio.Valor}";
                return true;
            }
        }

        public static List<string> ObtenerListaNombresDepartamentos()
        {
            var clienteDB = new MongoClient(configDB.ConnectionString);
            var miDB = clienteDB.GetDatabase(configDB.DatabaseName);
            var coleccionDepartamentos = configDB.DepartamentosCollectionName;

            var listaDepartamentos = miDB.GetCollection<Departamento>(coleccionDepartamentos)
                .Find(new BsonDocument())
                .SortBy(dpto => dpto.Nombre_Departamento)
                .ToList();

            List<string> listaNombres = new List<string>();

            foreach (Departamento unDepartamento in listaDepartamentos)
                listaNombres.Add(unDepartamento.Nombre_Departamento!);

            return listaNombres;
        }

       
        
       
    }
}
