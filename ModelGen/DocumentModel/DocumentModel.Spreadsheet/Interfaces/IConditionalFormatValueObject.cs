namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Format Value Object.
/// </summary>
public interface IConditionalFormatValueObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Type
  /// </summary>
  public ConditionalFormatValueObjectKind? Type { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// Greater Than Or Equal
  /// </summary>
  public Boolean? GreaterThanOrEqual { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
