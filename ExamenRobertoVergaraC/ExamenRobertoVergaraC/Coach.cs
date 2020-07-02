using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRobertoVergaraC
{
    public class Coach : Person
    {
        private int tacticalPoints;

        public int TacticalPoints { get => tacticalPoints; set => tacticalPoints = value; }

        public Coach(string name, int age, string nacionality, double salary,int tacticalPoints) : base (name,age,nacionality,salary)
        {
            this.tacticalPoints = tacticalPoints;
        }

        public override string Info()
        {
            return "Name: " + this.Name + "\nAge: " + this.age + "\nNacionalidad: " + this.nacionality.ToUpper() + "\nProfesión: Entrenador";
        }

        public bool ChangePlayer(Player player1,Player player2)
        {
            //player1 sale
            //player2 entra
            return true;
        }

        public void OnInjured(object source, TeamEventArgs args)
        {
            //Se recibe la Información que un jugador se lesionó, por lo que se implementa el método change Player
            // TeamEventArgs contiene la información del equipo
            ChangePlayer(args.Player, args.Team.Players.Last()); //Por ejemplo el último jugador del equipo
            //Sabemos que equipo es, por lo que basta hacer el cambio
            //Además Args tiene la información de Game, por lo que puede meterse dentro del equipo y cambiar la información.
        }
    }
}
