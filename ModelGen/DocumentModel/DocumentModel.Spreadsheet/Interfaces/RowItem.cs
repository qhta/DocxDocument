namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row Items.
/// </summary>
public interface RowItem // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Item Type
  /// </summary>
  public ItemKind? ItemType { get ; set; }
  
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public UInt32? RepeatedItemCount { get ; set; }
  
  /// <summary>
  /// Data Field Index
  /// </summary>
  public UInt32? Index { get ; set; }
  
  public Collection<Int32>? MemberPropertyIndexs { get ; set; }
  
}
