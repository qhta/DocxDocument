namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public interface Drawing // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public ShapeTree? ShapeTree { get ; set; }
  
}
