namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Starting Anchor Point.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IXPosition))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IYPosition))]
public class FromAnchor: IFromAnchor
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
