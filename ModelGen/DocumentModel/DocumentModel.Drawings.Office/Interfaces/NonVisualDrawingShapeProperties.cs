namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public interface NonVisualDrawingShapeProperties
{
  /// <summary>
  /// Text Box
  /// </summary>
  public Boolean? TextBox { get ; set; }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public DocumentModel.Drawings.ShapeLocks? ShapeLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
