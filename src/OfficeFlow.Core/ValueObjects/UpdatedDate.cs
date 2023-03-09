namespace OfficeFlow.Core.ValueObjects;

public sealed record UpdatedDate
{
    public DateTimeOffset Value { get; }

    public UpdatedDate(DateTimeOffset value)
    {
        Value = value.Date;
    }

    public static implicit operator DateTimeOffset(UpdatedDate updatedDate) => updatedDate.Value;
    public static implicit operator UpdatedDate(DateTimeOffset updatedDate) => new(updatedDate);
    public static UpdatedDate Now => new(DateTimeOffset.UtcNow);
    public override string ToString() => Value.ToString("d");

}
