namespace DocumentModel.Drawing;

/// <summary>
/// Top Right to Bottom Left Border.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IOutline))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILineReference))]
public interface ITopRightToBottomLeftBorder // : DocumentFormat.OpenXml.Drawing.ThemeableLineStyleType
{
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawing.IOutline? Outline { get ; set; }
  
  /// <summary>
  /// Line Reference.
  /// </summary>
  public DocumentModel.Drawing.ILineReference? LineReference { get ; set; }
  
}
