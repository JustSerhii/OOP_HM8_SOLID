using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    //У завданні 1 порушено принцип єдиного обов'язку (The Single Responsibility Principle).
    class Item
    {

    }
    interface IOrder
    {
        public void CalculateTotalSum();
        public void GetItems();
        public void GetItemCount();
        public void AddItem(Item item);
        public void DeleteItem(Item item);
    }
    class Order : IOrder;
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }
        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }
    interface IArchive
    {
        public void Load();
        public void Save();
        public void Update();
        public void Delete();
    }
    class Archive : IArchive
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }

    interface iOrderActions
    {
        public void PrintOrder();
        public void ShowOrder();
    }
    class OrderActions : iOrderActions
    {
        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }
    class Program
    {
        static void Main()
        {
        }
    }
}
