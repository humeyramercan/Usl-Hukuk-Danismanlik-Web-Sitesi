using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILawyerService
    {
        List<Lawyer> LawyerList();
        void AddLawyer(Lawyer lawyer);
        void UpdateLawyer(Lawyer lawyer);
        void DeleteLawyer(Lawyer lawyer);

        Lawyer GetLawyerById(int id);

        
    }
}
