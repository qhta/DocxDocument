namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public class GroupShapeNonVisualPropertiesImpl: ModelElementImpl, GroupShapeNonVisualProperties
{
  public DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties2? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties
  {
    get;
    set;
  }
  
}
