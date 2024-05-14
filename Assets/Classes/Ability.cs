namespace Assets.Enum
{
    [System.Serializable]


    public class Ability
    {
        public string AbilityName { get; set; }
        public AbilityType AbilityType { get; set; }
        public string AbilityDescription { get; set; }

        public Ability()
        {

        }

        public Ability(string name, AbilityType ability, string description)
        {
            AbilityName = name;
            AbilityType = ability;
            AbilityDescription = description;
        }
    }
}
