namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Non-Visual Graphic Frame Drawing Properties.
/// </summary>
public class NonVisualGraphicFrameDrawingPropertiesImpl: ModelElementImpl, NonVisualGraphicFrameDrawingProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualGraphicFrameDrawingPropertiesImpl(): base() {}
  
  public NonVisualGraphicFrameDrawingPropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public DocumentModel.Drawings.GraphicFrameLocks? GraphicFrameLocks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
