namespace DocumentModel.Drawing;

/// <summary>
/// Path Gradient.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillToRectangle))]
public class PathGradientFill: IPathGradientFill
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public PathShadeValues? Path
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public DocumentModel.Drawing.IFillToRectangle? FillToRectangle
  {
    get;
    set;
  }
  
}
