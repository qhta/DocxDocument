namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the Drawing Class.
/// </summary>
public record Drawing
{
  /// <summary>
  ///   ShapeTree.
  /// </summary>
  public ShapeTree? ShapeTree { get; set; }
}