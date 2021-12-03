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

        public IEnumerable<dynamic> GetProjectTypeMaster()
        {
            try
            {
                return IMasterRepository.GetProjectTypeMaster<dynamic>();
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

        public IEnumerable<dynamic> LoginPage()
        {
            try
            {
                return IMasterRepository.LoginPage<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<dynamic> GetEnquery()
        {
            try
            {
                return IMasterRepository.GetEnquery<dynamic>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertEnquery(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    Date=entity.Date,
                    Name=entity.Name,
                    PhoneNumber=entity.PhoneNumber,
                    //EmailID=entity.EmailID,
                    //Message=entity.Message,
                    Action=entity.Action
                };
                return IMasterRepository.InsertEnquery(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdateEnquery(MasterEntity entity)
        {
            try
            {
                var filter = new
                {
                    ID=entity.ID,
                    Date = entity.Date,
                    Name = entity.Name,
                    PhoneNumber = entity.PhoneNumber,
                    //EmailID = entity.EmailID,
                    //Message = entity.Message,
                    Action = entity.Action
                };
                return IMasterRepository.UpdateEnquery(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long DeleteEnquery(object filter)
        {
            try
            {
                return IMasterRepository.DeleteEnquery(filter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

