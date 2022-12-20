namespace DocumentModel.Drawings;

/// <summary>
/// Custom geometry.
/// </summary>
public partial class CustomGeometryImpl: ModelElementImpl, CustomGeometry
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.CustomGeometry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.CustomGeometry?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CustomGeometryImpl(): base() {}
  
  public CustomGeometryImpl(DocumentFormat.OpenXml.Drawing.CustomGeometry openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public DocumentModel.Drawings.AdjustValueList? AdjustValueList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
        if (item != null)
          return new DocumentModel.Drawings.AdjustValueListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.AdjustValueListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List of Shape Guides.
  /// </summary>
  public DocumentModel.Drawings.ShapeGuideList? ShapeGuideList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeGuideList>();
        if (item != null)
          return new DocumentModel.Drawings.ShapeGuideListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeGuideList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ShapeGuideListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List of Shape Adjust Handles.
  /// </summary>
  public DocumentModel.Drawings.AdjustHandleList? AdjustHandleList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleList>();
        if (item != null)
          return new DocumentModel.Drawings.AdjustHandleListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.AdjustHandleListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List of Shape Connection Sites.
  /// </summary>
  public DocumentModel.Drawings.ConnectionSiteList? ConnectionSiteList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionSiteList>();
        if (item != null)
          return new DocumentModel.Drawings.ConnectionSiteListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionSiteList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ConnectionSiteListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Shape Text Rectangle.
  /// </summary>
  public DocumentModel.Drawings.Rectangle? Rectangle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rectangle>();
        if (item != null)
          return new DocumentModel.Drawings.RectangleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rectangle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RectangleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List of Shape Paths.
  /// </summary>
  public DocumentModel.Drawings.PathList? PathList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathList>();
        if (item != null)
          return new DocumentModel.Drawings.PathListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PathList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.PathListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
