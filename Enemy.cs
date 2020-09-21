namespace ForRPG
{
    public class Enemy : Interactable
    {
        private int hp;
        private int xp;
        private int damage = 1;

        public void TakeDamage(int damage)
        {
            hp -= damage;
        }

        public void GiveDamage(Player player)
        {
            player.ChangeHP(damage);
        }

        public void ChangeXP(int xp)
        {
            this.xp += xp;
        }
    }
}
