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
    get => _Red ??= GetProperty<Percentage>(GetUpdatableElement()?.RedPortion);
    set => UpdateField(ref _Red, value, nameof(R));
  }
  private Percentage? _Red;

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
    get => _Green ??= GetProperty<Percentage>(GetUpdatableElement()?.GreenPortion);
    set => UpdateField(ref _Green, value, nameof(G));
  }
  private Percentage? _Green;

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
    get => _Blue ??= GetProperty<Percentage>(GetUpdatableElement()?.BluePortion);
    set => UpdateField(ref _Blue, value, nameof(B));
  }
  private Percentage? _Blue;

}