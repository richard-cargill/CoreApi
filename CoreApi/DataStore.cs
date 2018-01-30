using CoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi
{
    public class DataStore
    {
        public static DataStore Current { get; } = new DataStore();
        public List<ArbitraryModel> ArbitaryModelList { get; set; }

        public DataStore()
        {
            ArbitaryModelList = new List<ArbitraryModel>()
            {
                new ArbitraryModel()
                {
                    Id = 1,
                    Name = "Test 1",
                    Description = "Another description of stuff"
                },
                new ArbitraryModel()
                {
                    Id = 2,
                    Name = "Test 2",
                    Description = "Another description of stuff"
                },
                new ArbitraryModel()
                {
                    Id = 3,
                    Name = "Test 3",
                    Description = "Another description of stuff"
                }
            };
        }
    }
}
