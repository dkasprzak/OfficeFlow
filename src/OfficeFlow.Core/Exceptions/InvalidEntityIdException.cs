﻿namespace OfficeFlow.Core.Exceptions;

public sealed class InvalidEntityIdException : CustomException
{
    public Guid Id { get; }

    public InvalidEntityIdException(Guid id) : base($"Id: {id} is invalid")
    {
        Id = id;
    }
}
