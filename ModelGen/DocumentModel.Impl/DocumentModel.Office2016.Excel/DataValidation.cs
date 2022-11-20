namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Represents an external link to another workbook..
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFormula1))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFormula2))]
[ChildElementInfo(typeof(DocumentModel.Office2010.ExcelAc.IList))]
public class DataValidation: IDataValidation
{
  /// <summary>
  /// type
  /// </summary>
  public DataValidationValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// errorStyle
  /// </summary>
  public DataValidationErrorStyleValues? ErrorStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// imeMode
  /// </summary>
  public DataValidationImeModeValues? ImeMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// operator
  /// </summary>
  public DataValidationOperatorValues? Operator
  {
    get;
    set;
  }
  
  /// <summary>
  /// allowBlank
  /// </summary>
  public bool? AllowBlank
  {
    get;
    set;
  }
  
  /// <summary>
  /// showDropDown
  /// </summary>
  public bool? ShowDropDown
  {
    get;
    set;
  }
  
  /// <summary>
  /// showInputMessage
  /// </summary>
  public bool? ShowInputMessage
  {
    get;
    set;
  }
  
  /// <summary>
  /// showErrorMessage
  /// </summary>
  public bool? ShowErrorMessage
  {
    get;
    set;
  }
  
  /// <summary>
  /// errorTitle
  /// </summary>
  public string? ErrorTitle
  {
    get;
    set;
  }
  
  /// <summary>
  /// error
  /// </summary>
  public string? Error
  {
    get;
    set;
  }
  
  /// <summary>
  /// promptTitle
  /// </summary>
  public string? PromptTitle
  {
    get;
    set;
  }
  
  /// <summary>
  /// prompt
  /// </summary>
  public string? Prompt
  {
    get;
    set;
  }
  
  /// <summary>
  /// sqref
  /// </summary>
  public List<string>? SequenceOfReferences
  {
    get;
    set;
  }
  
  /// <summary>
  /// List.
  /// </summary>
  public string? List
  {
    get;
    set;
  }
  
  /// <summary>
  /// Formula1.
  /// </summary>
  public IFormula1? Formula1
  {
    get;
    set;
  }
  
  /// <summary>
  /// Formula2.
  /// </summary>
  public IFormula2? Formula2
  {
    get;
    set;
  }
  
}
