namespace DocumentModel;

/// <summary>
/// This class represents an inter-document reference identifier.
/// </summary>
public struct Reference : IEquatable<Reference>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  private readonly string Value;

  public Reference(string val)
  {
    Value = val;
  }

  public TypeCode GetTypeCode()
  {
    return Value.GetTypeCode();
  }


  public static implicit operator Reference(string? val)
  {
    if (val == null)
      return null;
    return new Reference(val);
  }

  public static implicit operator String(Reference val)
  {
    return val.Value;
  }

  /// <summary>
  /// Returns 8-digit hex string of the value.
  /// </summary>
  /// <returns></returns>
  public override string ToString()
  {
    return Value;
  }

    public bool Equals(Reference other)
  {
    return Value == other.Value;
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}