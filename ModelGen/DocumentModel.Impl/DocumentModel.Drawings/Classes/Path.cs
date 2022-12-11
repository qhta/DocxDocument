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
  
  public PathImpl(): base() {}
  
  public PathImpl(DocumentFormat.OpenXml.Drawing.Path openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  
  public Boolean? CloseShapePath
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CloseShapePath>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CloseShapePath>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.CloseShapePath();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public MoveTo? MoveTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LineTo? LineTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ArcTo? ArcTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public QuadraticBezierCurveTo? QuadraticBezierCurveTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public CubicBezierCurveTo? CubicBezierCurveTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
