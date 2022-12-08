namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Name.
/// </summary>
public class DocPartNameImpl: ModelElementImpl, DocPartName
{
  public DocumentFormat.OpenXml.Wordprocessing.DocPartName? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocPartName?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Name Value
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Built-In Entry
  /// </summary>
  public Boolean? Decorated
  {
    get;
    set;
  }
  
}
