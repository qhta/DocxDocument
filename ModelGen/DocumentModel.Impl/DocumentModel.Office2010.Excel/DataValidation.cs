namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataValidation Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IDataValidationForumla1))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IDataValidationForumla2))]
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IReferenceSequence))]
public class DataValidation: IDataValidation
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public DataValidationValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// errorStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public DataValidationErrorStyleValues? ErrorStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// imeMode, this property is only available in Office 2010 and later.
  /// </summary>
  public DataValidationImeModeValues? ImeMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// operator, this property is only available in Office 2010 and later.
  /// </summary>
  public DataValidationOperatorValues? Operator
  {
    get;
    set;
  }
  
  /// <summary>
  /// allowBlank, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? AllowBlank
  {
    get;
    set;
  }
  
  /// <summary>
  /// showDropDown, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowDropDown
  {
    get;
    set;
  }
  
  /// <summary>
  /// showInputMessage, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowInputMessage
  {
    get;
    set;
  }
  
  /// <summary>
  /// showErrorMessage, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowErrorMessage
  {
    get;
    set;
  }
  
  /// <summary>
  /// errorTitle, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ErrorTitle
  {
    get;
    set;
  }
  
  /// <summary>
  /// error, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Error
  {
    get;
    set;
  }
  
  /// <summary>
  /// promptTitle, this property is only available in Office 2010 and later.
  /// </summary>
  public string? PromptTitle
  {
    get;
    set;
  }
  
  /// <summary>
  /// prompt, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Prompt
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataValidationForumla1.
  /// </summary>
  public IDataValidationForumla1? DataValidationForumla1
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataValidationForumla2.
  /// </summary>
  public IDataValidationForumla2? DataValidationForumla2
  {
    get;
    set;
  }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public IReferenceSequence? ReferenceSequence
  {
    get;
    set;
  }
  
}
