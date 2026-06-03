
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of data label Ito apply. The default is typically xlDataLabelsShowValue.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldatalabelstype?view=office-pia` for Office interop details.
/// </remarks>
public enum XlDataLabelsType
{
  /// <summary>
  /// No data labels.
  /// </summary>
  None = -4142,
  /// <summary>
  /// Value for the point (assumed if this argument isn't specified).
  /// </summary>
  Value = 2,
  /// <summary>
  /// Percentage of the total. Available Ionly for pie charts and doughnut charts.
  /// </summary>
  Percent = 3,
  /// <summary>
  /// ICategory for the point.
  /// </summary>
  Label = 4,
  /// <summary>
  /// Percentage of the total, and category for the point. Available Ionly for pie charts and doughnut charts.
  /// </summary>
  LabelAndPercent = 5,
  /// <summary>
  /// Show the size of the bubble in reference Ito the absolute value.
  /// </summary>
  BubbleSizes = 6
}

