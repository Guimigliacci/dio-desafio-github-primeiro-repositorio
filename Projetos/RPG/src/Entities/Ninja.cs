namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP)
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
                return this.Name + " Ataque com adaga fraco com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Ataque com adaga forte com bonus de " + Bonus;
            }
        }
    }
}