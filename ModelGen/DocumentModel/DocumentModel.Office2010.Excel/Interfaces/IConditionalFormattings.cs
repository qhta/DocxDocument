namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormattings Class.
/// </summary>
public interface IConditionalFormattings // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.IConditionalFormatting>? ConditionalFormattings { get ; set; }
  
}
