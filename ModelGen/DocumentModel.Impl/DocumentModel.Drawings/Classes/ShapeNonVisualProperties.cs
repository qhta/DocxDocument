namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public class ShapeNonVisualPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>, ShapeNonVisualProperties
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
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties
  {
    get;
    set;
  }
  
}
