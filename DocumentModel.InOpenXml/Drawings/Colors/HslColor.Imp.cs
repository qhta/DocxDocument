namespace DocumentModel.Drawings;
public partial class HslColor : IColor
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
   if (HueValue is null || SatValue is null || LumValue is null)
    return null;
   var h = NormalizeHue(HueValue.Value / 60000.0);
   var s = Clamp01(SatValue.Value / 100000.0);
   var l = Clamp01(LumValue.Value / 100000.0);
   var c = (1.0 - System.Math.Abs(2.0 * l - 1.0)) * s;
   var x = c * (1.0 - System.Math.Abs((h / 60.0) % 2.0 - 1.0));
   var m = l - c / 2.0;
   var(r1, g1, b1) = h switch
   {
    < 60.0 => (c, x, 0.0),
    < 120.0 => (x, c, 0.0),
    < 180.0 => (0.0, c, x),
    < 240.0 => (0.0, x, c),
    < 300.0 => (x, 0.0, c),
    _ => (c, 0.0, x),
   };
   var r = (UInt32)System.Math.Round((r1 + m) * 255.0);
   var g = (UInt32)System.Math.Round((g1 + m) * 255.0);
   var b = (UInt32)System.Math.Round((b1 + m) * 255.0);
   return (r << 16) | (g << 8) | b;
  }

  set
  {
   if (value is null)
   {
    HueValue = null;
    SatValue = null;
    LumValue = null;
    return;
   }

   var r = ((value.Value >> 16) & 0xFF) / 255.0;
   var g = ((value.Value >> 8) & 0xFF) / 255.0;
   var b = (value.Value & 0xFF) / 255.0;
   var max = System.Math.Max(r, System.Math.Max(g, b));
   var min = System.Math.Min(r, System.Math.Min(g, b));
   var delta = max - min;
   var l = (max + min) / 2.0;
   var s = delta == 0.0 ? 0.0 : delta / (1.0 - System.Math.Abs(2.0 * l - 1.0));
   double h;
   if (delta == 0.0)
    h = 0.0;
   else if (max == r)
    h = 60.0 * (((g - b) / delta) % 6.0);
   else if (max == g)
    h = 60.0 * (((b - r) / delta) + 2.0);
   else
    h = 60.0 * (((r - g) / delta) + 4.0);
   h = NormalizeHue(h);
   HueValue = (Int32)System.Math.Round(h * 60000.0);
   SatValue = (Int32)System.Math.Round(Clamp01(s) * 100000.0);
   LumValue = (Int32)System.Math.Round(Clamp01(l) * 100000.0);
  }
 }

 private static double Clamp01(double value) => value < 0.0 ? 0.0 : value > 1.0 ? 1.0 : value;
 private static double NormalizeHue(double hue)
 {
  hue %= 360.0;
  return hue < 0.0 ? hue + 360.0 : hue;
 }

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
  get => this.RGB is null ? null : (double)(((this.RGB >> 16) & 0xFF) / 255.0);
  set
  {
   if (value is null)
    return;
   var red = (UInt32)System.Math.Round((double)value * 255.0);
   this.RGB = (UInt32)(this.RGB ?? 0) & 0x00FFFF | (red << 16);
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
  get => this.RGB is null ? null : (double)(((this.RGB >> 8) & 0xFF) / 255.0);
  set
  {
   if (value is null)
    return;
   var green = (UInt32)System.Math.Round((double)value * 255.0);
   this.RGB = (UInt32)(this.RGB ?? 0) & 0xFF00FF | (green << 8);
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
  get => this.RGB is null ? null : (double)((this.RGB & 0xFF) / 255.0);
  set
  {
   if (value is null)
    return;
   var blue = (UInt32)System.Math.Round((double)value * 255.0);
   this.RGB = (UInt32)(this.RGB ?? 0) & 0xFFFF00 | blue;
  }
 }

 /// <summary>
 /// Name of the color. It may be used to specify a color by name, such as "red", "blue", etc.
 /// If the color is found in the PresetColors enumeration, the corresponding RGB value will be used.
 /// </summary>
 [NotMapped]
 [XmlIgnore]
 [JsonIgnore]
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
 [NotMapped]
 [XmlIgnore]
 [JsonIgnore]
 double? IColor.Tint { get => this.Tint; set => this.Tint = value; }

 /// <summary>
 /// Shade modification of the color, represented as a percentage value between 0 and 1.
 /// </summary>
 [NotMapped]
 [XmlIgnore]
 [JsonIgnore]
 double? IColor.Shade { get => this.Shade; set => this.Shade = value; }
}
