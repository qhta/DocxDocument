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
  
  public NonVisualGroupDrawingShapePropsExtensionListImpl(): base() {}
  
  public NonVisualGroupDrawingShapePropsExtensionListImpl(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<NonVisualGroupDrawingShapePropsExtension>? NonVisualGroupDrawingShapePropsExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
