namespace DocumentModel.Drawings;

public partial class PresetColor: IColor
{
  /// <summary>
  /// Value of the color as RGB uint.
  /// </summary>
  [NotMapped]
  public UInt32? RGB
  {
    get => this.Val is null ? null : (UInt32)this.Val!;
    set
    {
      if (value == null)
      {
        this.Val = null;
        return;
      }
      var presetColorFields = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static)
        .ToDictionary(f => f.Name, f => (UInt32)f.GetValue(null)!);

      var presetColorField = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static)
        .FirstOrDefault(f => ((UInt32)f.GetValue(null)!).Equals(value) == true);
      if (presetColorField != null)
      {
        this.Val = (PresetColors)presetColorField.GetValue(null)!;
        return;
      }
      else
        throw new ArgumentException($"The provided RGB value '{((uint)value):X6}' does not correspond to any known preset color.");
    }
  }


  /// <summary>
  /// Red component of the color as percentage value.
  /// The value is between 0 and 1, where 0 represents no red and 1 represents full red (255 in RGB).
  /// This is derived from the RGB+ value, where the red component is extracted and converted to a percentage.
  /// Setting this property will update the RGB+ value accordingly, modifying only the red component while preserving the green and blue components.
  /// </summary>
  float? IColor.Red
  {
    get => this.RGB is null ? null : (float)(((this.RGB >> 16) & 0xFF) / 255.0);
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
  float? IColor.Green
  {
    get => this.RGB is null ? null : (float)(((this.RGB >> 8) & 0xFF) / 255.0);
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
  float? IColor.Blue
  {
    get => this.RGB is null ? null : (float)((this.RGB & 0xFF) / 255.0);
    set
    {
      if (value is null)
        return;
      var blue = (UInt32)System.Math.Round((double)value * 255.0);
      this.RGB = (UInt32)(this.RGB ?? 0) & 0xFFFF00 | blue;
    }
  }

  /// <summary>
  /// Name of the color. It may be used to specify a color by name, such as "Red", "Blunot e", etc.
  /// If the color is found in the PresetColors enumeration, the exception is raised.
  /// </summary>
  string? IColor.Name
  {
    get
    {
      if (this.RGB is not null)
      {
        var presetColorField = typeof(PresetColors).GetFields(BindingFlags.Public | BindingFlags.Static)
          .FirstOrDefault(f => f.GetValue(null)?.Equals(this.RGB.Value) == true);
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
        this.Val = presetColor;
        return;
      }
      throw new ArgumentException($"The provided color name '{value}' is not recognized as a valid preset color.");
    }
  }

  /// <summary>
  /// Tint modification of the color, represented as a percentage value between 0 and 1.
  /// </summary>
  float? IColor.Tint
  {
    get => this.Tint is null ? null : (float)(this.Tint / 100000.0);
    set => this.Tint = value is null ? null : (int?)System.Math.Round((double)(value.Value * 100000.0));
  }

  /// <summary>
  /// Shade modification of the color, represented as a percentage value between 0 and 1.
  /// </summary>
  float? IColor.Shade
  {
    get => this.Shade is null ? null : (float)(this.Shade / 100000.0);
    set => this.Shade = value is null ? null : (int?)System.Math.Round((double)(value.Value * 100000.0));
  }
}