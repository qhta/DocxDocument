namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Conditional Table Formatting Properties.
/// </summary>
public partial class TableStyleProperties
{
  /// <summary>
  /// Table Style Conditional Formatting Type
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleOverrideKind? Type { get; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.StyleParagraphProperties? StyleParagraphProperties { get; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunPropertiesBaseStyle? RunPropertiesBaseStyle { get; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties? TableStyleConditionalFormattingTableProperties { get; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties { get; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? TableStyleConditionalFormattingTableCellProperties { get; set; }
  
}
