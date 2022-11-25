namespace DocumentModel.Office2021.Excel.NamedSheetViews;

/// <summary>
/// Defines the SortCondition Class.
/// </summary>
public interface ISortCondition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// descending, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Descending { get ; set; }
  
  /// <summary>
  /// sortBy, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.SortByKind? SortBy { get ; set; }
  
  /// <summary>
  /// ref, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Reference { get ; set; }
  
  /// <summary>
  /// customList, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? CustomList { get ; set; }
  
  /// <summary>
  /// dxfId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// iconSet, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.IconSetTypeKind? IconSet { get ; set; }
  
  /// <summary>
  /// iconId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? IconId { get ; set; }
  
}
