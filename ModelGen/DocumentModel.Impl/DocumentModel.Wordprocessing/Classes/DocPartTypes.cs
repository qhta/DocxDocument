namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Types.
/// </summary>
public class DocPartTypesImpl: ModelElementImpl, DocPartTypes
{
  public DocumentFormat.OpenXml.Wordprocessing.DocPartTypes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocPartTypes?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Entry Is Of All Types
  /// </summary>
  public Boolean? All
  {
    get;
    set;
  }
  
  public Collection<DocPartKind>? Items
  {
    get;
    set;
  }
  
}
