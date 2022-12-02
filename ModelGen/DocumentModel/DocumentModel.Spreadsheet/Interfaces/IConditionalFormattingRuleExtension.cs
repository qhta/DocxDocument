namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattingRuleExtension Class.
/// </summary>
public interface IConditionalFormattingRuleExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public String? Id { get ; set; }
  
}
