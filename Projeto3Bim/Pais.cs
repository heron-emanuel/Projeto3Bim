using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Bim
{
    class Pais
    {
        private string nome;
        private double area;
        private ObservableCollection<Estado> estados;

        public Pais(string nome, double area)
        {
            this.nome = nome;
            this.area = area;
            this.estados = new ObservableCollection<Estado>();
        }

        public void Inserir(Estado e)
        {
            estados.Add(e);
        }

        public ObservableCollection<Estado> Listar()
        {
            return estados;
        }

        public int Populacao()
        {
            return estados.Select(e => e.GetPopulacao()).Sum();
        }

        public override string ToString()
        {
            return $"Nome: {nome} - Área: {area} km² - População: {Populacao()}";
        }
    }
}
