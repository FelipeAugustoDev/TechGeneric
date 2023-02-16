using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGeneric
{
    class Funcionarios
    {
        private string _nome;
        private string _endereco;      
        private string _sexo;
        private double _salario;

        public Funcionarios(string Nome, string Endereco, string Sexo, double Salario) 
        {
            this._nome = Nome;
            this._endereco = Endereco;
            this._sexo = Sexo;
            this._salario = Salario;
        }
    }
}
