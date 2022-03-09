namespace RPG.src.Entities
{
    public class DarkWizard : Hero
    {
        public DarkWizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack(int Bonus)
        {
            if(Bonus < 6)
            {
                return this.Name + " Magia negra fraca com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Magia negra forte com bonus de " + Bonus;
            }
        }
    }
}