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
  
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public NonVisualDrawingProperties3? NonVisualDrawingProperties
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
