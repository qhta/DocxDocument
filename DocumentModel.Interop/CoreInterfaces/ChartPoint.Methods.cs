
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single point in a chart series.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint?view=office-pia
/// </remarks>
public partial interface ChartPoint
{
  /// <summary>
  /// Invokes `_ApplyDataLabels`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="IMsoLegendKey">The `IMsoLegendKey` parameter.</param>
  /// <param name="AutoText">The `AutoText` parameter.</param>
  /// <param name="HasLeaderLines">The `HasLeaderLines` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint._applydatalabels?view=office-pia
  /// </remarks>
  public object _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);
  /// <summary>
  /// Clears formatting from the chart point.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
  /// <summary>
  /// Copies the chart point.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.copy?view=office-pia
  /// </remarks>
  public object Copy();
  /// <summary>
  /// Deletes the chart point.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Pastes clipboard contents to the chart point.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.paste?view=office-pia
  /// </remarks>
  public object Paste();
  /// <summary>
  /// Selects the chart point.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Invokes `ApplyDataLabels`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="IMsoLegendKey">The `IMsoLegendKey` parameter.</param>
  /// <param name="AutoText">The `AutoText` parameter.</param>
  /// <param name="HasLeaderLines">The `HasLeaderLines` parameter.</param>
  /// <param name="ShowSeriesName">The `ShowSeriesName` parameter.</param>
  /// <param name="ShowCategoryName">The `ShowCategoryName` parameter.</param>
  /// <param name="ShowValue">The `ShowValue` parameter.</param>
  /// <param name="ShowPercentage">The `ShowPercentage` parameter.</param>
  /// <param name="ShowBubbleSize">The `ShowBubbleSize` parameter.</param>
  /// <param name="Separator">The `Separator` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.applydatalabels?view=office-pia
  /// </remarks>
  public object ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);
  /// <summary>
  /// Invokes `PieSliceLocation`.
  /// </summary>
  /// <param name="loc">The `loc` parameter.</param>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.pieslicelocation?view=office-pia
  /// </remarks>
  public double PieSliceLocation(XlPieSliceLocation loc, XlPieSliceIndex Index);
}
