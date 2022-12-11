namespace DocumentModel.Drawings;

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
  public ShapeLocks? ShapeLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
