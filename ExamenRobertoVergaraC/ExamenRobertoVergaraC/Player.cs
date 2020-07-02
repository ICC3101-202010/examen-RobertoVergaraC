using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRobertoVergaraC
{
    public class Player : Person
    {
        private int atackPoints;
        private int defendPoints;
        private int shirtNumber;
        private bool goalkeeper;
        private bool injury = false;

        public int AtackPoints { get => atackPoints; set => atackPoints = value; }
        public int DefendPoints { get => defendPoints; set => defendPoints = value; }
        public int ShirtNumber { get => shirtNumber; set => shirtNumber = value; }
        public bool Goalkeeper { get => goalkeeper; set => goalkeeper = value; }
        public bool Injury { get => injury; set => injury = value; }

        public Player(string name, int age, string nacionality, double salary,int atackPoints, int defendPoints, byte shirtNumber, bool goalkeeper) : base(name,age,nacionality, salary)
        {
            this.atackPoints = atackPoints;
            this.defendPoints = defendPoints;
            this.shirtNumber = shirtNumber;
            this.goalkeeper = goalkeeper;
        }

        public override string Info()
        {
            return "Name: " + this.Name + "\nAge: " + this.age + "\nNacionalidad: " + this.nacionality.ToUpper() + "\nProfesión: Jugador de Fútbol" + "\nNúmero de Camiseta: " + this.shirtNumber;
        }

        public event EventHandler<TeamEventArgs> Injured;

        public void Injuring(Equipo equipo, Game game)
        {
            this.injury = true;

            OnInjured(equipo, game);
        }

        protected virtual void OnInjured(Equipo equipo, Game game)
        {
            if (Injured != null)
                Injured(this, new TeamEventArgs() { Team = equipo, Player=this , Game=game});
        }
    }
}
