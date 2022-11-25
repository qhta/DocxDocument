namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row Items.
/// </summary>
public interface IRowItem // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Item Type
  /// </summary>
  public DocumentModel.Spreadsheet.ItemKind? ItemType { get ; set; }
  
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public System.UInt32? RepeatedItemCount { get ; set; }
  
  /// <summary>
  /// Data Field Index
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
}
