namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattingRuleExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IId))]
public interface IConditionalFormattingRuleExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
