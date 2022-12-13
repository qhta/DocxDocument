namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the InsertedMathControl Class.
/// </summary>
public class InsertedMathControlImpl: ModelElementImpl, InsertedMathControl
{
  public DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public InsertedMathControlImpl(): base() {}
  
  public InsertedMathControlImpl(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  
  public DocumentModel.Wordprocessing.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.DeletedMathControl? DeletedMathControl
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
