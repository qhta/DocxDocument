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
  
  public DeletedMathControl? DeletedMathControl
  {
    get;
    set;
  }
  
}
