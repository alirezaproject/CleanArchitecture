namespace Common;

public abstract class BaseDomainEntity<TKey>
{
    public TKey Id { get; set; } = default!;
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime LastModifiedData { get; set; }
    public string LastModifiedBy { get; set; } = null!;
}

public abstract class BaseDomainEntity : BaseDomainEntity<long>
{

}