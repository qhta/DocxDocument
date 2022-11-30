namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormatting Class.
/// </summary>
public interface IConditionalFormatting // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// pivot, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Pivot { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.IConditionalFormattingRule>? ConditionalFormattingRules { get ; set; }
  
  public System.String? ReferenceSequence { get ; set; }
  
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
