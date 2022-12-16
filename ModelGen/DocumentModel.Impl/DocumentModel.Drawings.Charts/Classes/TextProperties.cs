namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the TextProperties Class.
/// </summary>
public class TextPropertiesImpl: DocumentModel.Drawings.Charts.TextBodyTypeImpl, TextProperties
{
  public new DocumentFormat.OpenXml.Drawing.Charts.TextProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.TextProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextPropertiesImpl(): base() {}
  
  public TextPropertiesImpl(DocumentFormat.OpenXml.Drawing.Charts.TextProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.BodyProperties? BodyProperties
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
  
  public new DocumentModel.Drawings.ListStyle? ListStyle
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
