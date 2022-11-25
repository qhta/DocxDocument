namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Format Value Object.
/// </summary>
public interface IConditionalFormatValueObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Type
  /// </summary>
  public DocumentModel.Spreadsheet.ConditionalFormatValueObjectKind? Type { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public System.String? Val { get ; set; }
  
  /// <summary>
  /// Greater Than Or Equal
  /// </summary>
  public System.Boolean? GreaterThanOrEqual { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
