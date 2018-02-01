using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi.Models;

namespace CoreApi.Controllers
{
    [Route("api/data")]
    public class ArbitraryController : Controller
    {
        [HttpGet()]
        public IActionResult GetData()
        {
            return Ok(DataStore.Current.ArbitaryModelList);
        }

        [HttpGet("{id}", Name = "GetData")]
        public IActionResult GetData(int id)
        {
            var dataToReturn = DataStore.Current.ArbitaryModelList.FirstOrDefault(d => d.Id == id);

            if (dataToReturn == null)
            {
                return NotFound();
            }

            return Ok(dataToReturn);
        }

        [HttpPost()]
        public IActionResult CreateData([FromBody] ArbitraryModel arbitraryModel)
        {
            if (arbitraryModel == null)
            {
                return BadRequest();
            }

            var maxDataId = DataStore.Current.ArbitaryModelList.Max(d => d.Id);

            var finalData = new ArbitraryModel()
            {
                Id = ++maxDataId,
                Name = arbitraryModel.Name,
                ImageUrl = arbitraryModel.ImageUrl,
                LinkUrl = arbitraryModel.LinkUrl,
                Title = arbitraryModel.Title,
                Description = arbitraryModel.Description,
                Content = arbitraryModel.Content,
                LinkText = arbitraryModel.LinkText
            };

            DataStore.Current.ArbitaryModelList.Add(finalData);

            return CreatedAtRoute("GetData", new
            { id = finalData.Id }, finalData);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateData(int id, [FromBody] ArbitraryModel arbitraryModel)
        {
            if (arbitraryModel == null)
            {
                return BadRequest();
            }

            var dataToUpdate = DataStore.Current.ArbitaryModelList.FirstOrDefault(d => d.Id == id);

            if (dataToUpdate == null)
            {
                return NotFound();
            }

            dataToUpdate.Name = arbitraryModel.Name;
            dataToUpdate.Description = arbitraryModel.Description;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {

            var dataToUpdate = DataStore.Current.ArbitaryModelList.FirstOrDefault(d => d.Id == id);

            if (dataToUpdate == null)
            {
                return NotFound();
            }

            DataStore.Current.ArbitaryModelList.Remove(dataToUpdate);
            return NoContent();
        }
    }
}
