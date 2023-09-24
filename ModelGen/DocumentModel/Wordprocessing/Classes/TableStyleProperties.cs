namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of formatting properties which shall be conditionally applied to the parts of a table which match the requirement specified on the type attribute. These table conditional formats are applied to different regions of the table as follows:
/// </summary>
public partial class TableStyleProperties
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
