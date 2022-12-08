namespace DocumentModel.Drawings;

/// <summary>
/// Shape Path.
/// </summary>
public class PathImpl: ModelElementImpl, Path
{
  public DocumentFormat.OpenXml.Drawing.Path? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Path?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Path Width
  /// </summary>
  public Int64? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Path Height
  /// </summary>
  public Int64? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// Path Fill
  /// </summary>
  public PathFillMode? Fill
  {
    get => (PathFillMode?)OpenXmlElement?.Fill?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Fill = (DocumentFormat.OpenXml.Drawing.PathFillModeValues?)value;
    }
  }
  
  /// <summary>
  /// Path Stroke
  /// </summary>
  public Boolean? Stroke
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  public Boolean? ExtrusionOk
  {
    get;
    set;
  }
  
  public Collection<Boolean>? CloseShapePaths
  {
    get;
    set;
  }
  
  public Collection<MoveTo>? MoveTos
  {
    get;
    set;
  }
  
  public Collection<LineTo>? LineTos
  {
    get;
    set;
  }
  
  public Collection<ArcTo>? ArcTos
  {
    get;
    set;
  }
  
  public Collection<QuadraticBezierCurveTo>? QuadraticBezierCurveTos
  {
    get;
    set;
  }
  
  public Collection<CubicBezierCurveTo>? CubicBezierCurveTos
  {
    get;
    set;
  }
  
}
