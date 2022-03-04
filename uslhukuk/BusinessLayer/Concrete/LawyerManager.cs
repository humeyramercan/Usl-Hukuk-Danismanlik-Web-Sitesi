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
    public class LawyerManager : ILawyerService
    {
        ILawyerDal _lawyerDal;

        public LawyerManager(ILawyerDal lawyerDal)
        {
            _lawyerDal = lawyerDal;
        }

        public void AddLawyer(Lawyer lawyer)
        {
            _lawyerDal.Insert(lawyer);
        }

        public void DeleteLawyer(Lawyer lawyer)
        {
            _lawyerDal.Delete(lawyer);
        }

        public Lawyer GetLawyerById(int id)
        {
            return _lawyerDal.Get(x => x.AvukatID == id);
        }

        public List<Lawyer> LawyerList()
        {
            return _lawyerDal.List();
        }

        public void UpdateLawyer(Lawyer lawyer)
        {
            _lawyerDal.Update(lawyer);
        }
    }
}
