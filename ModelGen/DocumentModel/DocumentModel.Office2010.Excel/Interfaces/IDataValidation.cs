namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataValidation Class.
/// </summary>
public interface IDataValidation // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.DataValidationKind? Type { get ; set; }
  
  /// <summary>
  /// errorStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.DataValidationErrorStyleKind? ErrorStyle { get ; set; }
  
  /// <summary>
  /// imeMode, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.DataValidationImeMode? ImeMode { get ; set; }
  
  /// <summary>
  /// operator, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.DataValidationOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// allowBlank, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? AllowBlank { get ; set; }
  
  /// <summary>
  /// showDropDown, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? ShowDropDown { get ; set; }
  
  /// <summary>
  /// showInputMessage, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? ShowInputMessage { get ; set; }
  
  /// <summary>
  /// showErrorMessage, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? ShowErrorMessage { get ; set; }
  
  /// <summary>
  /// errorTitle, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? ErrorTitle { get ; set; }
  
  /// <summary>
  /// error, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Error { get ; set; }
  
  /// <summary>
  /// promptTitle, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? PromptTitle { get ; set; }
  
  /// <summary>
  /// prompt, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Prompt { get ; set; }
  
  /// <summary>
  /// DataValidationForumla1.
  /// </summary>
  public DocumentModel.Office2010.Excel.IDataValidationForumla1? DataValidationForumla1 { get ; set; }
  
  /// <summary>
  /// DataValidationForumla2.
  /// </summary>
  public DocumentModel.Office2010.Excel.IDataValidationForumla2? DataValidationForumla2 { get ; set; }
  
  /// <summary>
  /// ReferenceSequence.
  /// </summary>
  public System.String? ReferenceSequence { get ; set; }
  
}
