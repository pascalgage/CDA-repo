///////////////////////////////////////////////////////////
//  CompteBancaire.cs
//  Implementation of the Class CompteBancaire
//  Generated by Enterprise Architect
//  Created on:      18-juin-2021 11:41:10
//  Original author: kassim
///////////////////////////////////////////////////////////




namespace CompteBancaire
{
    public class Compte
    {

        private uint numeroCompte;
        private string nomProprietaire;
        private int soldeCompte;
        private int decouvertAutorise;

        public uint NumeroCompte { get => numeroCompte; }
        public int SoldeCompte { get => soldeCompte;  }

        public Compte()
        {
            numeroCompte = 0000;
            nomProprietaire = "Client";
            soldeCompte = 0;
            decouvertAutorise = -500;


        }




        /// 
        /// <param name="_numeroCompte"></param>
        /// <param name="_nomProprietaire"></param>
        /// <param name="_soldeCompte"></param>
        /// <param name="_decouvertAutorise"></param>
        public Compte(uint _numeroCompte, string _nomProprietaire, int _soldeCompte, int _decouvertAutorise)
        {
            this.numeroCompte = _numeroCompte;
            this.nomProprietaire = _nomProprietaire;
            this.soldeCompte = _soldeCompte;
            this.decouvertAutorise = _decouvertAutorise;

        }

        public override string ToString()
        {

            return "num�ro : " + numeroCompte + " nom : " + nomProprietaire + " solde : " + soldeCompte + " d�couvert autoris� : " + decouvertAutorise;
        }

        /// 
        /// <param name="montant"></param>
        public void Crediter(int _montant)
        {
            soldeCompte += _montant;
        }

        /// 
        /// <param name="montant"></param>
        public bool Debiter(int _montant)
        {
            bool ok = false;
            if ((soldeCompte - _montant) > decouvertAutorise)
            {

                soldeCompte -= _montant;
                ok = true;

            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// 
        /// <param name="_montant"></param>
        /// <param name="_autreCompte"></param>
        public bool Transferer(int _montant, Compte _autreCompte)
        {
            bool ok = false;
            if ((soldeCompte - _montant) > decouvertAutorise)
            {
                Debiter( _montant);
                _autreCompte.Crediter(_montant);
                ok = true;
            }
            else
            {
                ok = false;
            }
            return ok;
        }




        /// 
        /// <param name="_autreCompte"></param>
        public bool SuperieurAutreCompte(Compte _autreCompte)
        {
            bool ok = false;
            if (this.soldeCompte > _autreCompte.soldeCompte)
            {
                ok = true;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

    }//end CompteBancaire

}//end namespace CompteBancaire