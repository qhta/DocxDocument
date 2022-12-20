namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SurfaceType Class.
/// </summary>
public partial interface SurfaceType
{
  /// <summary>
  /// Thickness.
  /// </summary>
  public Byte? Thickness { get; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get; set; }
  
  /// <summary>
  /// Picture Options.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureOptions? PictureOptions { get; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
