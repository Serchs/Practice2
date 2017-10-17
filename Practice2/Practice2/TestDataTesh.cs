using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Practice2
{
   public class TestDataTesh
    {
        int id;
        string Name;
        string Ape;
        string Direc;
        int Tel;
        string Carr;
        string Sem;
        int Matr;
        string Ema;
        string GH;


        [PrimaryKey]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Apellido
        { 
            get { return Ape; }
            set { Ape = value; }
        }
        public string Direccion
        {
            get { return Direc; }
            set { Direc = value; }
        }

        public int  Telefono 
        {
            get { return Tel; }
            set { Tel = value; }
        }

        public string Carrera
        {
            get { return Carr; }
            set { Carr = value; }
        }

        public string Semestre
        {
            get { return Sem; }
            set { Sem = value; }
        }
        public int Matricula
        {
            get { return Matr; }
            set { Matr = value; }
        }
        public string Email
        {
            get { return Ema; }
            set { Ema = value; }
        }

        public string GitHub
        {
            get { return GH; }
            set { GH = value; }
        }

    }
}
