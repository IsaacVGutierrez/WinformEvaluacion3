using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformEvaluacion3.modelo;

namespace WinformEvaluacion3.datos
{
    public class Usuario
    {
        List<Usuariomodel> lista = new List<Usuariomodel>();

        public void Guardar(Usuariomodel modelo)
        {

            lista.Add(modelo);
        }
            public List<Usuariomodel> Consultar() {

            return lista;
        
        }

    }
}
