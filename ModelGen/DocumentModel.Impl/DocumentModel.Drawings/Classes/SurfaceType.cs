namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceType Class.
/// </summary>
public class SurfaceTypeImpl: ModelElementImpl, SurfaceType
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Thickness.
  /// </summary>
  public virtual Byte? Thickness
  {
    get;
    set;
  }
  
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
