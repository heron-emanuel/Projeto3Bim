using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Bim
{
    class Estado
    {
        private string nome;
        private string sigla;
        private int populacao;

        public Estado(string nome, string sigla, int pop)
        {
            this.nome = nome;
            this.sigla = sigla;
            this.populacao = pop;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetSigla()
        {
            return sigla;
        }

        public int GetPopulacao()
        {
            return populacao;
        }

        public override string ToString()
        {
            return $"Nome: {nome} - Sigla: {sigla} - População: {populacao}";
        }
    }
}
