namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtensionList Class.
/// </summary>
public class NonVisualGroupDrawingShapePropsExtensionListImpl: ModelElementImpl, NonVisualGroupDrawingShapePropsExtensionList
{
  public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<NonVisualGroupDrawingShapePropsExtension>? NonVisualGroupDrawingShapePropsExtensions
  {
    get;
    set;
  }
  
}
