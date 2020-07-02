using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRobertoVergaraC
{
    public class Equipo
    {
        private List<Player> players;
        private Coach coach;
        private Doctor doc;
        private string teamName;
        private bool type; //True: Nacional, False: Liga
        private string nacionality;

        public List<Player> Players { get => players; set => players = value; }
        public Coach Coach { get => coach; set => coach = value; }
        public Doctor Doc { get => doc; set => doc = value; }
        public string TeamName { get => teamName; set => teamName = value; }
        public bool Type { get => type; set => type = value; }
        public string Nacionality { get => nacionality; set => nacionality = value; }

        public Equipo(List<Player> players, Coach coach, Doctor doc, string teamName, bool type)
        {
            this.players = players;
            this.coach = coach;
            this.doc = doc;
            this.teamName = teamName;
            this.type = type;
            if (type)
            {
                Console.WriteLine("Seleccione la nacionalidad de el equipo: ");
                this.nacionality = Console.ReadLine();
                bool check = CheckTeamNacionality();
                if (!check)
                {
                    Console.WriteLine("El equipo inscrito tiene jugadores que no tienen la misma nacionalidad, por lo que su equipo sera considerado de tipo LIGA");
                    Type = false;
                }
            }
        }

        public bool CheckTeamNacionality()
        {
            //Solo se revisan jugadores, ya que existe la posibilidad que un equipo nacional sea entrenado por una persona de otra nacionalidad, lo mismo con los médicos
            
            IEnumerable<Player> nacionality = from p in players
                                              where p.Nacionality.ToUpper() == Nacionality.ToUpper()
                                              select p;
            
            nacionality.ToList();
            if (nacionality.Count() == 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TeamInformation()
        {
            Console.WriteLine("-----Información Equipo-----");
            Console.WriteLine("Nombre: "+this.teamName);
            if (type == true)
                Console.WriteLine("Tipo: NACIONAL ("+this.nacionality.ToUpper()+")");
            else
                Console.WriteLine("Tipo: LIGA");

            Console.WriteLine("\n-----Lista Jugadores-----");
            foreach (Player p in players)
            {
                p.Show();
                Console.WriteLine();
            }
            Console.WriteLine("\n-----Entrenador-----");
            coach.Show();

            Console.WriteLine("\n-----Médico-----");
            doc.Show();
        }
    }
}
