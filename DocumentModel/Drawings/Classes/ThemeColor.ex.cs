namespace DocumentModel.Drawings;

public partial class ThemeColor: Color2Type, INamedObject, IEquatable<ThemeColor>
{
  public string? Name { get; set; }

  [XmlIgnore]
  public Color2Type? Value
  {
    get => new Color2Type{ HslColor = HslColor, PresetColor = PresetColor, SystemColor = SystemColor,
      RgbColorModelHex = RgbColorModelHex, RgbColorModelPercentage = RgbColorModelPercentage};
    set
    {
      HslColor = value?.HslColor;
      PresetColor = value?.PresetColor;
      SystemColor = value?.SystemColor;
      RgbColorModelHex = value?.RgbColorModelHex;
      RgbColorModelPercentage = value?.RgbColorModelPercentage;
    }
    

  }

  public bool Equals(ThemeColor? other)
  {
    if (other == null)
      return false;
    return String.Equals(Name, other.Name) && Color2Type.Equals(Value, other.Value);
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(Name?.GetHashCode(), Value?.GetHashCode());
  }
}