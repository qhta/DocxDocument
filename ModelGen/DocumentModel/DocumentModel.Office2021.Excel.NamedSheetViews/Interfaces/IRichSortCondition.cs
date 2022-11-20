namespace DocumentModel.Office2021.Excel.NamedSheetViews;

/// <summary>
/// Defines the RichSortCondition Class.
/// </summary>
public interface IRichSortCondition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// richSortKey, this property is only available in Office 2019 and later.
  /// </summary>
  public string? RichSortKey { get ; set; }
  
  /// <summary>
  /// descending, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Descending { get ; set; }
  
  /// <summary>
  /// sortBy, this property is only available in Office 2010 and later.
  /// </summary>
  public SortByValues? SortBy { get ; set; }
  
  /// <summary>
  /// ref, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Reference { get ; set; }
  
  /// <summary>
  /// customList, this property is only available in Office 2010 and later.
  /// </summary>
  public string? CustomList { get ; set; }
  
  /// <summary>
  /// dxfId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? FormatId { get ; set; }
  
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public IconSetTypeValues? IconSet { get ; set; }
  
  /// <summary>
  /// iconId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? IconId { get ; set; }
  
}
