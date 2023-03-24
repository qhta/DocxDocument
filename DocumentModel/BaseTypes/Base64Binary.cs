namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public struct Base64Binary: IEquatable<Base64Binary>
{
  private byte[] value;

  public static implicit operator string(Base64Binary val)
  {
    return Convert.ToBase64String(val.value);
  }

  public static implicit operator Base64Binary(string val)
  {
    return new() { value = Convert.FromBase64String(val) };
  }

  public static implicit operator byte[](Base64Binary val)
  {
    return val.value;
  }

  public static implicit operator Base64Binary(byte[] val)
  {
    return new() { value = val };
  }

  public bool Equals(Base64Binary other)
  {
    return Enumerable.SequenceEqual(value, other.value);
  }

  public override int GetHashCode()
  {
    var result = value.Length;
    foreach (var item in value)
      result = HashCode.Combine(result, item);
    return result;
  }
}