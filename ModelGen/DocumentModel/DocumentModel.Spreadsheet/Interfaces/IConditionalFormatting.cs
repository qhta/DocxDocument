namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormatting Class.
/// </summary>
public interface IConditionalFormatting // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// pivot, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Pivot { get ; set; }
  
  public Collection<IConditionalFormattingRule>? ConditionalFormattingRules { get ; set; }
  
  public String? ReferenceSequence { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
