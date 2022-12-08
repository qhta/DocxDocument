namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public class ShapeNonVisualPropertiesImpl: ModelElementImpl, ShapeNonVisualProperties
{
  public DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties?)_OpenXmlElement;
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
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties
  {
    get;
    set;
  }
  
}
