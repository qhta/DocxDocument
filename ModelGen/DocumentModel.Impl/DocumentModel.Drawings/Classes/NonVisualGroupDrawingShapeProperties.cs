namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public class NonVisualGroupDrawingShapePropertiesImpl: ModelElementImpl, NonVisualGroupDrawingShapeProperties
{
  public DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualGroupDrawingShapePropertiesImpl(): base() {}
  
  public NonVisualGroupDrawingShapePropertiesImpl(DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public GroupShapeLocks? GroupShapeLocks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
