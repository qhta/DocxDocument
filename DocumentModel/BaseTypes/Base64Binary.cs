namespace DocumentModel;

public struct Base64Binary
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
}