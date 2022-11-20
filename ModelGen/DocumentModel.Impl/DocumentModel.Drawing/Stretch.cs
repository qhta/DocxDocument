namespace DocumentModel.Drawing;

/// <summary>
/// Stretch.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillRectangle))]
public class Stretch: IStretch
{
  /// <summary>
  /// Fill Rectangle.
  /// </summary>
  public IFillRectangle? FillRectangle
  {
    get;
    set;
  }
  
}
