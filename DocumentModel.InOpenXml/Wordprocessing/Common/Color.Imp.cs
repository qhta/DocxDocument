namespace DocumentModel.Wordprocessing;
public partial class Color : IColor
{
 /// <summary>
 /// Gets or sets the RGB+ value represented by this property.
 /// </summary>
 UInt32? IColor.RGB { get => this.Val; set => this.Val = value; }

 /// <summary>
 /// Red component of the color as percentage value.
 /// The value is between 0 and 1, where 0 represents no red and 1 represents full red (255 in RGB).
 /// This is derived from the RGB+ value, where the red component is extracted and converted to a percentage.
 /// Setting this property will update the RGB+ value accordingly, modifying only the red component while preserving the green and blue components.
 /// </summary>
 float? IColor.Red
 {
  get => this.Val is null ? null : (float)(((this.Val >> 16) & 0xFF) / 255.0);
  set
  {
   if (value is null)
    return;
   var red = (UInt32)System.Math.Round((double)value * 255.0);
   this.Val = (UInt32)(this.Val ?? 0) & 0x00FFFF | (red << 16);
  }
 }

 /// <summary>
 /// Green component of the color as percentage value.
 /// The value is between 0 and 1, where 0 represents no green and 1 represents full green (255 in RGB).
 /// This is derived from the RGB+ value, where the green component is extracted and converted to a percentage.
 /// Setting this property will update the RGB+ value accordingly, modifying only the green component while preserving the red and blue components.
 /// </summary>
 float? IColor.Green
 {
  get => this.Val is null ? null : (float)(((this.Val >> 8) & 0xFF) / 255.0);
  set
  {
   if (value is null)
    return;
   var green = (UInt32)System.Math.Round((double)value * 255.0);
   this.Val = (UInt32)(this.Val ?? 0) & 0xFF00FF | (green << 8);
  }
 }

 /// <summary>
 /// Blue component of the color as percentage value.
 /// The value is between 0 and 1, where 0 represents no blue and 1 represents full blue (255 in RGB).
 /// This is derived from the RGB+ value, where the blue component is extracted and converted to a percentage.
 /// Setting this property will update the RGB+ value accordingly, modifying only the blue component while preserving the red and green components.
 /// </summary>
 float? IColor.Blue
 {
  get => this.Val is null ? null : (float)((this.Val & 0xFF) / 255.0);
  set
  {
   if (value is null)
    return;
   var blue = (UInt32)System.Math.Round((double)value * 255.0);
   this.Val = (UInt32)(this.Val ?? 0) & 0xFFFF00 | blue;
  }
 }

 /// <summary>
 /// Gets or sets the name of the color represented by this property.
 /// It may be used to specify a color by name, such as "red", "blue", etc. The actual interpretation of the name depends on the context in which it is used and may be mapped to a specific RGB value or theme color.
 /// </summary>
 string? IColor.Name
 {
  get
  {
   if (this.ThemeColor is not null)
    return this.ThemeColor.ToString();
   if (this.Val is not null)
   {
    var presetColorField = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(f => f.GetValue(null)?.Equals(this.Val.Value) == true);
    return presetColorField?.Name;
   }

   return null;
  }

  set
  {
   if (value is null)
    this.ThemeColor = null;
   if (Enum.TryParse<ThemeColors>(this.Val.ToString(), out var themeColor))
    this.ThemeColor = themeColor;
   if (Enum.TryParse<PresetColors>(this.Val.ToString(), out var presetColor))
    this.Val = (UInt32)presetColor;
   throw new ArgumentException($"The provided color name '{value}' is not recognized as a valid theme color or preset color.");
  }
 }

 /// <summary>
 /// Gets or sets the theme tint represented by this property.
 /// </summary>
 /// <remarks>
 /// Given an RGB color defined as three hex values in RRGGBB format, the shade is applied as follows:
 /// <list type="bullet">
 /// <item>Convert the color to the HSL color format (values from 0 to 1)</item>
 /// <item>Modify the luminance factor as follows:  Lâ€˛ = Tint_percentage + (1 â’ Tint_percentage)</item>
 /// <item>Convert the resultant HSL color to RGB</item>
 /// </list> 
 /// </remarks> 
 float? IColor.Tint { get => this.ThemeTint is null ? null : 1 - (float)(this.ThemeTint / 255.0); set => ThemeTint = value is null ? null : (byte)System.Math.Round(1 - (double)value * 255.0); }

 /// <summary>
 /// Gets or sets the theme shade represented by this property.
 /// </summary>
 /// <remarks>
 /// Given an RGB color defined as three hex values in RRGGBB format, the shade is applied as follows:
 /// <list type="bullet">
 /// <item>Convert the color to the HSL color format (values from 0 to 1)</item>
 /// <item>Modify the luminance factor as follows:  Lâ€˛ =L* Shade_percentage </item>
 /// <item>Convert the resultant HSL color to RGB</item>
 /// </list>
 /// </remarks>  
 float? IColor.Shade { get => this.ThemeShade is null ? null : (float)(this.ThemeShade / 255.0); set => ThemeShade = value is null ? null : (byte)System.Math.Round((double)value * 255.0); }
}
