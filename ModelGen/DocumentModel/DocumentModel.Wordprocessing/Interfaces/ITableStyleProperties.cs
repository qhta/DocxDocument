namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Conditional Table Formatting Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStyleParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunPropertiesBaseStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableStyleConditionalFormattingTableProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableStyleConditionalFormattingTableCellProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableStyleConditionalFormattingTableRowProperties))]
public interface ITableStyleProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Style Conditional Formatting Type
  /// </summary>
  public TableStyleOverrideValues? Type { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  public IStyleParagraphProperties? StyleParagraphProperties { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Run Properties.
  /// </summary>
  public IRunPropertiesBaseStyle? RunPropertiesBaseStyle { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Properties.
  /// </summary>
  public ITableStyleConditionalFormattingTableProperties? TableStyleConditionalFormattingTableProperties { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  public ITableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties { get ; set; }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  public ITableStyleConditionalFormattingTableCellProperties? TableStyleConditionalFormattingTableCellProperties { get ; set; }
  
}
