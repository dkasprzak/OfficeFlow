using OfficeFlow.Core.Exceptions;

namespace OfficeFlow.Core.ValueObjects;

public sealed record CityId
{
    public Guid Value { get; }

    public CityId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new InvalidEntityIdException(value);
        }
        Value = value;
    }

    public static CityId Create() => new(Guid.NewGuid());
    public static implicit operator Guid(CityId cityId) => cityId.Value;
    public static implicit operator CityId(Guid cityId) => new(cityId);
}
