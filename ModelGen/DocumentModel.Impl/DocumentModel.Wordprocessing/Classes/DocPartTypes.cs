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
    get => (Boolean?)OpenXmlElement?.All?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.All = (System.Boolean?)value;
    }
  }
  
  public Collection<DocPartKind>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
