namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public class GroupShapeNonVisualPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties>, GroupShapeNonVisualProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties1? NonVisualDrawingProperties
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
