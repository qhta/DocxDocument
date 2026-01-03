namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the Drawing Class.
/// </summary>
public interface Drawing: IModelElement
{
  /// <summary>
  ///   ShapeTree.
  /// </summary>
  public ShapeTree? ShapeTree { get; set; }
}