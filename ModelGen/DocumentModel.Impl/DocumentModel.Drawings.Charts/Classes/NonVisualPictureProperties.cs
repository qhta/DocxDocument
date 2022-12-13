namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public class NonVisualPicturePropertiesImpl: ModelElementImpl, NonVisualPictureProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualPicturePropertiesImpl(): base() {}
  
  public NonVisualPicturePropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
