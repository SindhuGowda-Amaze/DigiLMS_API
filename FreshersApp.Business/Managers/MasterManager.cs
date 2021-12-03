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

