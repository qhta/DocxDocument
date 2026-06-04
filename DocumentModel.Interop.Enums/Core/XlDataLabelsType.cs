
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of data label to apply. The default is typically xlDataLabelsShowValue.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldatalabelstype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlDataLabelsType")]
public enum DataLabelsType
{
  /// <summary>
  /// No data labels.
  /// </summary>
  [OfficeInteropEnumValue("xlDataLabelsShowNone")]
  None = -4142,
  /// <summary>
  /// Value for the point (assumed if this argument isn't specified).
  /// </summary>
  [OfficeInteropEnumValue("xlDataLabelsShowValue")]
  Value = 2,
  /// <summary>
  /// Percentage of the total. Available only for pie charts and doughnut charts.
  /// </summary>
  [OfficeInteropEnumValue("xlDataLabelsShowPercent")]
  Percent = 3,
  /// <summary>
  /// Category for the point.
  /// </summary>
  [OfficeInteropEnumValue("xlDataLabelsShowLabel")]
  Label = 4,
  /// <summary>
  /// Percentage of the total, and category for the point. Available only for pie charts and doughnut charts.
  /// </summary>
  [OfficeInteropEnumValue("xlDataLabelsShowLabelAndPercent")]
  LabelAndPercent = 5,
  /// <summary>
  /// Show the size of the bubble in reference to the absolute value.
  /// </summary>
  [OfficeInteropEnumValue("xlDataLabelsShowBubbleSizes")]
  BubbleSizes = 6
}
