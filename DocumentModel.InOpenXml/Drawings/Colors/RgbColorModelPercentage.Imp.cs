namespace DocumentModel.Drawings;

public partial class RgbColorModelPercentage : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public UInt32? RGB
  {
    get
    {
      if (Red is null || Green is null || Blue is null)
        return null;
      return (UInt32)(((Red.Value * 255 / 100000) << 16) | ((Green.Value * 255 / 100000) << 8) | (Blue.Value * 255 / 100000));
    }

    set
    {
      if (value is null)
      {
        Red = null;
        Green = null;
        Blue = null;
        return;
      }

      Red = (Int32)System.Math.Round(((value.Value >> 16) & 0xFF) * 100000.0 / 255.0);
      Green = (Int32)System.Math.Round(((value.Value >> 8) & 0xFF) * 100000.0 / 255.0);
      Blue = (Int32)System.Math.Round((value.Value & 0xFF) * 100000.0 / 255.0);
    }
  }

  /// <summary>
  /// Red component of the color as percentage value.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  double? IColor.Red { get => Red; set => Red = value; }

  /// <summary>
  /// Green component of the color as percentage value.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  double? IColor.Green { get => Green; set => Green = value; } 


  /// <summary>
  /// Blue component of the color as percentage value.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  double? IColor.Blue { get => Blue; set => Blue = value; }

  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "red", "blue", etc.
  /// If the color is found in the PresetColors enumeration, the corresponding RGB value will be used.
  /// </summary>
  string? IColor.Name
  {
    get
    {
      if (this.RGB is not null)
      {
        var presetColorField = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => f.GetValue(null)?.Equals(this.RGB.Value) == true);
        return presetColorField?.Name;
      }

      return null;
    }

    set
    {
      if (value is null)
        return;
      if (Enum.TryParse<PresetColors>(value, out var presetColor))
      {
        this.RGB = (UInt32)presetColor;
        return;
      }

      throw new ArgumentException($"The provided color name '{value}' is not recognized as a valid theme color or preset color.");
    }
  }

}
