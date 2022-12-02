namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataValidation Class.
/// </summary>
public interface IDataValidation // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public DataValidationKind? Type { get ; set; }
  
  /// <summary>
  /// errorStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public DataValidationErrorStyleKind? ErrorStyle { get ; set; }
  
  /// <summary>
  /// imeMode, this property is only available in Office 2010 and later.
  /// </summary>
  public DataValidationImeMode? ImeMode { get ; set; }
  
  /// <summary>
  /// operator, this property is only available in Office 2010 and later.
  /// </summary>
  public DataValidationOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// allowBlank, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? AllowBlank { get ; set; }
  
  /// <summary>
  /// showDropDown, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowDropDown { get ; set; }
  
  /// <summary>
  /// showInputMessage, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowInputMessage { get ; set; }
  
  /// <summary>
  /// showErrorMessage, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowErrorMessage { get ; set; }
  
  /// <summary>
  /// errorTitle, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ErrorTitle { get ; set; }
  
  /// <summary>
  /// error, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Error { get ; set; }
  
  /// <summary>
  /// promptTitle, this property is only available in Office 2010 and later.
  /// </summary>
  public String? PromptTitle { get ; set; }
  
  /// <summary>
  /// prompt, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Prompt { get ; set; }
  
  /// <summary>
  /// DataValidationForumla1.
  /// </summary>
  public IDataValidationForumla1? DataValidationForumla1 { get ; set; }
  
  /// <summary>
  /// DataValidationForumla2.
  /// </summary>
  public IDataValidationForumla2? DataValidationForumla2 { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public String? ReferenceSequence { get ; set; }
  
}
