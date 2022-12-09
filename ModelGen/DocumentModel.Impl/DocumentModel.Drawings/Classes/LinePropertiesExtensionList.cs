namespace DocumentModel.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public class LinePropertiesExtensionListImpl: ModelElementImpl, LinePropertiesExtensionList
{
  public DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<LinePropertiesExtension>? LinePropertiesExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
