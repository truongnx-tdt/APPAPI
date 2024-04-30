using LinqToDB;
using StudySystem.Data.EF.Repositories.Interfaces;
using StudySystem.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudySystem.Data.EF.Repositories
{
    public class HandleCookiesRepository : Repository<Cookies>, IHandleCookiesRepository
    {
        private readonly AppDbContext _context;
        public HandleCookiesRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> HandlerCookie(Cookies cookies)
        {
            Cookies userExists = await _context.CookieDatas.SingleOrDefaultAsync(x => x.CUser.Equals(cookies.CUser));
            if (string.IsNullOrEmpty(userExists?.CUser))
            {
                await _context.AddAsync(cookies);
                await _context.SaveChangesAsync();
                return 1;
            }
            else if (userExists.CUser != "")
            {
                userExists.CookieData = cookies.CookieData;
                userExists.UpdateDateAt = DateTime.UtcNow;
                await _context.SaveChangesAsync();
                return 2;
            }
            return 0;
        }
    }
}
