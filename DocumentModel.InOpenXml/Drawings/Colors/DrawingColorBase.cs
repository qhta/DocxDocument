namespace DocumentModel.Drawings;
/// <summary>
/// Represents a set of color modification operations that can be applied to a base color.
/// These modifications include tinting, shading, alpha transparency, hue/saturation/luminance adjustments
/// and so on.
/// </summary>
public partial class DrawingColorBase<T> : AbstractColor<T> where T : DX.OpenXmlElement
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
  /// <summary>
  /// Gets or sets a value indicating whether the complement (opposite) color operation is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, the color is transformed to its complement value on the color wheel
  /// (e.g., red becomes cyan, green becomes magenta). Default is <see langword="false"/>.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Complement))]
  public Boolean? Complement { get => _Complement; set => UpdateField(ref _Complement, value, nameof(Complement)); }

  private Boolean? _Complement;
  /// <summary>
  /// Gets or sets a value indicating whether the color inversion operation is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, each RGB component is inverted (255 - value),
  /// creating a negative effect. Default is <see langword="false"/>.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Inverse))]
  public Boolean? Inverse { get => _Inverse; set => UpdateField(ref _Inverse, value, nameof(Inverse)); }

  private Boolean? _Inverse;
  /// <summary>
  /// Gets or sets a value indicating whether the color is converted to grayscale.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, the color is desaturated to create a grayscale value
  /// based on the perceived luminance of the original color. Default is <see langword="false"/>.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Gray))]
  public Boolean? Gray { get => _Gray; set => UpdateField(ref _Gray, value, nameof(Gray)); }

  private Boolean? _Gray;
  /// <summary>
  /// Absolute alpha (transparency) value.
  /// </summary>
  /// <remarks>
  /// Specifies the opacity of the color where 0 is fully transparent and 100000 is fully opaque (100%).
  /// Values between create semi-transparent colors. If null, full opacity (100000) is assumed.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Alpha))]
  public Int32? Alpha { get => _Alpha; set => UpdateField(ref _Alpha, value, nameof(Alpha)); }

  private Int32? _Alpha;
  /// <summary>
  /// Alpha (transparency) offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the base alpha value. Range is typically -100000 to +100000.
  /// Positive values increase opacity, negative values increase transparency.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.AlphaOffset))]
  public Int32? AlphaOffset { get => _AlphaOffset; set => UpdateField(ref _AlphaOffset, value, nameof(AlphaOffset)); }

  private Int32? _AlphaOffset;
  /// <summary>
  /// Alpha (transparency) modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base alpha by this percentage. A value of 50000 (50%) makes the color twice as transparent.
  /// Range is 0 to 100000, where 100000 means no change.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.AlphaModulation))]
  public Int32? AlphaModulation { get => _AlphaModulation; set => UpdateField(ref _AlphaModulation, value, nameof(AlphaModulation)); }

  private Int32? _AlphaModulation;
  /// <summary>
  /// Absolute hue value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the hue angle in degrees (0-360), represented as 0-21600000 units (1/60000th of a degree).
  /// Hue represents the color's position on the color wheel: 0=red, 60=yellow, 120=green, 180=cyan, 240=blue, 300=magenta.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Hue))]
  public Int32? Hue { get => _Hue; set => UpdateField(ref _Hue, value, nameof(Hue)); }

  private Int32? _Hue;
  /// <summary>
  /// Hue offset adjustment in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the base hue value to shift the color around the color wheel.
  /// Values wrap around (adding 360 degrees returns to the same hue).
  /// </remarks>
  [OpenXmlElement(typeof(DXD.HueOffset))]
  public Int32? HueOffset { get => _HueOffset; set => UpdateField(ref _HueOffset, value, nameof(HueOffset)); }

  private Int32? _HueOffset;
  /// <summary>
  /// Hue modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base hue by this percentage. Used for relative hue adjustments.
  /// Range is 0 to 100000, where 100000 means no change.
  /// </remarks>
  public Int32? HueModulation { get => _HueModulation; set => UpdateField(ref _HueModulation, value, nameof(HueModulation)); }

  private Int32? _HueModulation;
  /// <summary>
  /// Absolute saturation value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the color saturation where 0 is grayscale and 100000 is fully saturated (100%).
  /// Saturation determines the intensity or vividness of the color.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Saturation))]
  public Int32? Saturation { get => _Saturation; set => UpdateField(ref _Saturation, value, nameof(Saturation)); }

  private Int32? _Saturation;
  /// <summary>
  /// Saturation offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the base saturation value. Range is typically -100000 to +100000.
  /// Positive values make colors more vivid, negative values make them more gray.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.SaturationOffset))]
  public Int32? SaturationOffset { get => _SaturationOffset; set => UpdateField(ref _SaturationOffset, value, nameof(SaturationOffset)); }

  private Int32? _SaturationOffset;
  /// <summary>
  /// Saturation modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base saturation by this percentage. A value of 50000 (50%) reduces saturation by half.
  /// Range is 0 to 100000, where 100000 means no change. Commonly used to create muted color variations.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.SaturationModulation))]
  public Int32? SaturationModulation { get => _SaturationModulation; set => UpdateField(ref _SaturationModulation, value, nameof(SaturationModulation)); }

  private Int32? _SaturationModulation;
  /// <summary>
  /// Absolute luminance value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the brightness where 0 is black, 50000 is the color at normal brightness (50%), 
  /// and 100000 is white. Luminance determines how light or dark the color appears.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Luminance))]
  public Int32? Luminance { get => _Luminance; set => UpdateField(ref _Luminance, value, nameof(Luminance)); }

  private Int32? _Luminance;
  /// <summary>
  /// Luminance offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the base luminance value. Range is typically -100000 to +100000.
  /// Positive values make colors lighter, negative values make them darker.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.LuminanceOffset))]
  public Int32? LuminanceOffset { get => _LuminanceOffset; set => UpdateField(ref _LuminanceOffset, value, nameof(LuminanceOffset)); }

  private Int32? _LuminanceOffset;
  /// <summary>
  /// Luminance modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base luminance by this percentage. A value of 50000 (50%) reduces brightness by half.
  /// Range is 0 to 100000, where 100000 means no change. Commonly used to create lighter or darker variations.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.LuminanceModulation))]
  public Int32? LuminanceModulation { get => _LuminanceModulation; set => UpdateField(ref _LuminanceModulation, value, nameof(LuminanceModulation)); }

  private Int32? _LuminanceModulation;
  /// <summary>
  /// Absolute red channel value.
  /// </summary>
  /// <remarks>
  /// Overrides the red component (0-100000 representing 0-255). 
  /// Use this to set an explicit red value independent of the base RGB color.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Red))]
  public Int32? Red { get => _Red; set => UpdateField(ref _Red, value, nameof(Red)); }

  private Int32? _Red;
  /// <summary>
  /// Red channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the red channel value. Range is typically -100000 to +100000.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.RedOffset))]
  public Int32? RedOffset { get => _RedOffset; set => UpdateField(ref _RedOffset, value, nameof(RedOffset)); }

  private Int32? _RedOffset;
  /// <summary>
  /// Red channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base red channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the red component by half.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.RedModulation))]
  public Int32? RedModulation { get => _RedModulation; set => UpdateField(ref _RedModulation, value, nameof(RedModulation)); }

  private Int32? _RedModulation;
  /// <summary>
  /// Absolute green channel value.
  /// </summary>
  /// <remarks>
  /// Overrides the green component (0-100000 representing 0-255).
  /// Use this to set an explicit green value independent of the base RGB color.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Green))]
  public Int32? Green { get => _Green; set => UpdateField(ref _Green, value, nameof(Green)); }

  private Int32? _Green;
  /// <summary>
  /// Green channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the green channel value. Range is typically -100000 to +100000.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.GreenOffset))]
  public Int32? GreenOffset { get => _GreenOffset; set => UpdateField(ref _GreenOffset, value, nameof(GreenOffset)); }

  private Int32? _GreenOffset;
  /// <summary>
  /// Green channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base green channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the green component by half.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.GreenModulation))]
  public Int32? GreenModulation { get => _GreenModulation; set => UpdateField(ref _GreenModulation, value, nameof(GreenModulation)); }

  private Int32? _GreenModulation;
  /// <summary>
  /// Absolute blue channel value.
  /// </summary>
  /// <remarks>
  /// Overrides the blue component (0-100000 representing 0-255).
  /// Use this to set an explicit blue value independent of the base RGB color.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Blue))]
  public Int32? Blue { get => _Blue; set => UpdateField(ref _Blue, value, nameof(Blue)); }

  private Int32? _Blue;
  /// <summary>
  /// Blue channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the blue channel value. Range is typically -100000 to +100000.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.BlueOffset))]
  public Int32? BlueOffset { get => _BlueOffset; set => UpdateField(ref _BlueOffset, value, nameof(BlueOffset)); }

  private Int32? _BlueOffset;
  /// <summary>
  /// Blue channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base blue channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the blue component by half.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.BlueModulation))]
  public Int32? BlueModulation { get => _BlueModulation; set => UpdateField(ref _BlueModulation, value, nameof(BlueModulation)); }

  private Int32? _BlueModulation;
  /// <summary>
  /// Gets or sets a value indicating whether gamma correction is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, applies standard gamma correction (typically gamma 2.2)
  /// to convert from linear RGB space to display-corrected RGB. Default is <see langword="false"/>.
  /// Gamma correction adjusts colors to appear correct on display devices.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Gamma))]
  public Boolean? Gamma { get => _Gamma; set => UpdateField(ref _Gamma, value, nameof(Gamma)); }

  private Boolean? _Gamma;
  /// <summary>
  /// Gets or sets a value indicating whether inverse gamma correction is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, applies inverse gamma correction to convert from 
  /// display-corrected RGB to linear RGB space. Default is <see langword="false"/>.
  /// This is the opposite of standard gamma correction.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.InverseGamma))]
  public Boolean? InverseGamma { get => _InverseGamma; set => UpdateField(ref _InverseGamma, value, nameof(InverseGamma)); }

  private Boolean? _InverseGamma;
}