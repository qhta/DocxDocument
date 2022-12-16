namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Default Paragraph and Run Properties.
/// </summary>
public class DocDefaultsImpl: ModelElementImpl, DocDefaults
{
  public DocumentFormat.OpenXml.Wordprocessing.DocDefaults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocDefaults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocDefaultsImpl(): base() {}
  
  public DocDefaultsImpl(DocumentFormat.OpenXml.Wordprocessing.DocDefaults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Default Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunPropertiesDefault? RunPropertiesDefault
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RunPropertiesDefaultImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RunPropertiesDefaultImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Default Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphPropertiesDefault? ParagraphPropertiesDefault
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ParagraphPropertiesDefaultImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ParagraphPropertiesDefaultImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
