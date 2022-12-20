namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Text Body.
/// </summary>
public partial class TextBodyImpl: ModelElementImpl, TextBody
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.TextBody? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.TextBody?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TextBodyImpl(): base() {}
  
  public TextBodyImpl(DocumentFormat.OpenXml.Drawing.Diagrams.TextBody openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Body Properties.
  /// </summary>
  public DocumentModel.Drawings.BodyProperties? BodyProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
        if (item != null)
          return new DocumentModel.Drawings.BodyPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.BodyPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public DocumentModel.Drawings.ListStyle? ListStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
        if (item != null)
          return new DocumentModel.Drawings.ListStyleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ListStyleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Paragraph? Paragraph
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
        if (item != null)
          return new DocumentModel.Drawings.ParagraphImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ParagraphImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
