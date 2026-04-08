namespace DocumentModel.Drawings;
/// <summary>
/// Represents a color using the Hue, Saturation, and Luminance (HSL) color model, with additional color adjustment properties.
/// </summary>
[OpenXmlType(typeof(DXD.HslColor))]
public partial class HslColor : DrawingColorBase<DXD.HslColor>, ISchemeBaseColor
{
 /// <summary>
 /// Base hue value.
 /// </summary>
 public Int32? HueValue { get; set; }
 /// <summary>
 /// Base saturation value.
 /// </summary>
 public Int32? SatValue { get; set; }
 /// <summary>
 /// Base luminance value.
 /// </summary>
 public Int32? LumValue { get; set; }
}