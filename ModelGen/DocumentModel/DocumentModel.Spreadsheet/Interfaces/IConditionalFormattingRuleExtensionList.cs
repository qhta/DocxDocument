namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattingRuleExtensionList Class.
/// </summary>
public interface IConditionalFormattingRuleExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IConditionalFormattingRuleExtension>? ConditionalFormattingRuleExtensions { get ; set; }
  
}
