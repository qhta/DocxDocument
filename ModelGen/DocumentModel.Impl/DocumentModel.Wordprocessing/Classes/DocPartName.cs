namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Name.
/// </summary>
public partial class DocPartNameImpl: ModelElementImpl, DocPartName
{
  public DocumentFormat.OpenXml.Wordprocessing.DocPartName? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocPartName?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocPartNameImpl(): base() {}
  
  public DocPartNameImpl(DocumentFormat.OpenXml.Wordprocessing.DocPartName openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Name Value
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
  
  /// <summary>
  /// Built-In Entry
  /// </summary>
  public Boolean? Decorated
  {
    get => (System.Boolean?)OpenXmlElement?.Decorated?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Decorated = (System.Boolean?)value;
    }
  }
  
}
