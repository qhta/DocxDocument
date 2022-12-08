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
  
  public Collection<ShapePropertiesExtension>? ShapePropertiesExtensions
  {
    get;
    set;
  }
  
}
