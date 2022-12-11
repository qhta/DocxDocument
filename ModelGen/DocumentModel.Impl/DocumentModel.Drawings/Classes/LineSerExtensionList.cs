namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSerExtensionList Class.
/// </summary>
public class LineSerExtensionListImpl: ModelElementImpl, LineSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineSerExtensionListImpl(): base() {}
  
  public LineSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<LineSerExtension>? LineSerExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
