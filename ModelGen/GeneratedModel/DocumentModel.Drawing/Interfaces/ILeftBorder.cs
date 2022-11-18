namespace DocumentModel.Drawing;

/// <summary>
/// Left Border.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IOutline))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILineReference))]
public interface ILeftBorder // : DocumentFormat.OpenXml.Drawing.ThemeableLineStyleType
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
