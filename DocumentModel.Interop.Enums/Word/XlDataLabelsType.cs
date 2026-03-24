namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of data label to apply.
/// </summary>
public enum XlDataLabelsType
{
  /// <summary>
  /// Default value for the point (assumed if this argument is not specified).
  /// </summary>
  Value = unchecked((int)2),
  /// <summary>
  /// Percentage of the total. Available only for pie charts and doughnut charts.
  /// </summary>
  Percent = unchecked((int)3),
  /// <summary>
  /// Category for the point.
  /// </summary>
  Label = unchecked((int)4),
  /// <summary>
  /// Percentage of the total, and category for the point. Available only for pie charts and doughnut charts.
  /// xlDataLabelsShowBubbleSizes6 Show the size of the bubble in reference to the absolute value.
  /// </summary>
  LabelAndPercent = unchecked((int)5),
  /// <summary>
  /// Specifies the type of data label to apply.
  /// </summary>
  BubbleSizes = unchecked((int)6),
  /// <summary>
  /// Specifies the type of data label to apply.
  /// </summary>
  None = unchecked((int)-4142)
}
