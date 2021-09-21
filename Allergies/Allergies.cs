using System;
using System.Collections.Generic;
using System.Linq;

namespace Allergies
{
    public class Allergies
    {
        public string Name { get; }
        public int Score { get; set; }

        public Allergies(string Name) {
            this.Name = Name;
        }

        public Allergies(string Name, int Score)
        {
            this.Name = Name;
            this.Score = Score;
        }

        public Allergies(string Name, string AllergensList)
        {
            this.Name = Name;
            string[] Allergens = AllergensList.Split(' ');
            for(int i=0; i<Allergens.Length; i++)
            {
               Score += (int)Enum.Parse(typeof(Allergen), Allergens[i]);
            }
        }

        private List<int> GetAllergies() {
            List<int> Results = new List<int>();
            for (int i = 0; i < 128; i++)
            {
                int A = (int)Math.Pow(2, i);
                if ((Score & A) == A)
                    Results.Add(A);
            }
            return Results;
        }

        private List<string> GetAllergieNames()
        {
            List<string> Results = new List<string>();
            for (int i = 0; i < 128; i++)
            {
                int A = (int)Math.Pow(2, i);
                if ((Score & A) == A)
                    Results.Add(Enum.GetName(typeof(Allergen), A));
            }
            return Results;
        }

        public void AddAllergy(Allergen A) {
            Score += (int)A;
        }

        public void AddAllergy(String A)
        {
            Score += (int)Enum.Parse(typeof(Allergen), A);
        }

        public void DeleteAllergy(Allergen A)
        {
            Score -= (int)A;
        }

        public void DeleteAllergy(String A)
        {
            Score -= (int)Enum.Parse(typeof(Allergen), A);
        }

        public override string ToString() {
            string Result = Name;
            var AllergyNames = GetAllergieNames();
            if (AllergyNames.Count() == 0)
                Result += " has no allergies!";
            else {
                Result += " is allergic to ";
                for (int i = 0; i < AllergyNames.Count(); i++) {
                    if (i != 0 && i == (AllergyNames.Count() - 1))
                        Result += ", and " + AllergyNames.ElementAt(i) + ".";
                    else if (i != 0 && i != (AllergyNames.Count() - 1))
                        Result += ", " + AllergyNames.ElementAt(i);
                    else
                        Result += AllergyNames.ElementAt(i);
                }
            }                
            return Result;
        }

        public bool IsAllergicTo(Allergen A)
        {
            return GetAllergies().Any(a=> a == (int)A);
        }

        public bool IsAllergicTo(string A)
        {
            return GetAllergies().Any(a => a == (int)Enum.Parse(typeof(Allergen), A)); 
        }
    }

    public enum Allergen { 
        Eggs = 1,
        Peanuts = 2,
        Shellfish = 4,
        Strawberries = 8,
        Tomatoes = 16,
        Chocolate = 32,
        Pollen = 64,
        Cats = 128
    }
}
