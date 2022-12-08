namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public class NonVisualPicturePropertiesExtensionListImpl: ModelElementImpl, NonVisualPicturePropertiesExtensionList
{
  public DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<NonVisualPicturePropertiesExtension>? NonVisualPicturePropertiesExtensions
  {
    get;
    set;
  }
  
}
