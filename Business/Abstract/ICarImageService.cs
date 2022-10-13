using Core.Utilities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        public IResult Add(IFormFile file, CarImage carImage, int carId);
        public IResult Delete(CarImage carImage);
        public IResult Update(IFormFile file, CarImage carImage);
        public IDataResult<List<CarImage>> GetAll();
    }
}
