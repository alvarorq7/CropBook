using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CropBookModels.Models;

namespace CropBook.DataAccess
{
    public interface IUnitofWork
    {
        public IRepository<Crop> Crop { get; }
        public IRepository<Farm> Farm { get; }
        public IRepository<GreenHouse> GreenHouse { get; }
        public IRepository<Plot> Plot { get; }
        public IRepository<Variety> Variety { get; }
        public IRepository<Vegetable> Vegetable { get; }
        public void Save();
    }
}
