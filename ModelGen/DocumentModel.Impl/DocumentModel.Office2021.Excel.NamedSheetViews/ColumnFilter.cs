namespace DocumentModel.Office2021.Excel.NamedSheetViews;

/// <summary>
/// Defines the ColumnFilter Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.NamedSheetViews.IDifferentialFormatType))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.NamedSheetViews.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Excel.NamedSheetViews.IFilterColumn))]
public class ColumnFilter: IColumnFilter
{
  /// <summary>
  /// colId, this property is only available in Office 2021 and later.
  /// </summary>
  public uint? ColId
  {
    get;
    set;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// DifferentialFormatType.
  /// </summary>
  public DocumentModel.Office2021.Excel.NamedSheetViews.IDifferentialFormatType? DifferentialFormatType
  {
    get;
    set;
  }
  
}
