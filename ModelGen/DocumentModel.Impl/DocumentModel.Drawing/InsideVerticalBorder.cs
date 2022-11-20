namespace DocumentModel.Drawing;

/// <summary>
/// Inside Vertical Border.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IOutline))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILineReference))]
public class InsideVerticalBorder: IInsideVerticalBorder
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
