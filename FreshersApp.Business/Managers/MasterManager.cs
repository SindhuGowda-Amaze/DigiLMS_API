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

