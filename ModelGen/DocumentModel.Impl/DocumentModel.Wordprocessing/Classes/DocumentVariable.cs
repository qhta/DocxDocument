namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Document Variable.
/// </summary>
public class DocumentVariableImpl: ModelElementImpl, DocumentVariable
{
  public DocumentFormat.OpenXml.Wordprocessing.DocumentVariable? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocumentVariable?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Document Variable Name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Document Variable Value
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
}
