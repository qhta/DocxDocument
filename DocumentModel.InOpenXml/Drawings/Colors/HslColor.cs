namespace DocumentModel.Drawings;
/// <summary>
/// Represents a color using the Hue, Saturation, and Luminance (HSL) color model, with additional color adjustment properties.
/// </summary>
[OpenXmlType(typeof(DXD.HslColor))]
[DataContract]
[XmlRoot("HslColor", Namespace = "DocumentModel.Drawings")]
public partial class HslColor : DrawingsColorBase<DXD.HslColor>, ISchemeBaseColor, IDrawingColor
{

  /// <summary>
  /// Hue component as a degrees value.
  /// </summary>
  /// <remarks>
  /// Specifies the hue angle in degrees (0-360), in the precision of 1/60000th of a degree.
  /// Hue represents the color's position on the color wheel: 0=red, 60=yellow, 120=green, 180=cyan, 240=blue, 300=magenta.
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.HslColor.HueValue))]
  public Degrees H
  {
    get => _Hue ??= GetProperty<Degrees>(GetUpdatableElement()?.HueValue);
    set => UpdateField(ref _Hue, value, nameof(H));
  }
  private Degrees? _Hue;

  /// <summary>
  /// Absolute saturation value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the color saturation in the precision of 1/1000 percent, where 0 is grayscale and 100% is fully saturated.
  /// Saturation determines the intensity or vividness of the color.
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.HslColor.SatValue))]
  public Percentage S
  {
    get => _Saturation ??= GetProperty<Percentage>(GetUpdatableElement()?.SatValue);
    set => UpdateField(ref _Saturation, value, nameof(S));
  }
  private Percentage? _Saturation;

  /// <summary>
  /// Absolute luminance value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the brightness in the precision of 1/1000 percent, where 0 is black, 50% is the color at normal brightness (50%), 
  /// and 100% is white. Luminance determines how light or dark the color appears.
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.HslColor.LumValue))]
  public Percentage L
  {
    get => _Luminance ??= GetProperty<Percentage>(GetUpdatableElement()?.LumValue);
    set => UpdateField(ref _Luminance, value, nameof(L));
  }
  private Percentage? _Luminance;

  /// <summary>
  /// Alpha component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of alpha (opacity) in the color where 0 is fully transparent and 100% is fully opaque.
  /// This is equivalent to RGBA values 0-255, but expressed as a percentage for easier calculations.
  /// </remarks>
  public Percentage A
  {
    get => _Alpha ??= "100%";
    set => UpdateField(ref _Alpha, value, nameof(A));
  }
  private Percentage? _Alpha;
}