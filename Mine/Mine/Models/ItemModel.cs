using System;
/// <summary>
/// Items for the Characters and Monsters to use
/// </summary>
namespace Mine.Models
{
    public class ItemModel
    {
        //The Id for the item
        public string Id { get; set; }

        //The Display Text for the item
        public string Text { get; set; }

        //The Description for the item
        public string Description { get; set; }

        //The value of the Item +9 Damage
        public int Damage { get; set; } = 0;
    }
}