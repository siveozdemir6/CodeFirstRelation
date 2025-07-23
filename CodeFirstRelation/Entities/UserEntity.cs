namespace CodeFirstRelation.Entities
{
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public List<PostEntity> Posts { get; set; }
    }
}
