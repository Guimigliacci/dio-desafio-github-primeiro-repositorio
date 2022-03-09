namespace RPG.src.Entities
{
    public class WhiteWizard : Hero
    {

        public WhiteWizard(string Name, int Level, string HeroType, int HP, int MP)
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
                return this.Name + " Magia branca fraca com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Magia branca forte com bonus de " + Bonus;
            }
        }
        
    }
}