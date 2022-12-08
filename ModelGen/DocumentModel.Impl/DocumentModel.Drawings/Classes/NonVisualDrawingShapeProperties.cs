namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public class NonVisualDrawingShapePropertiesImpl: ModelElementImpl, NonVisualDrawingShapeProperties
{
  public DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties?)_OpenXmlElement;
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
