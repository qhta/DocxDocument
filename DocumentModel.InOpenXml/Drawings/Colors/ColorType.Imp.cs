namespace DocumentModel.Drawings;

public partial class ColorType : IColor
{

  /// <summary>
  /// Gets or sets the RGB value of the color. If the Color property is null, this property will return null. Setting this property will update the RGB value of the Color if it is not null.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public uint? RGB
  {
    get => (InternalColor as IColor)?.RGB;
    set
    {
      if (InternalColor is IColor color) color.RGB = value;
    }
  }

  /// <summary>
  /// Gets or sets the RGB components of the color as a tuple of three doubles (R, G, B). If the Color property is null, this property will return (0, 0, 0). Setting this property will update the RGB components of the Color if it is not null.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public (double R, double G, double B) RGBComponents
  {
    get => (InternalColor as IColor)?.RGBComponents ?? (0, 0, 0);
    set
    {
      if (InternalColor is IColor color) color.RGBComponents = value;
    }
  }

  /// <summary>
  /// Gets or sets the HSL components of the color as a tuple of three doubles (H, S, L). If the Color property is null, this property will return (0, 0, 0). Setting this property will update the HSL components of the Color if it is not null.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public (double H, double S, double L) HSLComponents
  {
    get => (InternalColor as IColor)?.HSLComponents ?? (0, 0, 0);
    set
    {
      if (InternalColor is IColor color) color.HSLComponents = value;
    }
  }

  /// <summary>
  /// Gets or sets the name of the color. If the Color property is null, this property will return null. Setting this property will update the name of the Color if it is not null. 
  /// </summary>
  string? IColor.Name
  {
    get => (InternalColor as IColor)?.Name;
    set
    {
      if (InternalColor is IColor color) color.Name = value;
    }
  }

}
