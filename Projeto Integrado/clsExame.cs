using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_Integrado
{
    public class clsExame
    {
        private string nomeexame;
        private DateTime dataconsulta;
        private string tipoexame;
        private string convenio;
        private float valor;
        private string nomepaciente;
        private string responsavel;
        private string diagnostico;

        public string NomeExame
        {
            get { return nomeexame; }
            set { nomeexame = value; }
        }

        public DateTime DataConsulta
        {
            get { return dataconsulta; }
            set { dataconsulta = value; }
        }

        public string TipoExame
        {
            get { return tipoexame; }
            set { tipoexame = value; }
        }

        public string Convenio
        {
            get { return convenio; }
            set { convenio = value; }
        }

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string NomePaciente
        {
            get { return nomepaciente; }
            set { nomepaciente = value; }
        }

        public string Responsavel
        {
            get { return responsavel; }
            set { responsavel = value; }
        }

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
    }
}
