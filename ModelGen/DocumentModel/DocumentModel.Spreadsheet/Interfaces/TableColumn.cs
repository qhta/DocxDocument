namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Column.
/// </summary>
public interface TableColumn // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Table Field Id
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// Unique Name
  /// </summary>
  public String? UniqueName { get ; set; }
  
  /// <summary>
  /// Column name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Totals Row Function
  /// </summary>
  public TotalsRowFunctionKind? TotalsRowFunction { get ; set; }
  
  /// <summary>
  /// Totals Row Label
  /// </summary>
  public String? TotalsRowLabel { get ; set; }
  
  /// <summary>
  /// Query Table Field Id
  /// </summary>
  public UInt32? QueryTableFieldId { get ; set; }
  
  /// <summary>
  /// Header Row Cell Format Id
  /// </summary>
  public UInt32? HeaderRowDifferentialFormattingId { get ; set; }
  
  /// <summary>
  /// Data and Insert Row Format Id
  /// </summary>
  public UInt32? DataFormatId { get ; set; }
  
  /// <summary>
  /// Totals Row Format Id
  /// </summary>
  public UInt32? TotalsRowDifferentialFormattingId { get ; set; }
  
  /// <summary>
  /// Header Row Cell Style
  /// </summary>
  public String? HeaderRowCellStyle { get ; set; }
  
  /// <summary>
  /// Data Area Style Name
  /// </summary>
  public String? DataCellStyle { get ; set; }
  
  /// <summary>
  /// Totals Row Style Name
  /// </summary>
  public String? TotalsRowCellStyle { get ; set; }
  
  /// <summary>
  /// Calculated Column Formula.
  /// </summary>
  public TableFormulaType? CalculatedColumnFormula { get ; set; }
  
  /// <summary>
  /// Totals Row Formula.
  /// </summary>
  public TableFormulaType? TotalsRowFormula { get ; set; }
  
  /// <summary>
  /// XML Column Properties.
  /// </summary>
  public XmlColumnProperties? XmlColumnProperties { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
