using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /**
         * Classe donnée en début d'exercice
         */
        public class Personnage
        {
            private string login;
            private int vie;
            /**
             * Constructeur
             * Valorise le login et initialise la vie à 10
             */
            public Personnage(string login) { }
            /** Permet de faire avancer le joueur
             * retourne faux s'il a été bloqué par un mur
             */
            public bool avancer(int distance) { return true; }

            /** Permet de faire vancer le personnage d'un quart de tour
             * vers la gauche si direction = 'G'
             * vers la dorite si direction = 'D'
             */

            public void tourner(char direction) { }

        }

        /**
         * Enoncé de l'exercice : 
         * Ecrire le code permettant au personnage dont le login est "Emds"
         * D'être créé, puis le faire vanacer de 100 pas, un à la fois
         * En le faisant tourner alternativement à gauche et droite
         * S'il est bloqué par un mur
         */

        /**
         * Clic sur bouton créer
         * Crée le personnnage et le fait avancer
         */
    private void btnCreer_Click(object sender, EventArgs e)
        {
            // création du personnage
            Personnage perso;
            perso = new Personnage("Emds");

            // Déclaration pour tourner
            bool gauche = true; 

            // Boucle pour faire avancer le personnage
            int k = 0;
            while (k < 100)
            {
                //tente d'avancer
                if(perso.avancer(1)) 
                {
                    // Le personnage a pu avancer
                    k++;
                }
                else 
                { 
                    // bloqué par un mur
                    if(gauche)
                    {
                        perso.tourner('G');
                    }
                    else
                    {
                        perso.tourner('D');
                    }
                    // Changer de direction alternativement
                    gauche = !gauche;
                }

            }
        }
    }
}
