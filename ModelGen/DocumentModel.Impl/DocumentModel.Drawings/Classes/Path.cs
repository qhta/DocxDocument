namespace DocumentModel.Drawings;

/// <summary>
/// Shape Path.
/// </summary>
public partial class PathImpl: ModelElementImpl, Path
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Path? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Path?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.MoveTo>();
        if (item != null)
          return new DocumentModel.Drawings.MoveToImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.MoveTo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.MoveToImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.LineTo? LineTo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineTo>();
        if (item != null)
          return new DocumentModel.Drawings.LineToImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineTo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.LineToImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.ArcTo? ArcTo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ArcTo>();
        if (item != null)
          return new DocumentModel.Drawings.ArcToImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ArcTo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArcToImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.QuadraticBezierCurveTo? QuadraticBezierCurveTo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo>();
        if (item != null)
          return new DocumentModel.Drawings.QuadraticBezierCurveToImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.QuadraticBezierCurveTo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.QuadraticBezierCurveToImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.CubicBezierCurveTo? CubicBezierCurveTo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo>();
        if (item != null)
          return new DocumentModel.Drawings.CubicBezierCurveToImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CubicBezierCurveTo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.CubicBezierCurveToImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
