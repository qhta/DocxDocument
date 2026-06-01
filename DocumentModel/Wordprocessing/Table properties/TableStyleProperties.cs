namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IStyle Conditional ITable Formatting Properties.
/// </summary>
public class TableStyleProperties: ModelElement
{
  /// <summary>
  ///   ITable IStyle Conditional Formatting Type
  /// </summary>
  public TableStyleOverrideKind? Type { get; set; }

  /// <summary>
  ///   ITable IStyle Conditional Formatting IParagraph Properties.
  /// </summary>
  public StyleParagraphProperties? StyleParagraphProperties { get; set; }

  /// <summary>
  ///   ITable IStyle Conditional Formatting Run Properties.
  /// </summary>
  public TableStyleRunProperties? TableStyleRunProperties { get; set; }

  /// <summary>
  ///   ITable IStyle Conditional Formatting ITable Properties.
  /// </summary>
  public TableStyleConditionalTableProperties? TableStyleConditionalTableProperties { get; set; }

  /// <summary>
  ///   ITable IStyle Conditional Formatting ITable IRow Properties.
  /// </summary>
  public TableStyleConditionalRowProperties? TableStyleConditionalRowProperties { get; set; }

  /// <summary>
  ///   ITable IStyle Conditional Formatting ITable ICell Properties.
  /// </summary>
  public TableStyleConditionalCellProperties? TableStyleConditionalCellProperties { get; set; }
}
