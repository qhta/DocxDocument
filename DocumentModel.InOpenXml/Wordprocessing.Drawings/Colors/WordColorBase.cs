namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a set of color modification operations that can be applied to a base color.
/// These modifications include tinting, shading, alpha transparency, hue/saturation/luminance adjustments
/// and so on.
/// </summary>
[XmlRoot("WordColorBase", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class WordColorBase<T> : AbstractColor<T> where T : DX.OpenXmlElement
{
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
 [OpenXmlElement(typeof(DXO10W.Tint))]
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
 [OpenXmlElement(typeof(DXO10W.Shade))]
 public Int32? Shade { get => _Shade; set => UpdateField(ref _Shade, value, nameof(Shade)); }

 private Int32? _Shade;
 /// <summary>
 /// Absolute alpha (transparency) value.
 /// </summary>
 /// <remarks>
 /// Specifies the opacity of the color where 0 is fully transparent and 100000 is fully opaque (100%).
 /// Values between create semi-transparent colors. If null, full opacity (100000) is assumed.
 /// </remarks>
 [OpenXmlElement(typeof(DXO10W.Alpha))]
 public Int32? Alpha { get => _Alpha; set => UpdateField(ref _Alpha, value, nameof(Alpha)); }

 private Int32? _Alpha;
 /// <summary>
 /// Hue modulation percentage.
 /// </summary>
 /// <remarks>
 /// Multiplies the base hue by this percentage. Used for relative hue adjustments.
 /// Range is 0 to 100000, where 100000 means no change.
 /// </remarks>
 [OpenXmlElement(typeof(DXO10W.HueModulation))]
 public Int32? HueModulation { get => _HueModulation; set => UpdateField(ref _HueModulation, value, nameof(HueModulation)); }

 private Int32? _HueModulation;
 /// <summary>
 /// Absolute saturation value in the HSL color space.
 /// </summary>
 /// <remarks>
 /// Specifies the color saturation where 0 is grayscale and 100000 is fully saturated (100%).
 /// Saturation determines the intensity or vividness of the color.
 /// </remarks>
 [OpenXmlElement(typeof(DXO10W.Saturation))]
 public Int32? Saturation { get => _Saturation; set => UpdateField(ref _Saturation, value, nameof(Saturation)); }

 private Int32? _Saturation;
 /// <summary>
 /// Saturation offset adjustment.
 /// </summary>
 /// <remarks>
 /// Adds or subtracts from the base saturation value. Range is typically -100000 to +100000.
 /// Positive values make colors more vivid, negative values make them more gray.
 /// </remarks>
 [OpenXmlElement(typeof(DXO10W.SaturationOffset))]
 public Int32? SaturationOffset { get => _SaturationOffset; set => UpdateField(ref _SaturationOffset, value, nameof(SaturationOffset)); }

 private Int32? _SaturationOffset;
 /// <summary>
 /// Saturation modulation percentage.
 /// </summary>
 /// <remarks>
 /// Multiplies the base saturation by this percentage. A value of 50000 (50%) reduces saturation by half.
 /// Range is 0 to 100000, where 100000 means no change. Commonly used to create muted color variations.
 /// </remarks>
 [OpenXmlElement(typeof(DXO10W.SaturationModulation))]
 public Int32? SaturationModulation { get => _SaturationModulation; set => UpdateField(ref _SaturationModulation, value, nameof(SaturationModulation)); }

 private Int32? _SaturationModulation;
 /// <summary>
 /// Absolute luminance value in the HSL color space.
 /// </summary>
 /// <remarks>
 /// Specifies the brightness where 0 is black, 50000 is the color at normal brightness (50%), 
 /// and 100000 is white. Luminance determines how light or dark the color appears.
 /// </remarks>
 [OpenXmlElement(typeof(DXO10W.Luminance))]
 public Int32? Luminance { get => _Luminance; set => UpdateField(ref _Luminance, value, nameof(Luminance)); }

 private Int32? _Luminance;
 /// <summary>
 /// Luminance offset adjustment.
 /// </summary>
 /// <remarks>
 /// Adds or subtracts from the base luminance value. Range is typically -100000 to +100000.
 /// Positive values make colors lighter, negative values make them darker.
 /// </remarks>
 [OpenXmlElement(typeof(DXO10W.LuminanceOffset))]
 public Int32? LuminanceOffset { get => _LuminanceOffset; set => UpdateField(ref _LuminanceOffset, value, nameof(LuminanceOffset)); }

 private Int32? _LuminanceOffset;
 /// <summary>
 /// Luminance modulation percentage.
 /// </summary>
 /// <remarks>
 /// Multiplies the base luminance by this percentage. A value of 50000 (50%) reduces brightness by half.
 /// Range is 0 to 100000, where 100000 means no change. Commonly used to create lighter or darker variations.
 /// </remarks>
 [OpenXmlElement(typeof(DXO10W.LuminanceModulation))]
 public Int32? LuminanceModulation { get => _LuminanceModulation; set => UpdateField(ref _LuminanceModulation, value, nameof(LuminanceModulation)); }

 private Int32? _LuminanceModulation;
}