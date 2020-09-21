using System;

namespace ForRPG
{
    public class NPC : Interactable
    {
        private Random rand = new Random();
        public string Quest(Player player)
        {
            string[] questList = new string[] { "quest 1", "quest 2", "quest 3" };
            string nowQuest = questList[rand.Next(questList.Length)];
            if (nowQuest == "quest 1")
            {
                player.GiveLoot(TakeLoot());
            }
            return nowQuest;
        }

        private Loot TakeLoot()
        {
            return new Weapon();
        }
    }
}
