namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Group Shape Properties.
/// </summary>
public class NonVisualGroupShapePropertiesImpl: ModelElementImpl, NonVisualGroupShapeProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualGroupShapePropertiesImpl(): base() {}
  
  public NonVisualGroupShapePropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
