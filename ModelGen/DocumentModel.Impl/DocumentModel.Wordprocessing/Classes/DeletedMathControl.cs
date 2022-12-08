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
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  public RunProperties? RunProperties
  {
    get;
    set;
  }
  
}
