using StudySystem.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySystem.Data.EF.Repositories.Interfaces
{
    public interface IHandleCookiesRepository : IRepository<Cookies>
    {
        /// <summary>
        /// hanlde save cookie to database
        /// </summary>
        /// <returns></returns>
        Task<int> HandlerCookie(Cookies cookies);
    }
}
