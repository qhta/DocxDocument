namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Picture Fill.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlip))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISourceRectangle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IStretch))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITile))]
public class BlipFill: IBlipFill
{
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public bool? RotateWithShape
  {
    get;
    set;
  }
  
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Drawing.IBlip? Blip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  public ISourceRectangle? SourceRectangle
  {
    get;
    set;
  }
  
}
