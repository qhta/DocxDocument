namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the color settings for the extrusion effect of a drawing element in a Wordprocessing document.
/// This interface provides properties for specifying the extrusion color using either an RGB value or a scheme color, enabling flexible color customization for 3D effects.
/// </summary>
public class ExtrusionColor: ModelElement<DXO10W.ExtrusionColor>
{
  /// <summary>
  /// The RGB color value used for the extrusion, allowing precise color specification.
  /// </summary>
  public RgbColor? RgbColor { get; set; }

  /// <summary>
  /// The scheme color used for the extrusion, enabling the use of document-defined color schemes.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}