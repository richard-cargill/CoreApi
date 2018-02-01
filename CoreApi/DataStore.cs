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
                    ImageUrl = "https://www.oxforduniversityimages.com/images/rotate/Image_Spring_17_1.gif",
                    LinkUrl = "http://www.macmillan.org.uk/information-and-support/resources-and-publications/stories/charmaine/charmaine-nurse.html",
                    Title = "Macmillan Nurses",
                    Description = "Description 1",
                    Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    LinkText = "Read Charmine's Story"
                },
                new ArbitraryModel()
                {
                    Id = 2,
                    Name = "Test 2",
                    ImageUrl = "https://www.w3schools.com/w3css/img_lights.jpg",
                    LinkUrl = "http://www.macmillan.org.uk/information-and-support/index.html",
                    Title = "Cancer information and support",
                    Description = "Description 2",
                    Content = "Suspendisse gravida nibh arcu, nec faucibus sapien rutrum vel. Ut non turpis nec lectus luctus ultrices. Integer sed odio eget lectus viverra maximus sit amet a elit. Maecenas tristique blandit aliquam. Etiam ante nisl, suscipit quis nisi dictum, tempor efficitur eros. Mauris sit amet tellus sagittis, ultrices neque at, ultricies dolor. Etiam quis venenatis est. Sed hendrerit lectus orci, eu efficitur nibh tincidunt id. Fusce vitae volutpat ligula. Vivamus gravida lorem sed odio viverra, sit amet convallis nisi pulvinar. Proin consequat, ante sit amet lobortis viverra, dui urna ultricies tortor, non laoreet enim nibh ac libero.",
                    LinkText = "Find out more"
                },
                new ArbitraryModel()
                {
                    Id = 3,
                    Name = "Test 3",
                    ImageUrl = "https://ichef-1.bbci.co.uk/news/976/cpsprodpb/1572B/production/_88615878_976x1024n0037151.jpg",
                    LinkUrl = "http://www.macmillan.org.uk/information-and-support/resources-and-publications/stories/thom/thom-benefits-financial-support.html",
                    Title = "Help with money worries",
                    Description = "Description 3",
                    Content = "Integer vel est ut nisi lobortis malesuada sit amet vitae nulla. Vestibulum libero arcu, convallis quis lorem sed, elementum tempor urna. Morbi id ullamcorper magna, maximus interdum erat. Sed ac ultricies tellus. Integer et gravida libero. Duis eu vestibulum nunc. Phasellus quis ipsum quam. Maecenas semper metus ac molestie aliquam. Duis a lorem et lacus tincidunt mollis. Fusce id efficitur felis. Praesent a luctus ipsum, quis scelerisque sapien. Nulla non nulla metus. Duis interdum fringilla erat ut elementum. Nam gravida rhoncus fermentum. Sed euismod urna nec pellentesque porttitor. Sed aliquet vulputate nisi, eu iaculis enim tempor eget.",
                    LinkText=  "Read Thom's Story"
                }
            };
        }
    }
}
