namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceType Class.
/// </summary>
public class SurfaceTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceType>, SurfaceType
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public virtual ShapeProperties1? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Picture Options.
  /// </summary>
  public virtual PictureOptions? PictureOptions
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public virtual ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
