using System;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class RequiredFieldAttribute : Attribute
{
    public string HataMesaji { get; }

    public RequiredFieldAttribute(string hataMesaji)
    {
        HataMesaji = hataMesaji;
    }
}