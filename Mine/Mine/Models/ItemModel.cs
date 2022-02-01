using System;
using SQLite;
/// <summary>
/// Items for the Characters and Monsters to use
/// </summary>
namespace Mine.Models
{
    public class ItemModel
    {
        //The Id for the item
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        //The Display Text for the item
        public string Text { get; set; }

        //The Description for the item
        public string Description { get; set; }

        //The value of the Item +9 Damage
        public int Value { get; set; } = 0;
    }
}