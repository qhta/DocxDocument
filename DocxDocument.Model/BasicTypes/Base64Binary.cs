namespace DocxDocument.Model;

public struct Base64Binary
{
  private byte[] value;

  public static implicit operator string(Base64Binary val) => Convert.ToBase64String(val.value);


  public static implicit operator Base64Binary(string val) => new Base64Binary { value = Convert.FromBase64String(val) };

  public static implicit operator byte[](Base64Binary val) => val.value;

  public static implicit operator Base64Binary(byte[] val) => new Base64Binary { value = val };
}