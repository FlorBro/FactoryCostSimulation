using ClassPros;
using System;


Machine[] machines;                                                                                              /// déclaration du tableau machines contenant des Machine
machines = new Machine[5];                                                                                      /// instanciation du tableau machines d'une taille de 5
machines[0] = new Machine { Nom = "U66", Temps = 20, Couts = 10 };
machines[1] = new Machine { Nom = "U126", Temps = 15, Couts = 20 };
machines[2] = new Machine { Nom = "U12", Temps = 20, Couts = 20 };
machines[3] = new Machine { Nom = "U256", Temps = 5, Couts = 50 };
machines[4] = new Machine { Nom = "U42", Temps = 35, Couts = 5 };
List<Machine> machinesChoisies = new List<Machine>();                                                         /// instancie une Liste contenant des Machines
for (int i = 0; i < machines.Length; i++)                                                                    /// affiche chaque nom dans la console
{
    machines[i].ListeUnité();
}
void ChoixUnité()
{
    Console.WriteLine("Entrez le nombre d'unité souhaité, Maximum:" + machines.Length);
    string a = Console.ReadLine();
    var aI = Int32.Parse(a);
    if (aI <= machines.Length)                                                                             /// initialise aI correspondant au nombre de machine voulue 
    {
        Console.WriteLine("Vous avez choisi:" + aI + " machines");
        Console.WriteLine("Veuillez entrer le nom des machines concerné, maximum:" + aI);
        for (int i = 0; i < aI; i++)                                                                        /// pour le nombre de machine 
        {
            string machineNom = Console.ReadLine();
            Machine machineChoisie = Array.Find(machines, Machine => Machine.Nom == machineNom.ToUpper()); /// on compare les entrée utilisateurs au entré du tableau pour trouver un correspondance

            if (machineChoisie != null)                                                                   /// si une valeur est commune
            {
                machinesChoisies.Add(machineChoisie);                                                    /// Ajouter la machine saisie à la liste 

                Console.WriteLine($"Machine choisie: {machineChoisie.Nom}, Temps: {machineChoisie.Temps}, Coûts: {machineChoisie.Couts}"); ///affiche les caractéristique de la machine

            }

            else
            {
                Console.WriteLine("Erreur: Machine avec le nom " + machineNom + " non trouvée.");
            }
        }
    }
    else
    {
        Console.WriteLine("Erreur: Le nombre d'Unité choisi dépasse le nombre de machine disponible");
    }
    AfficherListeMachinesChoisies();
}
void AfficherListeMachinesChoisies()
{
    Console.WriteLine("Liste des machines choisies :");

    int sommeCouts = 0;
    int sommeTemps = 0;
    foreach (var machine in machinesChoisies)
    {
        Console.Write(machine.Nom + " ");
        sommeCouts += machine.Couts;
        sommeTemps += machine.Temps;
    }

    Console.WriteLine("coûts par heures : " + sommeCouts + "00 euro/heures");
    Console.WriteLine("Temps totale: " + sommeTemps + " heures");
    Console.WriteLine("coûts finale: " + sommeTemps * sommeCouts * 100 + " euros");
}


ChoixUnité();