namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public partial class EndnotesImpl: ModelElementImpl, Endnotes
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Endnotes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Endnotes?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public EndnotesImpl(): base() {}
  
  public EndnotesImpl(DocumentFormat.OpenXml.Wordprocessing.Endnotes openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.Endnote? Endnote
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Endnote>();
        if (item != null)
          return new DocumentModel.Wordprocessing.EndnoteImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Endnote>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.EndnoteImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
