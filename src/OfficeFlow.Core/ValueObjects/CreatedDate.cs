namespace OfficeFlow.Core.ValueObjects;

public record CreatedDate
{
    public DateTimeOffset Value { get; }

    public CreatedDate(DateTimeOffset value)
    {
        Value = value.Date;
    }

    public static implicit operator DateTimeOffset(CreatedDate createdDate) => createdDate.Value;
    public static implicit operator CreatedDate(DateTimeOffset createdDate) => new(createdDate);
    public static CreatedDate Now => new(DateTimeOffset.Now);
    public override string ToString() => Value.ToString("d");
}
