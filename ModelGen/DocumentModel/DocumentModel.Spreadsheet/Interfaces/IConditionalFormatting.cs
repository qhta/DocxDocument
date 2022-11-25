namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Formatting.
/// </summary>
public interface IConditionalFormatting // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PivotTable Conditional Formatting
  /// </summary>
  public System.Boolean? Pivot { get ; set; }
  
  /// <summary>
  /// Sequence of References
  /// </summary>
  public System.Collections.Generic.List<System.String>? SequenceOfReferences { get ; set; }
  
}
