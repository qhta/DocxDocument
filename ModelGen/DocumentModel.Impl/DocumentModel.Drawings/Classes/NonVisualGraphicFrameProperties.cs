namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Graphic Frame Properties.
/// </summary>
public class NonVisualGraphicFramePropertiesImpl: ModelElementImpl, NonVisualGraphicFrameProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualGraphicFramePropertiesImpl(): base() {}
  
  public NonVisualGraphicFramePropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
