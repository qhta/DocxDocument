namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Document Variable.
/// </summary>
public partial class DocumentVariableImpl: ModelElementImpl, DocumentVariable
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.DocumentVariable? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocumentVariable?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DocumentVariableImpl(): base() {}
  
  public DocumentVariableImpl(DocumentFormat.OpenXml.Wordprocessing.DocumentVariable openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Document Variable Name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
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
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
}
