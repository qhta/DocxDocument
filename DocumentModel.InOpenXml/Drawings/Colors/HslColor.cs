namespace DocumentModel.Drawings;
/// <summary>
/// Represents a color using the Hue, Saturation, and Luminance (HSL) color model, with additional color adjustment properties.
/// </summary>
[OpenXmlType(typeof(DXD.HslColor))]
[XmlRoot("HslColor", Namespace = "DocumentModel.Drawings")]
public partial class HslColor : DrawingsColorBase<DXD.HslColor>, ISchemeBaseColor, IDrawingColor
{
  
  /// <summary>
  /// Base hue value.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HslColor.HueValue))]
  public Degrees H { get => base.Hue ?? 0; set => base.Hue = value; }


  /// <summary>
  /// Base saturation value.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HslColor.SatValue))]
  public Percentage S { get => base.Saturation ?? 1.0; set => base.Saturation = value; }

  /// <summary>
  /// Base luminance value.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HslColor.LumValue))]
  public Percentage L { get => base.Luminance ?? 0; set => base.Luminance = value; }
}