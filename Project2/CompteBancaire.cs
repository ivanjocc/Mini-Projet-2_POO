public class CompteBancaire
{
    private int numeroCompte;
    private string nom;
    private double solde;

    public CompteBancaire(int numeroCompte, string nom, double solde)
    {
        this.numeroCompte = numeroCompte;
        this.nom = nom;
        this.solde = solde;
    }

    public void Versement(double montant)
    {
        solde += montant;
        Console.WriteLine("tu as fait un versement");
    }

    public void Retrait(double montant)
    {
        if (solde >= montant)
        {
            solde -= montant;
            Console.WriteLine("tu as fait un retrait");
        }
        else
        {
            Console.WriteLine("tu as fait un retrait et Il n'y a pas argent :)");
        }
    }

    public void Agios()
    {
        double agios = solde * 0.05;
        solde -= agios;
        Console.WriteLine("tu as fait un agios");
    }

    public void Afficher()
    {
        Console.WriteLine("Le nom de la personne est: {0}", nom);
        Console.WriteLine("Le numero de compte est: {0}", numeroCompte);
        Console.WriteLine("Le solde est: {0}", solde);
    }
}
