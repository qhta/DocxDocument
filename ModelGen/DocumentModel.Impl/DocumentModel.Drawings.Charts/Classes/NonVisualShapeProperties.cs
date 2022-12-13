namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public class NonVisualShapePropertiesImpl: ModelElementImpl, NonVisualShapeProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualShapePropertiesImpl(): base() {}
  
  public NonVisualShapePropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
