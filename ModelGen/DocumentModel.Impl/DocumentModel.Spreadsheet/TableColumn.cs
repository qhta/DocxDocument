namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Column.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICalculatedColumnFormula))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITotalsRowFormula))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IXmlColumnProperties))]
public class TableColumn: ITableColumn
{
  /// <summary>
  /// Table Field Id
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Unique Name
  /// </summary>
  public string? UniqueName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Column name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Totals Row Function
  /// </summary>
  public TotalsRowFunctionValues? TotalsRowFunction
  {
    get;
    set;
  }
  
  /// <summary>
  /// Totals Row Label
  /// </summary>
  public string? TotalsRowLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Query Table Field Id
  /// </summary>
  public uint? QueryTableFieldId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Header Row Cell Format Id
  /// </summary>
  public uint? HeaderRowDifferentialFormattingId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data and Insert Row Format Id
  /// </summary>
  public uint? DataFormatId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Totals Row Format Id
  /// </summary>
  public uint? TotalsRowDifferentialFormattingId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Header Row Cell Style
  /// </summary>
  public string? HeaderRowCellStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Area Style Name
  /// </summary>
  public string? DataCellStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Totals Row Style Name
  /// </summary>
  public string? TotalsRowCellStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Calculated Column Formula.
  /// </summary>
  public ICalculatedColumnFormula? CalculatedColumnFormula
  {
    get;
    set;
  }
  
  /// <summary>
  /// Totals Row Formula.
  /// </summary>
  public ITotalsRowFormula? TotalsRowFormula
  {
    get;
    set;
  }
  
  /// <summary>
  /// XML Column Properties.
  /// </summary>
  public IXmlColumnProperties? XmlColumnProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
