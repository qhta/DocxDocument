namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public partial class NonVisualDrawingPropertiesImpl: ModelElementImpl, NonVisualDrawingProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.NonVisualDrawingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.NonVisualDrawingProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NonVisualDrawingPropertiesImpl(): base() {}
  
  public NonVisualDrawingPropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.NonVisualDrawingProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  public UInt32? Id
  {
    get => (System.UInt32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  public String? Description
  {
    get => (System.String?)OpenXmlElement?.Description?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Description = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  public Boolean? Hidden
  {
    get => (System.Boolean?)OpenXmlElement?.Hidden?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hidden = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Title
  /// </summary>
  public String? Title
  {
    get => (System.String?)OpenXmlElement?.Title?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Title = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public DocumentModel.Drawings.HyperlinkOnClick? HyperlinkOnClick
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
        if (item != null)
          return new DocumentModel.Drawings.HyperlinkOnClickImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.HyperlinkOnClickImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  public DocumentModel.Drawings.HyperlinkOnHover? HyperlinkOnHover
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
        if (item != null)
          return new DocumentModel.Drawings.HyperlinkOnHoverImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.HyperlinkOnHoverImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  public DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
