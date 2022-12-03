namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattingRuleExtensionList Class.
/// </summary>
public interface ConditionalFormattingRuleExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ConditionalFormattingRuleExtension>? ConditionalFormattingRuleExtensions { get ; set; }
  
}
