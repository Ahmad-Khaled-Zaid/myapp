
using Users.Models;

namespace Users.Reposories{
    class UsersList{
        public List<Account> Accounts =new(){
            new Account{id=Guid.NewGuid(),Name="Ahmad",Email="ahmad@gmail.com",Password="12345"},
            new Account{id=Guid.NewGuid(),Name="Sara",Email="Sara@gmail.com",Password="sa12345"},
            new Account{id=Guid.NewGuid(),Name="Moyad",Email="Moyad94@gmail.com",Password="trfe13"}
        };
    }


    
    
}
