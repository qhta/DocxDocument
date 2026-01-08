namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the surface type for a chart, including thickness, shape properties, picture options, and extensibility.
/// </summary>
public interface SurfaceType
{
  /// <summary>
  ///   Thickness of the surface.
  /// </summary>
  public Byte? Thickness { get; set; }

  /// <summary>
  ///   Shape properties for the surface.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Picture options for the surface.
  /// </summary>
  public PictureOptions? PictureOptions { get; set; }

  /// <summary>
  ///   Extension list for additional surface properties.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}