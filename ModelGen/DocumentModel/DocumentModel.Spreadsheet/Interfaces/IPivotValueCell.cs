namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotValueCell Class.
/// </summary>
public interface IPivotValueCell // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// i, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Item { get ; set; }
  
  /// <summary>
  /// t, this property is only available in Office 2013 and later.
  /// </summary>
  public SXVCellType? Text { get ; set; }
  
  /// <summary>
  /// Xstring.
  /// </summary>
  public String? Xstring { get ; set; }
  
  /// <summary>
  /// PivotValueCellExtra.
  /// </summary>
  public IPivotValueCellExtra? PivotValueCellExtra { get ; set; }
  
}
