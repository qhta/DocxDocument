namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PieSerExtensionList Class.
/// </summary>
public class PieSerExtensionListImpl: ModelElementImpl, PieSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PieSerExtensionListImpl(): base() {}
  
  public PieSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<PieSerExtension>? PieSerExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
