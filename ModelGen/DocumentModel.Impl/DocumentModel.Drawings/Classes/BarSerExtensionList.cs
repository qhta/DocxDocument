namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BarSerExtensionList Class.
/// </summary>
public class BarSerExtensionListImpl: ModelElementImpl, BarSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BarSerExtensionListImpl(): base() {}
  
  public BarSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<BarSerExtension>? BarSerExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
