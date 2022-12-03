namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RichSortCondition Class.
/// </summary>
public interface RichSortCondition // : System.Boolean
{
  /// <summary>
  /// richSortKey, this property is only available in Office 2019 and later.
  /// </summary>
  public String? RichSortKey { get ; set; }
  
  /// <summary>
  /// descending, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Descending { get ; set; }
  
  /// <summary>
  /// sortBy, this property is only available in Office 2010 and later.
  /// </summary>
  public SortByKind? SortBy { get ; set; }
  
  /// <summary>
  /// ref, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Reference { get ; set; }
  
  /// <summary>
  /// customList, this property is only available in Office 2010 and later.
  /// </summary>
  public String? CustomList { get ; set; }
  
  /// <summary>
  /// dxfId, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public IconSetKind? IconSet { get ; set; }
  
  /// <summary>
  /// iconId, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? IconId { get ; set; }
  
}
