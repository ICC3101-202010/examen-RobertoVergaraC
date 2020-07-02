using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRobertoVergaraC
{
    public class Doctor : Person
    {
        private int experiencePoints;

        public int ExperiencePoints { get => experiencePoints; set => experiencePoints = value; }

        public Doctor(string name, int age, string nacionality, double salary, int experiencePoints) : base(name, age, nacionality, salary)
        {
            this.experiencePoints = experiencePoints;
        }

        public override string Info()
        {
            return "Name: " + this.Name + "\nAge: " + this.age + "\nNacionalidad: " + this.nacionality + "\nProfesión: Médico";
        }

        public bool Evaluate(Player player)
        {
            //retorna true si player esta lesionado
            //retorna false si player esta bien
            return true;
        }

        public bool Cure(Player player)
        {
            bool a = Evaluate(player);
            if (a == true)
            {
                //SANA EL JUGADOR
                return true;
            }
            else
            {
                //NO HACE NADA YA QUE EL JUGADOR ESTA SANO
                return false;
            }
        }
    }
}
