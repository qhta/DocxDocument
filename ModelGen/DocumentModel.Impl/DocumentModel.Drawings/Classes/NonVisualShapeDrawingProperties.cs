namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// Text Box
  /// </summary>
  public Boolean? TextBox
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public ShapeLocks? ShapeLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
