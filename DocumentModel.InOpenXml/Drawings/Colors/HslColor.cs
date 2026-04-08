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
  [OpenXmlProperty(nameof(DXD.HslColor.HueValue))]
  public Int32? HueValue { get => _HueValue; set => UpdateField(ref _HueValue, value, nameof(HueValue)); }
  private Int32? _HueValue;

  /// <summary>
  /// Base saturation value.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HslColor.SatValue))]
  public Int32? SatValue { get => _SatValue; set => UpdateField(ref _SatValue, value, nameof(SatValue)); }
  private Int32? _SatValue;

  /// <summary>
  /// Base luminance value.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.HslColor.LumValue))]
  public Int32? LumValue { get => _LumValue; set => UpdateField(ref _LumValue, value, nameof(LumValue)); }
  private Int32? _LumValue;
}