namespace DocumentModel.Drawing;

/// <summary>
/// Tab Stop.
/// </summary>
public interface ITabStop // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Tab Position
  /// </summary>
  public System.Int32? Position { get ; set; }
  
  /// <summary>
  /// Tab Alignment
  /// </summary>
  public DocumentModel.Drawing.TextTabAlignmentKind? Alignment { get ; set; }
  
}
