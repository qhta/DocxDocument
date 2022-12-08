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
  
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public GroupShapeLocks? GroupShapeLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
  {
    get;
    set;
  }
  
}
