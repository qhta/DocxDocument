
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of data label to apply. The default is typically xlDataLabelsShowValue.
/// </summary>
public enum XlDataLabelsType
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
  /// of data label to apply. The default is typically xlDataLabelsShowValue.
  /// </summary>
  None = -4142,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Value for the point
  /// (assumed if this argument isn't specified).
  /// </summary>
  Value = 2,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Percentage of the
  /// total. Available only for pie charts and doughnut charts.
  /// </summary>
  Percent = 3,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Category for the
  /// point.
  /// </summary>
  Label = 4,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Percentage of the
  /// total, and category for the point. Available only for pie charts and doughnut charts.
  /// xlDataLabelsShowBubbleSizes6 You should access and use this enumeration from the Excel primary interop
  /// assembly (PIA). Show the size of the bubble in reference to the absolute value. public enum class
  /// XlDataLabelsType ﾉ Expand table
  /// </summary>
  LabelAndPercent = 5,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
  /// of data label to apply. The default is typically xlDataLabelsShowValue.
  /// </summary>
  BubbleSizes = 6
}
