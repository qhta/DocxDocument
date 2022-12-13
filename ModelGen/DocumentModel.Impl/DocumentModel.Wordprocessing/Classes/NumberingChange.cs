namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Paragraph Numbering Properties.
/// </summary>
public class NumberingChangeImpl: ModelElementImpl, NumberingChange
{
  public DocumentFormat.OpenXml.Wordprocessing.NumberingChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberingChangeImpl(): base() {}
  
  public NumberingChangeImpl(DocumentFormat.OpenXml.Wordprocessing.NumberingChange openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// original
  /// </summary>
  public String? Original
  {
    get => (System.String?)OpenXmlElement?.Original?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Original = (System.String?)value;
    }
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get => (System.String?)OpenXmlElement?.Author?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Author = (System.String?)value;
    }
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get => (System.DateTime?)OpenXmlElement?.Date?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Date = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
