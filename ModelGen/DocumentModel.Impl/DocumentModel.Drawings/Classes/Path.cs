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
    get => (System.Int64?)OpenXmlElement?.Width?.Value;
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
    get => (System.Int64?)OpenXmlElement?.Height?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Height = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Path Fill
  /// </summary>
  public DocumentModel.Drawings.PathFillMode? Fill
  {
    get => (DocumentModel.Drawings.PathFillMode?)OpenXmlElement?.Fill?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.Stroke?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.ExtrusionOk?.Value;
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
  
  public DocumentModel.Drawings.MoveTo? MoveTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.LineTo? LineTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.ArcTo? ArcTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.QuadraticBezierCurveTo? QuadraticBezierCurveTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.CubicBezierCurveTo? CubicBezierCurveTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
