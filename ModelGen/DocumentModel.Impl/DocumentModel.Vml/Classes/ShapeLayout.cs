namespace DocumentModel.Vml;

/// <summary>
/// Shape Layout Properties.
/// </summary>
public partial class ShapeLayoutImpl: ModelElementImpl, ShapeLayout
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Office.ShapeLayout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.ShapeLayout?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ShapeLayoutImpl(): base() {}
  
  public ShapeLayoutImpl(DocumentFormat.OpenXml.Vml.Office.ShapeLayout openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Shape ID Map.
  /// </summary>
  public DocumentModel.Vml.ShapeIdMap? ShapeIdMap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeIdMap>();
        if (item != null)
          return new DocumentModel.Vml.ShapeIdMapImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeIdMap>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ShapeIdMapImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  public DocumentModel.Vml.RegroupTable? RegroupTable
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RegroupTable>();
        if (item != null)
          return new DocumentModel.Vml.RegroupTableImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RegroupTable>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.RegroupTableImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  public DocumentModel.Vml.Rules? Rules
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Rules>();
        if (item != null)
          return new DocumentModel.Vml.RulesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Rules>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.RulesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
