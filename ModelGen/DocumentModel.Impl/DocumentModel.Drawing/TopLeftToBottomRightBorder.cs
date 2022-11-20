namespace DocumentModel.Drawing;

/// <summary>
/// Top Left to Bottom Right Border.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IOutline))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILineReference))]
public class TopLeftToBottomRightBorder: ITopLeftToBottomRightBorder
{
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawing.IOutline? Outline
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line Reference.
  /// </summary>
  public DocumentModel.Drawing.ILineReference? LineReference
  {
    get;
    set;
  }
  
}
