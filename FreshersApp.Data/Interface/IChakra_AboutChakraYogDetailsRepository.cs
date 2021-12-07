using ChakraYog.Data.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChakraYog.Data.Interface
{
    public interface IChakra_AboutChakraYogDetailsRepository
    {
        T GetChakraFounderDetails<T>();
        IEnumerable<T> GetChakra_AboutUs_Web<T>();
        IEnumerable<T> GetChakra_Articles_ScienceOfRRST_Web<T>();
        IEnumerable<T> GetChakra_Articles_PowerOfRudraksha_Web<T>();
        IEnumerable<T> GetChakra_Articles_VedicGemstones_Web<T>();
        IEnumerable<T> GetChakra_Articles_SevenChakraTherapy_Web<T>();
        IEnumerable<T> GetChakra_Articles_SignificanceofPlanets_Web<T>();
        IEnumerable<T> GetChakra_Articles_OnlinePujaServices_Web<T>();
        IEnumerable<T> GetChakra_Articles_GodAndGodesses_Web<T>();
        IEnumerable<T> GetChakra_Articles_MysteryOfSacredYantras_Web<T>();
        IEnumerable<T> GetChakra_Articles_ScienceOfSidhParad_Web<T>();
        IEnumerable<T> GetChakra_JoinOurNetwork_Web<T>();
        IEnumerable<T> GetAboutUSClintResponse<T>();

    }
}
