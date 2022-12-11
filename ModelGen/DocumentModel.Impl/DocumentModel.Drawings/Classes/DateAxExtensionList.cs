namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DateAxExtensionList Class.
/// </summary>
public class DateAxExtensionListImpl: ModelElementImpl, DateAxExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DateAxExtensionListImpl(): base() {}
  
  public DateAxExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DateAxExtension>? DateAxExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
