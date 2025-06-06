using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository
    {
        public AccountMember GetAcountById(string accountId)
       => AccountDAO.GetAccountById(accountId);
    }
}
