using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRobertoVergaraC
{
    public class TeamEventArgs : EventArgs
    {
        private Equipo team;
        private Player player;
        private Game game;

        public Equipo Team { get => team; set => team = value; }
        public Player Player { get => player; set => player = value; }
        public Game Game { get => game; set => game = value; }
    }
}
