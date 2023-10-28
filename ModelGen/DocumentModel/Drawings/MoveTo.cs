namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a set of new coordinates to move the shape cursor to. This element is only used for drawing a custom geometry. When this element is utilized the pt element is used to specify a new set of shape coordinates that the shape cursor should be moved to. This does not draw a line or curve to this new position from the old position but simply move the cursor to a new starting position. It is only when a path drawing element such as lnTo is used that a portion of the path is drawn.
/// </summary>
public partial class MoveTo
{
  
  /// <summary>
  ///   Move end point.
  /// </summary>
  public DMD.Point? Point { get; set; }
  
}
