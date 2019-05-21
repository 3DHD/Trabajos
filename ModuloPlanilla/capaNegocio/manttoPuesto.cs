using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class manttoPuesto
    {
        bdConex test = new bdConex();

        int idPuesto;
        String puesto, area;
        public DataTable dt = new DataTable();


        public String Area
        {
            get { return area; }
            set { area = value; }
        }

        public String Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public int IdPuesto
        {
            get { return idPuesto; }
            set { idPuesto = value; }
        }

        /*
        public void insertarPuesto()
        {
            try
            {
                String insert = "insert into AREA(AREA, DESCRIPCION) values('" + area + "','" + descripcion + "');";

                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void deleteArea()
        {
            try
            {
                String delete = "delete from AREA where AREA = '" + area + "'";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {
            }
        }

        public void updateArea()
        {
            try
            {
                String update = "update AREA set DESCRIPCION='" + descripcion + "' where AREA='" + area + "'";

                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {
            }
        }
        */

        public void mostrarPuesto()
        {
            try
            {
                String consulta = "select * from AREA";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {
            }
        }
    }
}
