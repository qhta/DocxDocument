namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public class NonVisualContentPartPropertiesImpl: ModelElementImpl, NonVisualContentPartProperties
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualContentPartPropertiesImpl(): base() {}
  
  public NonVisualContentPartPropertiesImpl(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties openXmlElement): base(openXmlElement)
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
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public NonVisualInkContentPartProperties? NonVisualInkContentPartProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
