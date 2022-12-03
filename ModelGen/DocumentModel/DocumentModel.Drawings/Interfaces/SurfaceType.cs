namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceType Class.
/// </summary>
public interface SurfaceType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Thickness.
  /// </summary>
  public Byte? Thickness { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Picture Options.
  /// </summary>
  public PictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
