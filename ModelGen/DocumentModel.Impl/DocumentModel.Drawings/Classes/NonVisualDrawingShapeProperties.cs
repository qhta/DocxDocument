namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public class NonVisualDrawingShapePropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties>, NonVisualDrawingShapeProperties
{
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
