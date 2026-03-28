
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// category labels for the category label levels.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlcategorylabellevel?view=office-pia` for Office interop details.
/// </remarks>
public enum XlCategoryLabelLevel
{
  /// <summary>
  /// Set no category labels in the chart. Defaults to automatic indexed labels.
  /// </summary>
  None = -3,
  /// <summary>
  /// Indicates literal data in the category labels.
  /// </summary>
  Custom,
  /// <summary>
  /// Set category labels to all category label levels w/in range on the chart.
  /// </summary>
  All
}
