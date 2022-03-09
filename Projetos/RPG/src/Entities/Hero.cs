namespace RPG.src.Entities
{
    public  abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public Hero()
        {
            
        }
        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int MP;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.HP + " " + this.MP;
        }
        
        public virtual string Attack(int Bonus)
        {
            if(Bonus < 6)
            {
                return this.Name + " Ataque fraco com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Ataque forte com bonus de " + Bonus;
            }

        }
    }
}