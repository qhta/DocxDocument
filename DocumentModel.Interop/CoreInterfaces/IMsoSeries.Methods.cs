
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoSeries` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoSeries
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
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries._applydatalabels?view=office-pia
  /// </remarks>
  public object _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);
  /// <summary>
  /// Invokes `ClearFormats`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.copy?view=office-pia
  /// </remarks>
  public object Copy();
  /// <summary>
  /// Invokes `DataLabels`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.datalabels?view=office-pia
  /// </remarks>
  public object DataLabels(object Index);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Invokes `ErrorBar`.
  /// </summary>
  /// <param name="Direction">The `Direction` parameter.</param>
  /// <param name="Include">The `Include` parameter.</param>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Amount">The `Amount` parameter.</param>
  /// <param name="MinusValues">The `MinusValues` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.errorbar?view=office-pia
  /// </remarks>
  public object ErrorBar
    (XlErrorBarDirection Direction, XlErrorBarInclude Include, XlErrorBarType Type, object Amount, object MinusValues);
  /// <summary>
  /// Invokes `Paste`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.paste?view=office-pia
  /// </remarks>
  public object Paste();
  /// <summary>
  /// Invokes `Points`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.points?view=office-pia
  /// </remarks>
  public object Points(object Index);
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Invokes `Trendlines`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.trendlines?view=office-pia
  /// </remarks>
  public object Trendlines(object Index);
  /// <summary>
  /// Invokes `ApplyCustomType`.
  /// </summary>
  /// <param name="ChartType">The `ChartType` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applycustomtype?view=office-pia
  /// </remarks>
  public void ApplyCustomType(XlChartType ChartType);
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
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applydatalabels?view=office-pia
  /// </remarks>
  public object ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);
}
