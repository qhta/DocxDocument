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
  
  public Collection<LineSerExtension>? LineSerExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
