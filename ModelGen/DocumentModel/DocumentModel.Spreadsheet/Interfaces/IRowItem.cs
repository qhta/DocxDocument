namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row Items.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMemberPropertyIndex))]
public interface IRowItem // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Item Type
  /// </summary>
  public ItemValues? ItemType { get ; set; }
  
  /// <summary>
  /// Repeated Items Count
  /// </summary>
  public uint? RepeatedItemCount { get ; set; }
  
  /// <summary>
  /// Data Field Index
  /// </summary>
  public uint? Index { get ; set; }
  
}
