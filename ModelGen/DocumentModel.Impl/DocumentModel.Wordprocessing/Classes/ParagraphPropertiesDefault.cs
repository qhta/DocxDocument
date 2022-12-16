namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Paragraph Properties.
/// </summary>
public class ParagraphPropertiesDefaultImpl: ModelElementImpl, ParagraphPropertiesDefault
{
  public DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ParagraphPropertiesDefaultImpl(): base() {}
  
  public ParagraphPropertiesDefaultImpl(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyle? ParagraphPropertiesBaseStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesBaseStyle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ParagraphPropertiesBaseStyleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
