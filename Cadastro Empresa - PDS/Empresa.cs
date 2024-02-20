using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Empresa___PDS
{
    public class Empresa
    {
        
            public string Cnpj { get; set; }
            public string Razao { get; set; }
            public string Nfant { get; set; }
            public string Situacao { get; set; }
            public string Regime { get; set; }
            public string DatadeInicio { get; set; }
            public string Telefone { get; set; }
            public double Capital { get; set; }
            public string Estado { get; set; }
            public string Cidade { get; set; }
            public string Bairro { get; set; }
            public string Rua { get; set; }
            public double Numero { get; set; }
            public string Tipo { get; set; }
            public string Porte { get; set; }
            public string Natureza { get; set; }
            public string NomeProp { get; set; }
            public string CpfProp { get; set; }

        public Empresa(string cnpj, string razao, string nfant, string situacao, string regime, string datadeInicio, string telefone, double capital, string estado, string cidade, string bairro, string rua, double numero, string tipo, string porte, string natureza, string nomeProp, string cpfProp)
        {
            Cnpj = cnpj;
            Razao = razao;
            Nfant = nfant;
            Situacao = situacao;
            Regime = regime;
            DatadeInicio = datadeInicio;
            Telefone = telefone;
            Capital = capital;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            Tipo = tipo;
            Porte = porte;
            Natureza = natureza;
            NomeProp = nomeProp;
            CpfProp = cpfProp;
        }
    }

}
