using System;
using System.Linq;

namespace ForRPG
{
    public class InventoryManager
    {
        private int capacity;
        private int curentWeight;
        private int goldAmount;
        private Loot[] objectsInInventory = new Loot[0];

        public static InventoryManager instance;

        public void ChangeGoldAmount(int amount)
        {
            goldAmount += amount;
        }

        public void AddToInventory(Loot loot)
        {
            Array.Resize(ref objectsInInventory, objectsInInventory.Length + 1);
            objectsInInventory[objectsInInventory.Length - 1] = loot;
        }

        public void RemoveFromInvetroy(int index)
        {
            objectsInInventory = objectsInInventory.Where((number, i) => i != index).ToArray();

        }
    }
}
