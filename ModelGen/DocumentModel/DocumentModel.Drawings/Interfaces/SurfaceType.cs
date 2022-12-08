namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceType Class.
/// </summary>
public interface SurfaceType
{
  /// <summary>
  /// Thickness.
  /// </summary>
  public Byte? Thickness { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties1? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Picture Options.
  /// </summary>
  public PictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList { get ; set; }
  
}
