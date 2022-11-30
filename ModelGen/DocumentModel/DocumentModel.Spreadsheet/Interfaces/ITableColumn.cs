namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Column.
/// </summary>
public interface ITableColumn // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Field Id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// Unique Name
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
  /// <summary>
  /// Column name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Totals Row Function
  /// </summary>
  public DocumentModel.Spreadsheet.TotalsRowFunctionKind? TotalsRowFunction { get ; set; }
  
  /// <summary>
  /// Totals Row Label
  /// </summary>
  public System.String? TotalsRowLabel { get ; set; }
  
  /// <summary>
  /// Query Table Field Id
  /// </summary>
  public System.UInt32? QueryTableFieldId { get ; set; }
  
  /// <summary>
  /// Header Row Cell Format Id
  /// </summary>
  public System.UInt32? HeaderRowDifferentialFormattingId { get ; set; }
  
  /// <summary>
  /// Data and Insert Row Format Id
  /// </summary>
  public System.UInt32? DataFormatId { get ; set; }
  
  /// <summary>
  /// Totals Row Format Id
  /// </summary>
  public System.UInt32? TotalsRowDifferentialFormattingId { get ; set; }
  
  /// <summary>
  /// Header Row Cell Style
  /// </summary>
  public System.String? HeaderRowCellStyle { get ; set; }
  
  /// <summary>
  /// Data Area Style Name
  /// </summary>
  public System.String? DataCellStyle { get ; set; }
  
  /// <summary>
  /// Totals Row Style Name
  /// </summary>
  public System.String? TotalsRowCellStyle { get ; set; }
  
  /// <summary>
  /// Calculated Column Formula.
  /// </summary>
  public DocumentModel.Spreadsheet.ITableFormulaType? CalculatedColumnFormula { get ; set; }
  
  /// <summary>
  /// Totals Row Formula.
  /// </summary>
  public DocumentModel.Spreadsheet.ITableFormulaType? TotalsRowFormula { get ; set; }
  
  /// <summary>
  /// XML Column Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.IXmlColumnProperties? XmlColumnProperties { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
