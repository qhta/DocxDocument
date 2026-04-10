namespace DocumentModel.Drawings;
/// <summary>
/// Represents a color using the Hue, Saturation, and Luminance (HSL) color model, with additional color adjustment properties.
/// </summary>
[OpenXmlType(typeof(DXD.HslColor))]
public partial class HslColor : AbstractColor<DXD.HslColor>, ISchemeBaseColor
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

  /// <summary>
  /// Tint value to lighten the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A tint value lightens the base color by mixing it with white. 
  /// Values range from 0 to 100000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no tint applied (original color)</description></item>
  /// <item><description>50000 = 50% tint (color mixed 50/50 with white)</description></item>
  /// <item><description>100000 = 100% tint (fully white)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If the value is <see langword="null"/>, no tint is applied. 
  /// Tint and shade are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Tint))]
  public Int32? Tint { get => _Tint; set => UpdateField(ref _Tint, value, nameof(Tint)); }
  private Int32? _Tint;

  /// <summary>
  /// Shade value to darken the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A shade value darkens the base color by mixing it with black.
  /// Values range from 0 to 100000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no shade applied (original color)</description></item>
  /// <item><description>50000 = 50% shade (color mixed 50/50 with black)</description></item>
  /// <item><description>100000 = 100% shade (fully black)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Shade and tint are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Shade))]
  public Int32? Shade { get => _Shade; set => UpdateField(ref _Shade, value, nameof(Shade)); }
  private Int32? _Shade;
}