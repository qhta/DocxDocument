namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Conditional Table Formatting Properties.
/// </summary>
public interface ITableStyleProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Style Conditional Formatting Type
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleOverrideKind? Type { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IStyleParagraphProperties? StyleParagraphProperties { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IRunPropertiesBaseStyle? RunPropertiesBaseStyle { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableStyleConditionalFormattingTableProperties? TableStyleConditionalFormattingTableProperties { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableStyleConditionalFormattingTableCellProperties? TableStyleConditionalFormattingTableCellProperties { get ; set; }
  
}
