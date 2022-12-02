namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattingValueObject Class.
/// </summary>
public interface IConditionalFormattingValueObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.ConditionalFormattingValueObjectKind? Type { get ; set; }
  
  /// <summary>
  /// gte, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? GreaterThanOrEqual { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
