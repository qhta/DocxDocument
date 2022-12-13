namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public interface Drawing
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public DocumentModel.Drawings.ShapeTree? ShapeTree { get ; set; }
  
}
