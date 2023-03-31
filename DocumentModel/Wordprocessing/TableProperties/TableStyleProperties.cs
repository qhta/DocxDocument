namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  [XmlContentElement] public StyleParagraphProperties? StyleParagraphProperties { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Run Properties.
  /// </summary>
  [XmlContentElement] public RunPropertiesBaseStyle? RunPropertiesBaseStyle { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Table Properties.
  /// </summary>
  [XmlContentElement] public TableStyleConditionalTableProperties? TableStyleConditionalTableProperties { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  [XmlContentElement] public TableStyleConditionalRowProperties? TableStyleConditionalRowProperties { get; set; }

  /// <summary>
  ///   Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  [XmlContentElement] public TableStyleConditionalCellProperties? TableStyleConditionalCellProperties { get; set; }
}