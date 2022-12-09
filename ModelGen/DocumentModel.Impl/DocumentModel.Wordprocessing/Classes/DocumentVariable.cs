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
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Document Variable Value
  /// </summary>
  public String? Val
  {
    get => (String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
}
