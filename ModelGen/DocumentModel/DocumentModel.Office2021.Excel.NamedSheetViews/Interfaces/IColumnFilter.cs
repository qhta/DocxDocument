namespace DocumentModel.Office2021.Excel.NamedSheetViews;

/// <summary>
/// Defines the ColumnFilter Class.
/// </summary>
public interface IColumnFilter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// colId, this property is only available in Office 2021 and later.
  /// </summary>
  public System.UInt32? ColId { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// DifferentialFormatType.
  /// </summary>
  public DocumentModel.Office2021.Excel.NamedSheetViews.IDifferentialFormatType? DifferentialFormatType { get ; set; }
  
}
