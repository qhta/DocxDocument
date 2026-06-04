namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of data label to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldatalabelstype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlDataLabelsType")]
public enum DataLabelsType
{
  /// <summary>
  /// Default value for the point (assumed if this argument is not specified).
  /// </summary>
  [WordInteropEnumValue("xlDataLabelsShowValue")]
  Value = 2,
  /// <summary>
  /// Percentage of the total. Available only for pie charts and doughnut charts.
  /// </summary>
  [WordInteropEnumValue("xlDataLabelsShowPercent")]
  Percent = 3,
  /// <summary>
  /// Category for the point.
  /// </summary>
  [WordInteropEnumValue("xlDataLabelsShowLabel")]
  Label = 4,
  /// <summary>
  /// Percentage of the total, and category for the point. Available only for pie charts and doughnut charts.
  /// </summary>
  [WordInteropEnumValue("xlDataLabelsShowLabelAndPercent")]
  LabelAndPercent = 5,
  /// <summary>
  /// Show the size of the bubble in reference to the absolute value.
  /// </summary>
  [WordInteropEnumValue("xlDataLabelsShowBubbleSizes")]
  BubbleSizes = 6,
  /// <summary>
  /// No data labels.
  /// </summary>
  [WordInteropEnumValue("xlDataLabelsShowNone")]
  None = -4142
}
