namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public class NonVisualDrawingPropertiesExtensionListImpl: ModelElementImpl, NonVisualDrawingPropertiesExtensionList
{
  public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<NonVisualDrawingPropertiesExtension>? NonVisualDrawingPropertiesExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
