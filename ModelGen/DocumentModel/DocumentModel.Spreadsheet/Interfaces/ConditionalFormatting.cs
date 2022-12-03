namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormatting Class.
/// </summary>
public interface ConditionalFormatting // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// pivot, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Pivot { get ; set; }
  
  public Collection<ConditionalFormattingRule>? ConditionalFormattingRules { get ; set; }
  
  public String? ReferenceSequence { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
