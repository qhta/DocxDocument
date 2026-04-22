namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Describes a color style configuration for chart elements, supporting various color models and style variations.
/// </summary>
[XmlRoot("ColorStyle", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class ColorStyle //: OfficeArtExtendableElement
{
  /// <summary>
  /// Method used to apply the color style to chart elements.
  /// </summary>
  public string? Method { get; set; }
  /// <summary>
  /// Unique identifier for the color style.
  /// </summary>
  public UInt32? Id { get; set; }
  /// <summary>
  /// Color used in the color style.
  /// </summary>
  public DMD.ColorClass? Color { get; set; }
  /// <summary>
  /// Collection of color style variations for additional customization.
  /// </summary>
  public ColorStyleVariations? ColorStyleVariations { get; set; }
}