class Compte {
    private int numero;
    private double solde;
    private Client proprietaire;
    private static int nbr_compte = 0;

    public int Numero {
        get { return numero;}
    }

    public double Solde {
        get { return solde;}
    }

    public Client Proprietaire {
        get { return proprietaire;}
        set { proprietaire = value;}
    }

    public Compte(Client proprietaire) {
        nbr_compte++;
        numero = nbr_compte;
        this.proprietaire = proprietaire;
    }

    public void Debiter(double somme) {
        if (somme < solde) {
            solde = solde - somme;
        }
        else {
            Console.Out.WriteLine("You can't take a credit");
        }

    }

    public void Crediter(double somme) {
        solde += somme;
    }

     public void Afficher()
        {
            Console.Out.WriteLine("************************");
            Console.Out.WriteLine("Numéro de Compte: " + numero);
            Console.Out.WriteLine("Solde de compte: " + solde);
            Console.Out.WriteLine("Propriétaire du compte : ");
            proprietaire.Afficher();
            Console.Out.WriteLine("*************************");
        }

    public static void Nombre_Comptes() {
        Console.Out.WriteLine("Le nombre de compte est : " + nbr_compte);
    }    
//Source : www.exelib.net


}