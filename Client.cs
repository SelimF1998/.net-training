class Client {
    private string cin;
    private string nom;
    private string prenom;
    private string tel;

    public string Cin {
        get { return cin;}
    }

    public string Nom {
        get { return nom;}
        set { nom = value;}
    }

    public string Prenom {
        get { return prenom;}
        set { prenom = value;}
    }

    public string Tel {
        get { return tel;}
        set { tel = value;}
    }

    public Client (string cin, string nom, string prenom, string tel) {
        this.cin = cin;
        this.nom = nom;
        this.prenom = prenom;
        this.tel = tel;
    }

    public Client (string cin, string nom, string prenom) {
        this.cin = cin;
        this.nom = nom;
        this.prenom = prenom;
    }

    public void Afficher() {
        Console.Out.WriteLine("Cin : " + cin);
        Console.Out.WriteLine("Nom : " + nom);
        Console.Out.WriteLine("Prenom : " + prenom);
        if (tel!=""){
            Console.Out.WriteLine("Tel : " + tel);
        }
    }

}