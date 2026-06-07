
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of data label to apply. The default is typically xlDataLabelsShowValue.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldatalabelstype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlDataLabelsType")]
public enum DataLabelsType
{
  /// <summary>
  /// No data labels.
  /// </summary>
  [InteropEnumValue("xlDataLabelsShowNone")]
  None = -4142,
  /// <summary>
  /// Value for the point (assumed if this argument isn't specified).
  /// </summary>
  [InteropEnumValue("xlDataLabelsShowValue")]
  Value = 2,
  /// <summary>
  /// Percentage of the total. Available only for pie charts and doughnut charts.
  /// </summary>
  [InteropEnumValue("xlDataLabelsShowPercent")]
  Percent = 3,
  /// <summary>
  /// Category for the point.
  /// </summary>
  [InteropEnumValue("xlDataLabelsShowLabel")]
  Label = 4,
  /// <summary>
  /// Percentage of the total, and category for the point. Available only for pie charts and doughnut charts.
  /// </summary>
  [InteropEnumValue("xlDataLabelsShowLabelAndPercent")]
  LabelAndPercent = 5,
  /// <summary>
  /// Show the size of the bubble in reference to the absolute value.
  /// </summary>
  [InteropEnumValue("xlDataLabelsShowBubbleSizes")]
  BubbleSizes = 6
}
