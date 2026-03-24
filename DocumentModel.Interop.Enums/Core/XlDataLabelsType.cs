
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of data label to apply. The default is typically xlDataLabelsShowValue.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldatalabelstype?view=office-pia` for Office interop details.
/// </remarks>
public enum XlDataLabelsType
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). No data labels.
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
  /// </summary>
  LabelAndPercent = 5,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Show the size of the
  /// bubble in reference to the absolute value. public enum class XlDataLabelsType
  /// </summary>
  BubbleSizes = 6
}
