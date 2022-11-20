namespace DocumentModel.Drawing;

/// <summary>
/// Draw Line To.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IPoint))]
public class LineTo: ILineTo
{
  /// <summary>
  /// Line end point.
  /// </summary>
  public DocumentModel.Drawing.IPoint? Point
  {
    get;
    set;
  }
  
}
