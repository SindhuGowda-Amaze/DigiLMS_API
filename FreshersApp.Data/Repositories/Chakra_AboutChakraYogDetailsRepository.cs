using ChakraYog.Data.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChakraYog.Data.Repositories
{
    public class Chakra_AboutChakraYogDetailsRepository: Repository, IChakra_AboutChakraYogDetailsRepository
    {
        /// <summary>
        /// method to get the chakra yog founder details 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name=" "></param>
        /// <returns></returns>
        public T GetChakraFounderDetails<T>()
        {
            try
            {
                return db.Query<T>("SProc_GetChakra_Founder", commandType: CommandType.StoredProcedure).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetChakra_AboutUs_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_AboutUs_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetChakra_Articles_ScienceOfRRST_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_Articles_ScienceOfRRST_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetChakra_Articles_PowerOfRudraksha_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_Articles_PowerOfRudraksha_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetChakra_Articles_VedicGemstones_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_Articles_VedicGemstones_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetChakra_Articles_SevenChakraTherapy_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_Articles_SevenChakraTherapy_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetChakra_Articles_SignificanceofPlanets_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_Articles_SignificanceofPlanets_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetChakra_Articles_OnlinePujaServices_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_Articles_OnlinePujaServices_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetChakra_Articles_GodAndGodesses_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_Articles_GodAndGodesses_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetChakra_Articles_MysteryOfSacredYantras_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_Articles_MysteryOfSacredYantras_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<T> GetChakra_Articles_ScienceOfSidhParad_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_Articles_ScienceOfSidhParad_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetChakra_JoinOurNetwork_Web<T>()
        {
            try
            {
                return db.Query<T>("[dbo].[SProc_GetChakra_JoinOurNetwork_Web]", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// method to get GetAboutUSClintResponse
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name=" "></param>
        /// <returns></returns>
        public IEnumerable<T> GetAboutUSClintResponse<T>()
        {
            try
            {
                return db.Query<T>("SProc_GetAboutUSClintResponse", commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
