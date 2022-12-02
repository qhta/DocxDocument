namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattings Class.
/// </summary>
public interface IConditionalFormattings // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IConditionalFormatting>? ConditionalFormattings { get ; set; }
  
}
