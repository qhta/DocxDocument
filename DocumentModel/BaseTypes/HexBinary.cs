namespace DocumentModel;

[TypeConverter(typeof(HexBinaryTypeXmlConverter))]
public record HexBinary
{
  private readonly byte[] value;

  public HexBinary(byte[] val)
  {
    value = val;
  }

  public HexBinary(string val)
  {
    if (val.Length % 2 != 0)
      throw new InvalidOperationException("HexBinary length must be even to convert from string to bytes");
    var result = new byte[val.Length / 2];
    for (var i = 0; i < result.Length; i++)
    {
      var b = Byte.Parse(val.Substring(i * 2, 2), NumberStyles.HexNumber);
      result[i] = b;
    }
    value = result;
  }

  //public static implicit operator string(HexBinary val) => val.ToString();

  public static implicit operator HexBinary(string val)
  {
    return new(val);
  }

  public static implicit operator byte[](HexBinary val)
  {
    return val.value;
  }

  public static implicit operator HexBinary(byte[] val)
  {
    return new HexBinary(val);
  }

  public static implicit operator byte(HexBinary val)
  {
    return val.value[0];
  }

  public static implicit operator HexBinary(byte val)
  {
    return new(new[] { val });
  }

  public static implicit operator ushort(HexBinary val)
  {
    return ushort.Parse(val.ToString(), NumberStyles.HexNumber, null);
  }

  public static implicit operator HexBinary(ushort val)
  {
    return new(val.ToString("X4"));
  }

  public static implicit operator int(HexBinary val)
  {
    return int.Parse(val.ToString(), NumberStyles.HexNumber, null);
  }

  public static implicit operator HexBinary(int val)
  {
    return new(val.ToString("X8"));
  }

  public static implicit operator uint(HexBinary val)
  {
    return uint.Parse(val.ToString(), NumberStyles.HexNumber, null);
  }

  public static implicit operator HexBinary(uint val)
  {
    return new(val.ToString("X8"));
  }

  public override string ToString()
  {
    var sb = new StringBuilder();
    foreach (var b in value)
    {
      var s = b.ToString("X2");
      sb.Append(s);
    }
    return sb.ToString();
  }
}