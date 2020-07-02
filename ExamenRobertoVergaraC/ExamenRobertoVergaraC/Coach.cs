using System;
using System.Collections.Generic;
using System.Linq;
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
            return "Name: " + this.Name + "\nAge: " + this.age + "\nNacionalidad: " + this.nacionality + "\nProfesión: Entrenador";
        }

        public bool ChangePlayer(Player player1,Player player2)
        {
            //player1 sale
            //player2 entra
            return true;
        }
    }
}
