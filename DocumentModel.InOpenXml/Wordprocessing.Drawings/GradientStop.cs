namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents a single stop in a gradient fill for a drawing element in a Wordprocessing document.
/// This class provides properties for specifying the position and color of the gradient stop, enabling precise control over color transitions in gradient effects.
/// </summary>
public class GradientStop: ModelElement<DXO10W.GradientStop>
{
  /// <summary>
  /// The position of the gradient stop, specified as a percentage or value indicating where the color is applied along the gradient axis.
  /// </summary>
  public Int32? StopPosition { get; set; }

  /// <summary>
  /// The RGB color value for the gradient stop, allowing precise color specification.
  /// </summary>
  public RgbColor? RgbColor { get; set; }

  /// <summary>
  /// The scheme color for the gradient stop, enabling the use of document-defined color schemes.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}