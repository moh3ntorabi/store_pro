using Phoenix_Store.Domain.Entities.Commons;

namespace Phoenix_Store.Domain.Entities.Users
{
    public class UserInRole:BaseEntity
    {
        //one to many with user
        public long Id { get; set; }
        public virtual User User{ get; set; }
        public long UserId{ get; set; }
        //one to many with role
        public virtual Role Role { get; set; }
        public long RoleId { get; set; }


    }
}
