using FreshersApp.Business.Entities;
using FreshersApp.Business.Interface;
using FreshersApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersApp.Business.Managers
{
    public class MasterManager : IMasterManager

    {
        private IMasterRepository IMasterRepository;

        public MasterManager(IMasterRepository IMasterRepository)
        {
            this.IMasterRepository = IMasterRepository;
        }

        //getCostcenter and department



        public IEnumerable<dynamic> GetCostcenter()
        {
            try
            {
                return IMasterRepository.GetCostcenter<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetPhilHealth()
        {
            try
            {
                return IMasterRepository.GetPhilHealth<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertPhilHealth(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Monthly_Basic_Salary_Into_Five = entity.Monthly_Basic_Salary_Into_Five,
                    Monthly_Share = entity.Monthly_Share,
                    Personal_Share = entity.Personal_Share,
                    Employee_Share = entity.Employee_Share

                };
                return IMasterRepository.InsertPhilHealth(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdatePhilHealth(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Monthly_Basic_Salary_Into_Five = entity.Monthly_Basic_Salary_Into_Five,
                    Monthly_Share = entity.Monthly_Share,
                    Personal_Share = entity.Personal_Share,
                    Employee_Share =entity.Employee_Share
                };
                return IMasterRepository.UpdatePhilHealth(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeletePhilHealth(object filter)
        {
            try
            {
                return IMasterRepository.DeletePhilHealth(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }







        public IEnumerable<dynamic> GetCompanyAdjustment()
        {
            try
            {
                return IMasterRepository.GetCompanyAdjustment<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<dynamic> GetDepartment()
        {
            try
            {
                return IMasterRepository.GetDepartment<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertCompanyAdjustment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Type=entity.Type,
                    Name = entity.Name,
                    Code = entity.Code,
                    Amount=entity.Amount,
                    Remarks = entity.Remarks,
                    BeforeTax = entity.BeforeTax,
                    Taxable =entity.Taxable,
                    MaxAccumulated = entity.MaxAccumulated

                };
                return IMasterRepository.InsertCompanyAdjustment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCompanyAdjustment(MasterEntity entity)
        {
            try
            {
                var filter = new
                { 
                    ID=entity.ID,
                    Type = entity.Type,
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                    Amount = entity.Amount,
                    Taxable = entity.Taxable,
                    MaxAccumulated = entity.MaxAccumulated

                };
                return IMasterRepository.UpdateCompanyAdjustment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteCompanyAdjustment(object filter)
        {
            try
            {
                return IMasterRepository.DeleteCompanyAdjustment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }








        public long InsertDepartment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                };
                return IMasterRepository.InsertDepartment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long UpdateDepartment(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID = entity.ID,
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                };
                return IMasterRepository.UpdateDepartment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long DeleteDepartment(object filter)
        {
            try
            {
                return IMasterRepository.DeleteDepartment(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public long InsertCostcenter(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                   
                };
                return IMasterRepository.InsertCostcenter(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateCostcenter(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID=entity.ID,
                    Name = entity.Name,
                    Code = entity.Code,
                    Remarks = entity.Remarks,
                    Changes = entity.Changes,
                    ModifiedBy = entity.ModifiedBy

                };
                return IMasterRepository.UpdateCostcenter(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteCostcenter(object filter)
        {
            try
            {
                return IMasterRepository.DeleteCostcenter(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      






        public long DeleteFoodSenseProject(object filter)
        {
            try
            {
                return IMasterRepository.DeleteFoodSenseProject(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetFoodSenseProjects()
        {
                try
                {
                    return IMasterRepository.GetFoodSenseProjects<dynamic>();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

       

        public long InsertFoodSenseProjects(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ProjectTypeID = entity.@ProjectTypeID,
                    ProjectName=entity.ProjectName,
                    ProjectDescription=entity.ProjectDescription,
                    ClientName=entity.ClientName,
                    ClientLocation=entity.ClientLocation,
                    Highlights=entity.Highlights,
                    Photo=entity.PhotoURL
                };
                return IMasterRepository.InsertFoodSenseProjects(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateFoodSenseProject(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID=entity.ID,
                    ProjectTypeID = entity.ProjectTypeID,
                    ProjectName = entity.ProjectName,
                    ProjectDescription = entity.ProjectDescription,
                    ClientName = entity.ClientName,
                    ClientLocation = entity.ClientLocation,
                    Highlights = entity.Highlights,
                    Photo = entity.PhotoURL
                };
                return IMasterRepository.UpdateFoodSenseProject(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
    }
}

