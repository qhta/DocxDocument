namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Represents a style color configuration for chart elements, supporting value, tint, shade, alpha, hue, saturation, luminance, color channels, and various color effects.
/// </summary>
[OpenXmlType(typeof(DXO13DCS.StyleColor))]
[DataContract]
[XmlRoot("StyleColor", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class StyleColor : ModelElement<DXO13DCS.StyleColor>
{
  /// <summary>
  /// String value representing the color code or name.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DCS.StyleColor.Val))]
  public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
  private string? _Val;

  /// <summary>
  /// Tint adjustment value for the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Tint))]
  public Int32? Tint { get => _Tint; set => UpdateField(ref _Tint, value, nameof(Tint)); }
  private Int32? _Tint;

  /// <summary>
  /// Shade adjustment value for the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Shade))]
  public Int32? Shade { get => _Shade; set => UpdateField(ref _Shade, value, nameof(Shade)); }
  private Int32? _Shade;

  /// <summary>
  /// Indicates if the complement of the color is used.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Complement))]
  public Boolean? Complement { get => _Complement; set => UpdateField(ref _Complement, value, nameof(Complement)); }
  private Boolean? _Complement;

  /// <summary>
  /// Indicates if the inverse of the color is used.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Inverse))]
  public Boolean? Inverse { get => _Inverse; set => UpdateField(ref _Inverse, value, nameof(Inverse)); }
  private Boolean? _Inverse;

  /// <summary>
  /// Indicates if the color is converted to grayscale.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Gray))]
  public Boolean? Gray { get => _Gray; set => UpdateField(ref _Gray, value, nameof(Gray)); }
  private Boolean? _Gray;

  /// <summary>
  /// Alpha (opacity) value for the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Alpha))]
  public Int32? Alpha { get => _Alpha; set => UpdateField(ref _Alpha, value, nameof(Alpha)); }
  private Int32? _Alpha;

  /// <summary>
  /// Offset applied to the alpha value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.AlphaOffset))]
  public Int32? AlphaOffset { get => _AlphaOffset; set => UpdateField(ref _AlphaOffset, value, nameof(AlphaOffset)); }
  private Int32? _AlphaOffset;

  /// <summary>
  /// Modulation factor for the alpha value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.AlphaModulation))]
  public Int32? AlphaModulation { get => _AlphaModulation; set => UpdateField(ref _AlphaModulation, value, nameof(AlphaModulation)); }
  private Int32? _AlphaModulation;

  /// <summary>
  /// Hue value for the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Hue))]
  public Int32? Hue { get => _Hue; set => UpdateField(ref _Hue, value, nameof(Hue)); }
  private Int32? _Hue;

  /// <summary>
  /// Offset applied to the hue value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.HueOffset))]
  public Int32? HueOffset { get => _HueOffset; set => UpdateField(ref _HueOffset, value, nameof(HueOffset)); }
  private Int32? _HueOffset;

  /// <summary>
  /// Modulation factor for the hue value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.HueModulation))]
  public Int32? HueModulation { get => _HueModulation; set => UpdateField(ref _HueModulation, value, nameof(HueModulation)); }
  private Int32? _HueModulation;

  /// <summary>
  /// Saturation value for the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Saturation))]
  public Int32? Saturation { get => _Saturation; set => UpdateField(ref _Saturation, value, nameof(Saturation)); }
  private Int32? _Saturation;

  /// <summary>
  /// Offset applied to the saturation value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.SaturationOffset))]
  public Int32? SaturationOffset { get => _SaturationOffset; set => UpdateField(ref _SaturationOffset, value, nameof(SaturationOffset)); }
  private Int32? _SaturationOffset;

  /// <summary>
  /// Modulation factor for the saturation value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.SaturationModulation))]
  public Int32? SaturationModulation { get => _SaturationModulation; set => UpdateField(ref _SaturationModulation, value, nameof(SaturationModulation)); }
  private Int32? _SaturationModulation;

  /// <summary>
  /// Luminance value for the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Luminance))]
  public Int32? Luminance { get => _Luminance; set => UpdateField(ref _Luminance, value, nameof(Luminance)); }
  private Int32? _Luminance;

  /// <summary>
  /// Offset applied to the luminance value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.LuminanceOffset))]
  public Int32? LuminanceOffset { get => _LuminanceOffset; set => UpdateField(ref _LuminanceOffset, value, nameof(LuminanceOffset)); }
  private Int32? _LuminanceOffset;

  /// <summary>
  /// Modulation factor for the luminance value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.LuminanceModulation))]
  public Int32? LuminanceModulation { get => _LuminanceModulation; set => UpdateField(ref _LuminanceModulation, value, nameof(LuminanceModulation)); }
  private Int32? _LuminanceModulation;

  /// <summary>
  /// Red channel value for the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Red))]
  public Int32? Red { get => _Red; set => UpdateField(ref _Red, value, nameof(Red)); }
  private Int32? _Red;

  /// <summary>
  /// Offset applied to the red channel value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.RedOffset))]
  public Int32? RedOffset { get => _RedOffset; set => UpdateField(ref _RedOffset, value, nameof(RedOffset)); }
  private Int32? _RedOffset;

  /// <summary>
  /// Modulation factor for the red channel value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.RedModulation))]
  public Int32? RedModulation { get => _RedModulation; set => UpdateField(ref _RedModulation, value, nameof(RedModulation)); }
  private Int32? _RedModulation;

  /// <summary>
  /// Green channel value for the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Green))]
  public Int32? Green { get => _Green; set => UpdateField(ref _Green, value, nameof(Green)); }
  private Int32? _Green;

  /// <summary>
  /// Offset applied to the green channel value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.GreenOffset))]
  public Int32? GreenOffset { get => _GreenOffset; set => UpdateField(ref _GreenOffset, value, nameof(GreenOffset)); }
  private Int32? _GreenOffset;

  /// <summary>
  /// Modulation factor for the green channel value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.GreenModulation))]
  public Int32? GreenModulation { get => _GreenModulation; set => UpdateField(ref _GreenModulation, value, nameof(GreenModulation)); }
  private Int32? _GreenModulation;

  /// <summary>
  /// Blue channel value for the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Blue))]
  public Int32? Blue { get => _Blue; set => UpdateField(ref _Blue, value, nameof(Blue)); }
  private Int32? _Blue;

  /// <summary>
  /// Offset applied to the blue channel value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.BlueOffset))]
  public Int32? BlueOffset { get => _BlueOffset; set => UpdateField(ref _BlueOffset, value, nameof(BlueOffset)); }
  private Int32? _BlueOffset;

  /// <summary>
  /// Modulation factor for the blue channel value.
  /// </summary>
  [OpenXmlElement(typeof(DXD.BlueModulation))]
  public Int32? BlueModulation { get => _BlueModulation; set => UpdateField(ref _BlueModulation, value, nameof(BlueModulation)); }
  private Int32? _BlueModulation;

  /// <summary>
  /// Indicates if gamma correction is applied to the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Gamma))]
  public Boolean Gamma { get => _Gamma; set => UpdateField(ref _Gamma, value, nameof(Gamma)); }
  private Boolean _Gamma;

  /// <summary>
  /// Indicates if inverse gamma correction is applied to the color.
  /// </summary>
  [OpenXmlElement(typeof(DXD.InverseGamma))]
  public Boolean InverseGamma { get => _InverseGamma; set => UpdateField(ref _InverseGamma, value, nameof(InverseGamma)); }
  private Boolean _InverseGamma;
}