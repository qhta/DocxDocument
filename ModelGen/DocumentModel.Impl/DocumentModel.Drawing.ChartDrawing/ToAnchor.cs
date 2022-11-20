namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Ending Anchor Point.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IXPosition))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IYPosition))]
public class ToAnchor: IToAnchor
{
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  public IXPosition? XPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  public IYPosition? YPosition
  {
    get;
    set;
  }
  
}
