namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattings Class.
/// </summary>
public interface IConditionalFormattings // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IConditionalFormatting>? ConditionalFormattings { get ; set; }
  
}
