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
    get => (Int64?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Path Height
  /// </summary>
  public Int64? Height
  {
    get => (Int64?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.Int64?)value;
    }
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
    get => (Boolean?)OpenXmlElement?.Stroke?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Stroke = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  public Boolean? ExtrusionOk
  {
    get => (Boolean?)OpenXmlElement?.ExtrusionOk?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ExtrusionOk = (System.Boolean?)value;
    }
  }
  
  public Collection<Boolean>? CloseShapePaths
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MoveTo>? MoveTos
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<LineTo>? LineTos
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<ArcTo>? ArcTos
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<QuadraticBezierCurveTo>? QuadraticBezierCurveTos
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<CubicBezierCurveTo>? CubicBezierCurveTos
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
