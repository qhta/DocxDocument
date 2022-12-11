namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtensionList Class.
/// </summary>
public class ShapePropertiesExtensionListImpl: ModelElementImpl, ShapePropertiesExtensionList
{
  public DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapePropertiesExtensionListImpl(): base() {}
  
  public ShapePropertiesExtensionListImpl(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<ShapePropertiesExtension>? ShapePropertiesExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
