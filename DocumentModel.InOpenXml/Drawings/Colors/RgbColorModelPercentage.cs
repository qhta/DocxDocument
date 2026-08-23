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
  public Percentage Red
  {
    get => _RedPercentage ??= GetProperty<Percentage>(GetUpdatableElement()?.RedPortion);
    set => UpdateField(ref _RedPercentage, value, nameof(Red));
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
  public Percentage Green
  {
    get => _GreenPercentage ??= GetProperty<Percentage>(GetUpdatableElement()?.GreenPortion);
    set => UpdateField(ref _GreenPercentage, value, nameof(Green));
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
  public Percentage Blue
  {
    get => _BluePercentage ??= GetProperty<Percentage>(GetUpdatableElement()?.BluePortion);
    set => UpdateField(ref _BluePercentage, value, nameof(Blue));
  }
  private Percentage? _BluePercentage;


  /// <summary>
  /// Gets or sets the red component of the color as a double value between 0 and 1.
  /// </summary>
  public override double RedFactor
  {
    get => _RedPercentage?.AsDouble() ?? 0;
    set => Red = new Percentage(value);
  }

  /// <summary>
  /// Gets or sets the green component of the color as a double value between 0 and 1.
  /// </summary>
  public override double GreenFactor
  {
    get => _GreenPercentage?.AsDouble() ?? 0;
    set => Green = new Percentage(value);
  }


  /// <summary>
  /// Gets or sets the blue component of the color as a double value between 0 and 1.
  /// </summary>
  public override double BlueFactor
  {
    get => _BluePercentage?.AsDouble() ?? 0;
    set => Blue = new Percentage(value);
  }
}
