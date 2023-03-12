namespace DocumentModel.Wordprocessing;

/// <summary>
///   Style Conditional Table Formatting Properties.
/// </summary>
public class TableStyleProperties: ModelElement
{
  /// <summary>
  ///   Table Style Conditional Formatting Type
  /// </summary>
  public TableStyleOverrideKind? Type { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  public StyleParagraphProperties? StyleParagraphProperties { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Run Properties.
  /// </summary>
  public RunPropertiesBaseStyle? RunPropertiesBaseStyle { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Table Properties.
  /// </summary>
  public TableStyleConditionalFormattingTableProperties? TableStyleConditionalFormattingTableProperties { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  public TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  public TableStyleConditionalFormattingTableCellProperties? TableStyleConditionalFormattingTableCellProperties { get; set; }
}