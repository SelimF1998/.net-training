// See https://aka.ms/new-console-template for more information
class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Compte 1: ");
            string cin, nom, prenom, tel;
            Console.Out.Write("Donner Le CIN: ");
            cin = Console.In.ReadLine();
            Console.Out.Write("Donner Le Nom: ");
            nom = Console.In.ReadLine();
            Console.Out.Write("Donner Le Prénom: ");
            prenom = Console.In.ReadLine();
            Console.Out.Write("Donner Le numéro de télephone: ");
            tel = Console.In.ReadLine();
 
            Compte C1 = new Compte(new Client(cin, nom, prenom, tel));
            Console.Out.WriteLine("Détails du compte: ");
            C1.Afficher();
 
            double montant;
            Console.Out.Write("Donner le montant à déposer: ");
            montant = double.Parse(Console.In.ReadLine());
            C1.Crediter(montant);
            C1.Afficher();
 
            Console.Out.Write("Donner le montant à retirer: ");
            montant = double.Parse(Console.In.ReadLine());
            C1.Debiter(montant);
            C1.Afficher();

            Console.Out.WriteLine("\n\nCompte 2: ");
            Console.Out.Write("Donner Le CIN: ");
            cin = Console.In.ReadLine();
            Console.Out.Write("Donner Le Nom: ");
            nom = Console.In.ReadLine();
            Console.Out.Write("Donner Le Prénom: ");
            prenom = Console.In.ReadLine();
            Console.Out.Write("Donner Le numéro de télephone: ");
            tel = Console.In.ReadLine();
 
            Compte C2 = new Compte(new Client(cin, nom, prenom, tel));
            Console.Out.WriteLine("Détails du compte: ");
            C2.Afficher();
 
            Console.Out.WriteLine("Crediter le compte 2 à partir du compte 1");
            Console.Out.Write("Donner le montant à déposer: ");
            montant = double.Parse(Console.In.ReadLine());
            C2.Crediter(montant);

            Console.Out.WriteLine("Débiter le compte 1 et créditer le compte 2");
            Console.Out.Write("Donner le montant à retirer: ");
            montant = double.Parse(Console.In.ReadLine());
            C1.Debiter(montant);
           
            C1.Afficher();
            C2.Afficher();
 
            Compte.Nombre_Comptes();
 
            Console.ReadKey();
        }
    }
//Source : www.exelib.net
//Source : www.exelib.net
//Source : www.exelib.net
