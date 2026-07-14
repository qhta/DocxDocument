namespace DocumentModel.Drawings;

public partial class ColorType: IColorHolder
{

  ///// <summary>
  ///// Gets or sets the ARGB value of the color. If the Color property is null, this property will return null. Setting this property will update the RGB value of the Color if it is not null.
  ///// </summary>
  //[XmlIgnore]
  //[JsonIgnore]
  //[NotMapped]
  //public uint ARGB
  //{
  //  get => ((InternalColor as IColor)?.ARGB) ?? (uint)PresetColors.Auto;
  //  set
  //  {
  //    if (InternalColor is IColor color) color.ARGB = value;
  //  }
  //}

  ///// <summary>
  ///// Gets or sets the RGBA components of the color as a tuple of four doubles (R, G, B, A).
  ///// If the Color property is null, this property will return (0, 0, 0, 0).
  ///// Setting this property will update the RGBA components of the Color if it is not null.
  ///// </summary>
  //[XmlIgnore]
  //[JsonIgnore]
  //[NotMapped]
  //public (double R, double G, double B, double A) RGBAComponents
  //{
  //  get => (InternalColor as IColor)?.RGBAComponents ?? (0, 0, 0, 0);
  //  set
  //  {
  //    if (InternalColor is IColor color) color.RGBAComponents = value;
  //  }
  //}

  ///// <summary>
  ///// Gets or sets the HSLA components of the color as a tuple of four doubles (H, S, L, A).
  ///// If the Color property is null, this property will return (0, 0, 0, 0).
  ///// Setting this property will update the HSLA components of the Color if it is not null.
  ///// </summary>
  //[XmlIgnore]
  //[JsonIgnore]
  //[NotMapped]
  //public (double H, double S, double L, double A) HSLAComponents
  //{
  //  get => (InternalColor as IColor)?.HSLAComponents ?? (0, 0, 0, 0);
  //  set
  //  {
  //    if (InternalColor is IColor color) color.HSLAComponents = value;
  //  }
  //}

  ///// <summary>
  ///// Gets or sets the name of the color. If the Color property is null, this property will return null. Setting this property will update the name of the Color if it is not null. 
  ///// </summary>
  //string? INamedColor.Name
  //{
  //  get => (InternalColor as INamedColor)?.Name;
  //  set
  //  {
  //    if (InternalColor is INamedColor color) color.Name = value;
  //  }
  //}

  ColorType? IColorHolder.Color { get => InternalColor as ColorType; set => InternalColor = value as IColor; }
}
