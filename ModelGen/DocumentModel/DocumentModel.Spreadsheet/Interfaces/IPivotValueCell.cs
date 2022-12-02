namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotValueCell Class.
/// </summary>
public interface IPivotValueCell // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// i, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Item { get ; set; }
  
  /// <summary>
  /// t, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.SXVCellType? Text { get ; set; }
  
  /// <summary>
  /// Xstring.
  /// </summary>
  public System.String? Xstring { get ; set; }
  
  /// <summary>
  /// PivotValueCellExtra.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotValueCellExtra? PivotValueCellExtra { get ; set; }
  
}
