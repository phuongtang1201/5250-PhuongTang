using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mine.Models;

namespace Mine.Services
{
    public class MockDataStore : IDataStore<ItemModel>
    {
        readonly List<ItemModel> items;

        public MockDataStore()
        {
            items = new List<ItemModel>()
            {
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Banna", Description="This can increase your current health", Value =  3},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Gloves", Description="This can protect your hand", Value =5 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Invisible hat", Description="This can make you invisible from your target", Value = 8 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Water Gun", Description="This can make your target blind" , Value = 9},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Monster Shirt", Description="This can protect your body" , Value =  12 }
                
            };
        }

        public async Task<bool> CreateAsync(ItemModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(ItemModel item)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ItemModel> ReadAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemModel>> IndexAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}