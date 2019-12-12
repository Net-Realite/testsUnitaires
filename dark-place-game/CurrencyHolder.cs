using System;

namespace dark_place_game
{

    [System.Serializable]
    /// Une Exeption Custom
    public class NotEnoughtSpaceInCurrencyHolderExeption : System.Exception { }

    public class CurrencyHolder
    {
        public static readonly string CURRENCY_DEFAULT_NAME = "Unnamed";

        /// Le nom de la monnaie
        public string CurrencyName
        {
            get { return currencyName; }
            private set
            {
                currencyName = value;
            }
        }
        // Le champs interne de la property
        private string currencyName = CURRENCY_DEFAULT_NAME;

        /// Le montant actuel
        public int CurrentAmount
        {
            get { return currentAmount; }
            private set
            {
                currentAmount = value;
            }
        }
        // Le champs interne de la property
        private int currentAmount = 0;

        /// La contenance maximum du conteneur
        public int Capacity
        {
            get { return capacity; }
            private set
            {
                capacity = value;
            }
        }
        // Le champs interne de la property
        private int capacity = 0;

        public CurrencyHolder(string name, int capacity, int amount)
        {
            if (amount < 0 || name == null || name=="" || name.Length < 4 || name.Length > 10 || name.StartsWith("a") == true || name.StartsWith("A") == true || capacity < 1)
            {
                throw new System.ArgumentException("Argument invalide");
            }
            Capacity = capacity;
            CurrencyName = name;
            CurrentAmount = amount;
        }

        public bool IsEmpty()
        {
            return true;
        }

        public bool IsFull()
        {
            return true;
        }

        public void Store(int amount)
        {
            this.CurrentAmount = this.CurrentAmount + amount;
            if (this.CurrentAmount > this.Capacity || amount < 0 || amount == 0)
            {
                throw new System.ArgumentException("Argument invalide");
            }
        }

        public void Withdraw(int amount)
        {
            this.CurrentAmount = this.CurrentAmount - amount;
            if (amount < 0 || amount == 0)
            {
                throw new System.ArgumentException("Argument invalide");
            }
        }
    }
}
