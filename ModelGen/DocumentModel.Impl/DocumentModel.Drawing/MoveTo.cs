namespace DocumentModel.Drawing;

/// <summary>
/// Move Path To.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IPoint))]
public class MoveTo: IMoveTo
{
  /// <summary>
  /// Move end point.
  /// </summary>
  public DocumentModel.Drawing.IPoint? Point
  {
    get;
    set;
  }
  
}
