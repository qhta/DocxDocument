namespace DocumentModel;

public record HexBinary
{
  private byte[] value;

  //public static implicit operator string(HexBinary val) => val.ToString();


  public static implicit operator HexBinary(string val) => new HexBinary (val);


  public static implicit operator byte[](HexBinary val) => val.value;

  public static implicit operator HexBinary(byte[] val) => new HexBinary(val);


  public static implicit operator byte(HexBinary val) => val.value[0];

  public static implicit operator HexBinary(byte val) => new HexBinary(new byte[] { val });


  public static implicit operator ushort(HexBinary val) => ushort.Parse(val.ToString(), NumberStyles.HexNumber, null);

  public static implicit operator HexBinary(ushort val) => new HexBinary(val.ToString("X4"));

  public static implicit operator int(HexBinary val) => int.Parse(val.ToString(), NumberStyles.HexNumber, null);

  public static implicit operator HexBinary(int val) => new HexBinary(val.ToString("X8"));


  public static implicit operator uint(HexBinary val) => uint.Parse(val.ToString(), NumberStyles.HexNumber, null);

  public static implicit operator HexBinary(uint val) => new HexBinary(val.ToString("X8"));

  public HexBinary (string val)
  {
    if (val.Length % 2 != 0)
      throw new InvalidOperationException($"HexBinary length must be even to convert from string to bytes");
    var result = new byte[val.Length /2];
    for (int i = 0; i < result.Length; i++)
    {
      var b = Byte.Parse(val.Substring(i*2, 2), System.Globalization.NumberStyles.HexNumber);
      result[i] = b;
    }
    value = result;
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