namespace DocumentModel.Drawings;
/// <summary>
/// Represents an RGB color using percentage values with optional color transformations.
/// This is the percentage variant of the RGB color model used in Office Open XML DrawingML, 
/// allowing colors to be specified as percentage values for red, green, and blue components (0-100%)
/// with optional modifications like tint, shade, alpha transparency, and hue/saturation/luminance adjustments.
/// </summary>
[OpenXmlType(typeof(DXD.RgbColorModelPercentage))]
[DataContract]
[XmlRoot("RgbColorModelPercentage", Namespace = "DocumentModel.Drawings")]
public partial class RgbColorModelPercentage : DrawingsColorBase<DXD.RgbColorModelPercentage>, ISchemeBaseColor, IDrawingColor
{

  /// <summary>
  /// Red component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of red in the color where 0 is no red and 100% is maximum red.
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.RgbColorModelPercentage.RedPortion))]
  public Percentage R
  {
    get => _RedPercentage ??= GetProperty<Percentage>(GetUpdatableElement()?.RedPortion);
    set => UpdateField(ref _RedPercentage, value, nameof(R));
  }
  private Percentage? _RedPercentage;

  /// <summary>
  /// Green component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of green in the color where 0 is no green and 100%0 is maximum green.
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.RgbColorModelPercentage.GreenPortion))]
  public Percentage G
  {
    get => _GreenPercentage ??= GetProperty<Percentage>(GetUpdatableElement()?.GreenPortion);
    set => UpdateField(ref _GreenPercentage, value, nameof(G));
  }
  private Percentage? _GreenPercentage;

  /// <summary>
  /// Blue component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of blue in the color where 0 is no blue and 100% is maximum blue.
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.RgbColorModelPercentage.BluePortion))]
  public Percentage B
  {
    get => _BluePercentage ??= GetProperty<Percentage>(GetUpdatableElement()?.BluePortion);
    set => UpdateField(ref _BluePercentage, value, nameof(B));
  }
  private Percentage? _BluePercentage;

  /// <summary>
  /// Alpha component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of alpha (opacity) in the color where 0 is fully transparent and 100% is fully opaque.
  /// This is equivalent to RGBA values 0-255, but expressed as a percentage for easier calculations.
  /// </remarks>
  public Percentage A
  {
    get => _AlphaPercentage ??= "100%";
    set => UpdateField(ref _AlphaPercentage, value, nameof(A));
  }
  private Percentage? _AlphaPercentage;

  /// <summary>
  /// Gets or sets the red component of the color as a double value between 0 and 1.
  /// </summary>
  public override double Red
  {
    get => _RedPercentage?.ToDouble() / 100.0 ?? 0;
    set => R = new Percentage(value*100);
  }

  /// <summary>
  /// Gets or sets the green component of the color as a double value between 0 and 1.
  /// </summary>
  public override double Green
  {
    get => _GreenPercentage?.ToDouble() / 100.0 ?? 0;
    set => G = new Percentage(value*100);
  }


  /// <summary>
  /// Gets or sets the blue component of the color as a double value between 0 and 1.
  /// </summary>
  public override double Blue
  {
    get => _BluePercentage?.ToDouble() / 100.0 ?? 0;
    set => B = new Percentage(value*100);
  }

  /// <summary>
  /// Gets or sets the alpha component of the color as a double value between 0 and 1.
  /// </summary>
  public override double Alpha
  {
    get => _AlphaPercentage?.ToDouble() / 100.0 ?? 0;
    set => A = new Percentage(value*100);
  }
}