namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Formatting.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IConditionalFormattingRule))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface IConditionalFormatting // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// PivotTable Conditional Formatting
  /// </summary>
  public bool? Pivot { get ; set; }
  
  /// <summary>
  /// Sequence of References
  /// </summary>
  public List<string>? SequenceOfReferences { get ; set; }
  
}
