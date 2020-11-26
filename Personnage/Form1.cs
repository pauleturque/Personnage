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
            public Personnage(string login) 
            {
                this.login = login;
                Random NbAlea = new Random();
                this.vie = NbAlea.Next(0, 5);
            }

            /**
             * getter sur vie
             */
            public int getVie()
            {
                return vie;

            }

            /**
             * Setter sur vie
             */
            public void setVie(int vie)
            {
                this.vie = vie;
            }

            /**
             * getter sur login
             */
            public string getLogin()
            {
                return login;
            }



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



        /**
         * Enoncé de l'exercice : 
         * Création d'un tableau d'objets de type Personnage
         * A chaque saisie d'un nouveau login, un perso est créé dans le tableau
         * Afficher sa vie et un message personnalisé avec son login et sa vie ou de 'est mort'
         * Il est automatiquement sélectionné dans la liste
         * Le personnage qui a le plus de vie est automatiquement affiché en bas
         * Possibilité de changer la valeur vie via un NumberUpDown
         * Mise à jour auto
         * Nouvelle recherche du perso avec le max de vie 
         */

        // Création du tableau de personnages
        private Personnage[] lesPersonnages = new Personnage[100];
        private int nbPersos = 0;

        /**
         * Affichage du login suivi de la vie ou de est mort
         */
        private void AfficheMsgPerso(Personnage unPersonnage)
        { 
            if(unPersonnage.getVie() == 0)
            {
                txtEtatPerso.Text = unPersonnage.getLogin() + " est mort :'(";
            }
            else
            {
                txtEtatPerso.Text = unPersonnage.getLogin() + " : " + unPersonnage.getVie();
            }
        }

        /**
         * mise à jour de la liste des personnages
         */

        private void majListePersos(int ligneActive)
        {
            // Vider la liste
            listPersos.Items.Clear();
            // Remplir avec le tableau de personnages
            for (int i = 0; i < nbPersos; i++)
            {
                listPersos.Items.Add(lesPersonnages[i].getLogin() + " : " + lesPersonnages[i].getVie());
            }
            // Positionnement sur la ligne active
            if (listPersos.Items.Count > 0 && ligneActive < nbPersos)
            {
                listPersos.SelectedIndex = ligneActive;
            }
        }

        private void persoMaxVie()
        {
            //Contrôle s'il y a au moins un personnage
            if (nbPersos == 0)
            {
                txtBoxMaxVie.Text = "";
            }
            else
            {
                // recherche de l'indice de la vie max
                int max = 0;
                // boucle 
                for (int i = 1; i < nbPersos; i++)
                {
                    if (lesPersonnages[i].getVie() > lesPersonnages[max].getVie())
                    {
                        max = i;
                    }
                }
                txtBoxMaxVie.Text = lesPersonnages[max].getLogin();
            }
        }

        /** 
         * Changement de vie
         */
        private void changeViePerso(int index)
        {
            // Affichage du message perso
            AfficheMsgPerso(lesPersonnages[index]);
            // Mise à jour de la liste des personnages
            majListePersos(index);
            // Affichage du login de la vie max
            persoMaxVie();
        }

        /**
         * Touche appuyée sur txtLogin
         * Contrôle de la validation
         * Création d'un nouveau personnage
         */
        private void txtBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Contrôle sur validation
            if (e.KeyChar == (char)Keys.Enter)
            {
                //incrémentation du nombre de personnages
                nbPersos++;
                // Création du personnage
                Personnage unPersonnage = new Personnage(txtBoxLogin.Text);
                // Ajout du personnage dans le tableau
                lesPersonnages[nbPersos - 1] = unPersonnage;
                // Mise à jour des affichages
                changeViePerso(nbPersos - 1);
                // Vider la zone de saisie et se repositionner dessus
                txtBoxLogin.Text = "";
                txtBoxLogin.Focus();
            }
            
        }

        /** 
         * Sélection d'une ligne dans la liste des personnages
         */
        private void listPersos_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = lesPersonnages[listPersos.SelectedIndex].getVie();

        }

        /** 
         * Changement de la vie sur up-down
         */
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (listPersos.SelectedIndex >= 0)
            {
                // Récupération du personnage sélectionné
                Personnage unPersonnage = lesPersonnages[listPersos.SelectedIndex];
                // Modification de la vie 
                unPersonnage.setVie((int)numericUpDown1.Value);
                changeViePerso(listPersos.SelectedIndex);
            }
        }
    }
}

