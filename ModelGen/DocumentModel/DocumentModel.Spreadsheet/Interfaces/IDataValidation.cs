namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Validation.
/// </summary>
public interface IDataValidation // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Spreadsheet.DataValidationKind? Type { get ; set; }
  
  /// <summary>
  /// errorStyle
  /// </summary>
  public DocumentModel.Spreadsheet.DataValidationErrorStyleKind? ErrorStyle { get ; set; }
  
  /// <summary>
  /// imeMode
  /// </summary>
  public DocumentModel.Spreadsheet.DataValidationImeMode? ImeMode { get ; set; }
  
  /// <summary>
  /// operator
  /// </summary>
  public DocumentModel.Spreadsheet.DataValidationOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// allowBlank
  /// </summary>
  public System.Boolean? AllowBlank { get ; set; }
  
  /// <summary>
  /// showDropDown
  /// </summary>
  public System.Boolean? ShowDropDown { get ; set; }
  
  /// <summary>
  /// showInputMessage
  /// </summary>
  public System.Boolean? ShowInputMessage { get ; set; }
  
  /// <summary>
  /// showErrorMessage
  /// </summary>
  public System.Boolean? ShowErrorMessage { get ; set; }
  
  /// <summary>
  /// errorTitle
  /// </summary>
  public System.String? ErrorTitle { get ; set; }
  
  /// <summary>
  /// error
  /// </summary>
  public System.String? Error { get ; set; }
  
  /// <summary>
  /// promptTitle
  /// </summary>
  public System.String? PromptTitle { get ; set; }
  
  /// <summary>
  /// prompt
  /// </summary>
  public System.String? Prompt { get ; set; }
  
  /// <summary>
  /// sqref
  /// </summary>
  public System.Collections.Generic.List<System.String>? SequenceOfReferences { get ; set; }
  
  /// <summary>
  /// List, this property is only available in Office 2013 and later..
  /// </summary>
  public System.String? List { get ; set; }
  
  /// <summary>
  /// Formula1.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? Formula1 { get ; set; }
  
  /// <summary>
  /// Formula2.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? Formula2 { get ; set; }
  
}
