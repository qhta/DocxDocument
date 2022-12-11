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
  
  public ShapeNonVisualPropertiesImpl(): base() {}
  
  public ShapeNonVisualPropertiesImpl(DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
