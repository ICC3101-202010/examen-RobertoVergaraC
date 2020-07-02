using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRobertoVergaraC
{
    public class Game
    {
        private Equipo equipo1;
        private Equipo equipo2;
        private int duración;
        private bool type; //True: Nacional, False: Liga
        private string result;

        public int Duración { get => duración; set => duración = value; }
        public bool Type { get => type; set => type = value; }
        public Equipo Equipo1 { get => equipo1; set => equipo1 = value; }
        public Equipo Equipo2 { get => equipo2; set => equipo2 = value; }
        public string Result { get => result; set => result = value; }

        public Game(Equipo e1, Equipo e2, int duracion)
        {
            this.equipo1 = e1;
            this.equipo2 = e2;
            this.duración = duracion;
        }


        public void GameResult(int probabilidadEquipo1, int ProbabilidadEquipo2)
        {
            //NotImplementedYet
            //Calcularía el Resultado por medio de las probabilidades de cada equipo
        }

        public void Match()
        {
            //Método de lo que pasa en el partido, ya sea ocurren lesiones, definir que tipo de partido es, etc...

            //...

            //Suponiendo que un jugador se lesiona
            Equipo1.Players[5].Injuring(Equipo1, this); //Suponemos que el jugador 6 del equipo 1 se lesiona. Este llama al método que "lo lesiona", entregandole la información del equipo para tener las opciones pertinentes para hacer el cambio

            GameResult(50, 50); //ponemos cualquier probabilidad
        }

    }
}
