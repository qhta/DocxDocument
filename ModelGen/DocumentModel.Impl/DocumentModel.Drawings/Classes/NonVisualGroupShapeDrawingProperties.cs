namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public class NonVisualGroupShapeDrawingPropertiesImpl: ModelElementImpl, NonVisualGroupShapeDrawingProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties?)_OpenXmlElement;
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
