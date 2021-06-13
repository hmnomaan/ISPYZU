using ISPYZU.Models; // TestDbContext
using System;
using System.Collections.Generic;
using System.Data.Entity; // DropCreateDatabaseAlways<DbContext>
using System.Linq;
using System.Web;


namespace ISPYZU.App_Code
{
  //ALT+Enter for twice! using two namespaces!
  public class TestDbInitialization : DropCreateDatabaseAlways<TestDbContext>
  {
    //set the seed, which is used for add data to the tables in the database!
    //  after creating the database
    protected override void Seed(TestDbContext context)
    {

            
            var roles = new List<Role>
      {
        new Role { Id = 1, RoleName = "Teacher", Description = "managing_department" },
        new Role { Id = 2, RoleName = "Admin", Description = "directing_department"},
        new Role { Id = 3, RoleName = "Student", Description = "programmer_department"}
      };
            roles.ForEach(r => context.Roles.Add(r));
            context.SaveChanges();

            var users = new List<User>
      {
        new User { Id=1, UserName="wangjie",  Password="123456", RoleId=1},
        new User { Id=2, UserName ="senior1", Password="123456", RoleId=2},
        new User { Id=3, UserName ="senior2", Password="123456", RoleId=2},
        new User { Id=4, UserName="junior1",  Password="123456", RoleId=3},
        new User { Id=5, UserName="junior2",  Password="123456", RoleId=3},
        new User { Id=6, UserName="junior3",  Password="123456", RoleId=3},
        new User { Id=7, UserName="admin",  Password="admin1234", RoleId=3}
      };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            base.Seed(context);
    }
  }
}