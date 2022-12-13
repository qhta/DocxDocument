namespace DocumentModel.Drawings.Charts;

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
  
  public NonVisualGroupShapeDrawingPropertiesImpl(): base() {}
  
  public NonVisualGroupShapeDrawingPropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public DocumentModel.Drawings.GroupShapeLocks? GroupShapeLocks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
