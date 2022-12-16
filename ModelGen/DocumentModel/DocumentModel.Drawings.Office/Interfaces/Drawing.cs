namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public interface Drawing
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public DocumentModel.Drawings.Office.ShapeTree? ShapeTree { get ; set; }
  
}
