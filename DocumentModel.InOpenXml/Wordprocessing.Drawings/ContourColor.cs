namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the color settings for the contour of a drawing element in a Wordprocessing document.
/// This interface provides properties for specifying the contour color using either an RGB value or a scheme color, enabling flexible color customization.
/// </summary>
public partial class ContourColor : ModelElement<DXO10W.ContourColor>
{
  /// <summary>
  /// The RGB color value used for the contour, allowing precise color specification.
  /// </summary>
  public RgbColor? RgbColor { get; set; }
  /// <summary>
  /// The scheme color used for the contour, enabling the use of document-defined color schemes.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}