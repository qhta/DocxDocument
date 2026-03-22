namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of data label to apply.
/// </summary>
public enum XlDataLabelsType
{
  /// <summary>
  /// Default value for the point (assumed if this argument is not specified).
  /// </summary>
  xlDataLabelsShowValue = unchecked((int)2),
  /// <summary>
  /// Percentage of the total. Available only for pie charts and doughnut charts.
  /// </summary>
  xlDataLabelsShowPercent = unchecked((int)3),
  /// <summary>
  /// Category for the point.
  /// </summary>
  xlDataLabelsShowLabel = unchecked((int)4),
  /// <summary>
  /// Percentage of the total, and category for the point. Available only for pie charts and doughnut charts.
  /// xlDataLabelsShowBubbleSizes6 Show the size of the bubble in reference to the absolute value.
  /// </summary>
  xlDataLabelsShowLabelAndPercent = unchecked((int)5),
  /// <summary>
  /// Specifies the type of data label to apply.
  /// </summary>
  xlDataLabelsShowBubbleSizes = unchecked((int)6),
  /// <summary>
  /// Specifies the type of data label to apply.
  /// </summary>
  xlDataLabelsShowNone = unchecked((int)-4142)
}
