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
  
  public NonVisualPicturePropertiesExtensionListImpl(): base() {}
  
  public NonVisualPicturePropertiesExtensionListImpl(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<NonVisualPicturePropertiesExtension>? NonVisualPicturePropertiesExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
