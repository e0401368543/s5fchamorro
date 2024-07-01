
using s5fchamorro.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s5fchamorro.Utils
{
    
    public class PersonRepository

    {

        string _dbPath;
        private SQLiteConnection conn;
        public string StatusMessage {  get; set; }  
        private void Init()
        {
            if(conn is not null) 
                return;
            conn = new(_dbPath);
            conn.CreateTable<Persona>();
        }
        public PersonRepository(string dbPath)
        {

        _dbPath = dbPath;
        }
        public void AddNewPerson(string nombre)
        {
            int result = 0;
            try
            {
                Init();
                if (string.IsNullOrEmpty(nombre))
                    throw new Exception("nombre Requerido");
                Persona persona = new() { Nombre = nombre };
                result = conn.Insert(persona);
                StatusMessage = string.Format("{0} record(s) added (nombre: {1}", result, nombre);

            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error {1}", nombre, ex.Message);
            }
        }


        public List<Persona> GetAllPeople()
        {
            try
            {
                Init();
                return conn.Table<Persona>().ToList();

            }
            catch (Exception ex)
            {


                StatusMessage= string.Format("Error al obtener el dato {0}", ex.Message);
            }
            return new List<Persona>();
        }

        public void DeletePerson(Persona person)
        {
            Init();
            conn.Delete(person);
        }

        public void updatePerson(Persona persona)
        {
            conn.Update(persona);
        }






    }
}
