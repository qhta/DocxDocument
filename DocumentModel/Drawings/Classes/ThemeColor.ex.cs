namespace DocumentModel.Drawings;

public partial record ThemeColor: Color2Type, INamedObject
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

}