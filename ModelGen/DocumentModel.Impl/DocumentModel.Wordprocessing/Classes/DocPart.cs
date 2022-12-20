namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry.
/// </summary>
public partial class DocPartImpl: ModelElementImpl, DocPart
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.DocPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DocPartImpl(): base() {}
  
  public DocPartImpl(DocumentFormat.OpenXml.Wordprocessing.DocPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Glossary Document Entry Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartProperties? DocPartProperties
  {
    get
    {
      if (OpenXmlElement?.DocPartProperties != null)
        return new DocumentModel.Wordprocessing.DocPartPropertiesImpl(OpenXmlElement.DocPartProperties);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.DocPartPropertiesImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.DocPartProperties = valueImpl.OpenXmlElement;
    }
  }
  
  /// <summary>
  /// Contents of Glossary Document Entry.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartBody? DocPartBody
  {
    get
    {
      if (OpenXmlElement?.DocPartBody != null)
        return new DocumentModel.Wordprocessing.DocPartBodyImpl(OpenXmlElement.DocPartBody);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.DocPartBodyImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.DocPartBody = valueImpl.OpenXmlElement;
    }
  }
  
}
