namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public partial class NonVisualDrawingShapeProperties
{
  /// <summary>
  /// Text Box
  /// </summary>
  public Boolean? TextBox { get; set; }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public DocumentModel.Drawings.ShapeLocks? ShapeLocks { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
