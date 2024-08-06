using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Accountrepos
    {
        public QlDuAn1Context dbcontext;
        public Accountrepos()
        {
            dbcontext = new QlDuAn1Context();
        }
        public List<Account> getallacc()
        {
            return dbcontext.Accounts.ToList();
        }
        public void AddAccount(string username,string ten,string password,int type)
        {
            var account = new Account
            {
                Username = username,
                Ten = ten,
                Password = password,
                Type = type
            };

           dbcontext.Accounts.Add(account);
            dbcontext.SaveChanges();
        }
        public void Updateacc(string username, string ten, string password, int type)
        {
            var account = dbcontext.Accounts.FirstOrDefault(ac => ac.Type == type);
            if (account != null)
            {
                account.Username = username;
                account.Ten = ten;
                account.Password = password;
                account.Type = type;
                dbcontext.SaveChanges();
            }
        }
        public void Deleteaccount(int type)
        {
            var account = dbcontext.Accounts.FirstOrDefault(ac => ac.Type == type);
            if (account != null)
            {
                dbcontext.Accounts.Remove(account);
                dbcontext.SaveChanges();
            }
        }
        public List<Account> SearchAcc(string searchString)
        {
            return dbcontext.Accounts
                .Where(ac => ac.Ten.Contains(searchString) || ac.Username.Contains(searchString))
                .ToList();
        }
        public Account GetUser(string username, string password)
        {
            return dbcontext.Accounts.FirstOrDefault(ac => ac.Username == username && ac.Password == password);
        }
        public void password(string username,string password)
        {
            var account = dbcontext.Accounts.FirstOrDefault(ac => ac.Username == username);
            if (account != null)
            {
                account.Username = username;              
                account.Password = password;        
                dbcontext.SaveChanges();
            }
        }
    }
}
