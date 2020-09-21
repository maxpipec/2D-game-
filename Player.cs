using System;

namespace ForRPG
{
    public class Player
    {
        private int hp;

        public void ChangeHP(int hp)
        {
            this.hp -= hp;
        }

        internal void GiveLoot(Loot loot)
        {
            throw new NotImplementedException();
        }
    }
}