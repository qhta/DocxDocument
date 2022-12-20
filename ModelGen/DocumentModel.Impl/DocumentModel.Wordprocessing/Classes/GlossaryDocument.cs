namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Root Element.
/// </summary>
public partial class GlossaryDocumentImpl: ModelElementImpl, GlossaryDocument
{
  public DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GlossaryDocumentImpl(): base() {}
  
  public GlossaryDocumentImpl(DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  public DocumentModel.Wordprocessing.DocumentBackground? DocumentBackground
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DocumentBackgroundImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DocumentBackgroundImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// List of Glossary Document Entries.
  /// </summary>
  public DocumentModel.Wordprocessing.DocParts? DocParts
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocParts>();
        if (item != null)
          return new DocumentModel.Wordprocessing.DocPartsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocParts>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.DocPartsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Gets the GlossaryDocumentPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.GlossaryDocumentPart? GlossaryDocumentPart
  {
    get
    {
      if (OpenXmlElement?.GlossaryDocumentPart != null)
        return new DocumentModel.Packaging.GlossaryDocumentPartImpl(OpenXmlElement.GlossaryDocumentPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.GlossaryDocumentPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
}
