namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the Drawing Class.
/// </summary>
public class Drawing: ModelElement<DXOD.Drawing>
{
  /// <summary>
  ///   ShapeTree.
  /// </summary>
  public ShapeTree? ShapeTree { get; set; }
}