namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DeletedMathControl Class.
/// </summary>
public class DeletedMathControlImpl: ModelElementImpl, DeletedMathControl
{
  public DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DeletedMathControlImpl(): base() {}
  
  public DeletedMathControlImpl(DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get => (String?)OpenXmlElement?.Author?.Value;
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
    get => (DateTime?)OpenXmlElement?.Date?.Value;
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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  public RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
