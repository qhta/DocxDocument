namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StrDataExtensionList Class.
/// </summary>
public class StrDataExtensionListImpl: ModelElementImpl, StrDataExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StrDataExtensionListImpl(): base() {}
  
  public StrDataExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<StrDataExtension>? StrDataExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
