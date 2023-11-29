using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    internal class Musica
    {
        string artista;
        string nomemusica;
        int genero;
        int anolancamento;
        string feat;
        int album;

        public string Artista { get => artista; set => artista = value; }
        public string Nomemusica { get => nomemusica; set => nomemusica = value; }
        public int Genero { get => genero; set => genero = value; }
        public int Anolancamento { get => anolancamento; set => anolancamento = value; }
        public string Feat { get => feat; set => feat = value; }
        public int Album { get => album; set => album = value; }
    }
}
