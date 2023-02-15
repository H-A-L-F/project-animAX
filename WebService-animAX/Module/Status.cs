using System;

public class StringValueAttribute : Attribute
{
    public string Value { get; private set; }

    public StringValueAttribute(string value)
    {
        Value = value;
    }
}

public enum Status
{
    [StringValue("Success")]
    SUCCESS,

    [StringValue("LOADING")]
    LOADING,

    [StringValue("Error")]
    ERROR
}
