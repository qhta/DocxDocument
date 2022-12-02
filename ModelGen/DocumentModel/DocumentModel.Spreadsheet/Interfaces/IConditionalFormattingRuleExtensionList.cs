namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattingRuleExtensionList Class.
/// </summary>
public interface IConditionalFormattingRuleExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IConditionalFormattingRuleExtension>? ConditionalFormattingRuleExtensions { get ; set; }
  
}
