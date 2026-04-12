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
   if (RedPortion is null || GreenPortion is null || BluePortion is null)
    return null;
   return (UInt32)(((RedPortion.Value * 255 / 100000) << 16) | ((GreenPortion.Value * 255 / 100000) << 8) | (BluePortion.Value * 255 / 100000));
  }

  set
  {
   if (value is null)
   {
    RedPortion = null;
    GreenPortion = null;
    BluePortion = null;
    return;
   }

   RedPortion = (Int32)System.Math.Round(((value.Value >> 16) & 0xFF) * 100000.0 / 255.0);
   GreenPortion = (Int32)System.Math.Round(((value.Value >> 8) & 0xFF) * 100000.0 / 255.0);
   BluePortion = (Int32)System.Math.Round((value.Value & 0xFF) * 100000.0 / 255.0);
  }
 }

  /// <summary>
  /// Red component of the color as percentage value.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
 public double? Red
 {
  get => this.RedPortion is null ? null : (double)(this.RedPortion / 100000.0);
  set
  {
   if (value is null)
    return;
   this.RedPortion = (Int32)System.Math.Round((double)value * 100000.0);
  }
 }

  /// <summary>
  /// Green component of the color as percentage value.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public double? Green
 {
  get => this.GreenPortion is null ? null : (double)(this.GreenPortion / 100000.0);
  set
  {
   if (value is null)
    return;
   this.GreenPortion = (Int32)System.Math.Round((double)value * 100000.0);
  }
 }

  /// <summary>
  /// Blue component of the color as percentage value.
  /// </summary>
  [NotMapped]
  [XmlIgnore]
  [JsonIgnore]
  public double? Blue
 {
  get => this.BluePortion is null ? null : (double)(this.BluePortion / 100000.0);
  set
  {
   if (value is null)
    return;
   this.BluePortion = (Int32)System.Math.Round((double)value * 100000.0);
  }
 }

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

 /// <summary>
 /// Tint modification of the color, represented as a percentage value between 0 and 1.
 /// </summary>
 double? IColor.Tint { get => this.Tint is null ? null : (double)(this.Tint / 100000.0); set => this.Tint = value is null ? null : (int? )System.Math.Round((double)(value.Value * 100000.0)); }

 /// <summary>
 /// Shade modification of the color, represented as a percentage value between 0 and 1.
 /// </summary>
 double? IColor.Shade { get => this.Shade is null ? null : (double)(this.Shade / 100000.0); set => this.Shade = value is null ? null : (int? )System.Math.Round((double)(value.Value * 100000.0)); }
}
