namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormatting Class.
/// </summary>
public interface IConditionalFormatting // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// pivot, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Pivot { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IConditionalFormattingRule>? ConditionalFormattingRules { get ; set; }
  
  public System.String? ReferenceSequence { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
