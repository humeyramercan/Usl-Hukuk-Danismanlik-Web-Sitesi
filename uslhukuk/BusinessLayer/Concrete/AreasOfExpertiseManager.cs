using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AreasOfExpertiseManager : IAreasOfExpertiseService
    {
        IAreasOfExpertiseDal _areasOfExpertiseDal;

        public AreasOfExpertiseManager(IAreasOfExpertiseDal areasOfExpertiseDal)
        {
            _areasOfExpertiseDal = areasOfExpertiseDal;
        }

        public void AddAreasOfExpertise(AreasOfExpertise areasOfExpertise)
        {
            _areasOfExpertiseDal.Insert(areasOfExpertise);
            
        }

        public List<AreasOfExpertise> AreasOfExpertiseList()
        {
            return _areasOfExpertiseDal.List();
        }

        public void DeleteAreasOfExpertise(AreasOfExpertise areasOfExpertise)
        {
            _areasOfExpertiseDal.Delete(areasOfExpertise);
        }

        public AreasOfExpertise GetAreasOfExpertiseById(int id)
        {
            return _areasOfExpertiseDal.Get(x => x.UzmanlikAlaniID == id);
        }

        public void UpdateAreasOfExpertise(AreasOfExpertise areasOfExpertise)
        {
            _areasOfExpertiseDal.Update(areasOfExpertise);
        }
    }
}
