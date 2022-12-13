namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Non-Visual Shape Drawing Properties.
/// </summary>
public class NonVisualShapeDrawingPropertiesImpl: ModelElementImpl, NonVisualShapeDrawingProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualShapeDrawingPropertiesImpl(): base() {}
  
  public NonVisualShapeDrawingPropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Text Box
  /// </summary>
  public Boolean? TextBox
  {
    get => (System.Boolean?)OpenXmlElement?.TextBox?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TextBox = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public DocumentModel.Drawings.ShapeLocks? ShapeLocks
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
