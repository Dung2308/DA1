using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Accountservice
    {
        public Accountrepos accountrepos;
        public Accountservice()
        {
            accountrepos = new Accountrepos();
        }
        public List<Account> Getallacc()
        {
            return accountrepos.getallacc();
        }
        public Account Authenticate(string username, string password)
        {
           
            return accountrepos.GetUser(username, password);
        }
        public void Addacc(string username,string Ten,string password,int type)
        {
            accountrepos.AddAccount(username, Ten, password, type);
        }
        public void UpdateAcc(string username, string Ten, string password, int type)
        {

            accountrepos.Updateacc(username, Ten, password, type);
        }
        public void Deleteacc(int type)
        {
            accountrepos.Deleteaccount(type);
        }
        public List<Account> SearchAcc(string searchString)
        {
            return accountrepos.SearchAcc(searchString);
        }
        public void password(string username,string password)
        {
            accountrepos.password(username, password,);
        }
    }
}
