namespace RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP)
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
                return this.Name + " Ataque de espada fraco com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Ataque de espada forte com bonus de " + Bonus;
            }
        }
    }
}