namespace Bigon2.Models.Entites
{
    public abstract class BaseEntity<Tkey> : AuditableEntity
        where Tkey : struct
    {
        public Tkey Id { get; set; }
    }
}
