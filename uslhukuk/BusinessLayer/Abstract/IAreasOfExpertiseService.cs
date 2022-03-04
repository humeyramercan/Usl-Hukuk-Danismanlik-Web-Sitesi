using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAreasOfExpertiseService
    {

        List<AreasOfExpertise> AreasOfExpertiseList();
        void AddAreasOfExpertise(AreasOfExpertise areasOfExpertise);
        void UpdateAreasOfExpertise(AreasOfExpertise areasOfExpertise);
        void DeleteAreasOfExpertise(AreasOfExpertise areasOfExpertise);

        AreasOfExpertise GetAreasOfExpertiseById(int id);
    }
}
