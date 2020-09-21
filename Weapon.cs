namespace ForRPG
{
    public class Weapon : Loot
    {
        private string type;
        private int damage = 1;
        private int strength = 15;

        public void Atack(Enemy enemy)
        {
            enemy.TakeDamage(damage);
            strength--;
        }
    }
}
