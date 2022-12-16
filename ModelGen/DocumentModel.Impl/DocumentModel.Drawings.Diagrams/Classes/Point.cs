namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Point.
/// </summary>
public class PointImpl: ModelElementImpl, Point
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Point? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Point?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PointImpl(): base() {}
  
  public PointImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Model Identifier
  /// </summary>
  public String? ModelId
  {
    get => (System.String?)OpenXmlElement?.ModelId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ModelId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.PointKind? Type
  {
    get => (DocumentModel.Drawings.Diagrams.PointKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.PointValues?)value;
    }
  }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  public String? ConnectionId
  {
    get => (System.String?)OpenXmlElement?.ConnectionId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectionId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.PropertySet? PropertySet
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.PropertySetImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.PropertySetImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.TextBody? TextBody
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.TextBodyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.TextBodyImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.PtExtensionList? PtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.PtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.PtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
