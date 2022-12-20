namespace DocxDocument.Model;

public struct Color
{
  [XmlIgnore]
  [JsonIgnore]
  public byte R { get; set; }
  [XmlIgnore]
  [JsonIgnore]
  public byte G { get; set; }
  [XmlIgnore]
  [JsonIgnore]
  public byte B { get; set; }

  public int Val
  {
    get => R << 24 | G << 16 | B;

    set
    {
      R = (byte)(value >> 24);
      G = (byte)(value >> 16);
      B = (byte)value;
    }
  }

  public string? Name
  {
    get
    {
      var val = Val;
      foreach (var colorEnum in typeof(NamedColors).GetFields(BindingFlags.Static))
      {
        if ((int)colorEnum.GetValue(null) == val)
          return colorEnum.Name;
      }
      return null;
    }
    set
    {
      foreach (var colorEnum in typeof(NamedColors).GetFields(BindingFlags.Static))
      {
        if (colorEnum.Name == value)
          Val = (int)colorEnum.GetValue(null);
      }
    }
  }
}