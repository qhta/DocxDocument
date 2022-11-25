namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Text Style.
/// </summary>
public interface ITableCellTextStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bold
  /// </summary>
  public DocumentModel.Drawing.BooleanStyleKind? Bold { get ; set; }
  
  /// <summary>
  /// Italic
  /// </summary>
  public DocumentModel.Drawing.BooleanStyleKind? Italic { get ; set; }
  
}
