namespace DocumentModel.Wordprocessing;

public partial class RgbColorHex : IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public UInt32? RGB { get => this.Value is null ? null : (UInt32)this.Value!; set => this.Value = value; }

  /// <summary>
  /// Red component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no red and 1 represents full red (255 in RGB).
  /// This is derived from the RGB+ value, where the red component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the red component while preserving the green and blue components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  double? IColor.Red
  {
    get => this.Value is null ? null : (double)(((this.Value >> 16) & 0xFF) / 255.0);
    set
    {
      if (value is null)
        return;
      var red = (UInt32)System.Math.Round((double)value * 255.0);
      this.Value = (UInt32)(this.Value ?? 0) & 0x00FFFF | (red << 16);
    }
  }

  /// <summary>
  /// Green component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no green and 1 represents full green (255 in RGB).
  /// This is derived from the RGB+ value, where the green component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the green component while preserving the red and blue components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  double? IColor.Green
  {
    get => this.Value is null ? null : (double)(((this.Value >> 8) & 0xFF) / 255.0);
    set
    {
      if (value is null)
        return;
      var green = (UInt32)System.Math.Round((double)value * 255.0);
      this.Value = (UInt32)(this.Value ?? 0) & 0xFF00FF | (green << 8);
    }
  }

  /// <summary>
  /// Blue component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no blue and 1 represents full blue (255 in RGB).
  /// This is derived from the RGB+ value, where the blue component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the blue component while preserving the red and green components.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  double? IColor.Blue
  {
    get => this.Value is null ? null : (double)((this.Value & 0xFF) / 255.0);
    set
    {
      if (value is null)
        return;
      var blue = (UInt32)System.Math.Round((double)value * 255.0);
      this.Value = (UInt32)(this.Value ?? 0) & 0xFFFF00 | blue;
    }
  }

  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "Red", "Blue", etc
  /// or a scheme color name like "Accent1", "Accent2", etc.
  /// If the color is not found in the PresetColors enumeration, the exception is raised.
  /// </summary>
  string? IColor.Name
  {
    get
    {
      if (this.Value is not null)
      {
        var presetColorField = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => f.GetValue(null)?.Equals(this.Value.Value) == true);
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
        this.Value = (UInt32)presetColor;
        return;
      }

      throw new ArgumentException($"The provided color name '{value}' is not recognized as a valid theme color or preset color.");
    }
  }

}
