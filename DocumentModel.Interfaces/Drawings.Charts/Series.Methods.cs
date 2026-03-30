
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a chart series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries?view=office-pia"/>
public partial interface ISeries: IModelObject
{
  /// <summary>
  /// Applies data labels to the series.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="IMsoLegendKey">The `IMsoLegendKey` parameter.</param>
  /// <param name="AutoText">The `AutoText` parameter.</param>
  /// <param name="HasLeaderLines">The `HasLeaderLines` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries._applydatalabels?view=office-pia"/>
  public object _ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines);
  /// <summary>
  /// Clears formatting from the series.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.clearformats?view=office-pia"/>
  public object ClearFormats();
  /// <summary>
  /// Copies the series.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.copy?view=office-pia"/>
  public object Copy();
  /// <summary>
  /// Returns data labels for the series.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.datalabels?view=office-pia"/>
  public object DataLabels(object Index);
  /// <summary>
  /// Deletes the series.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Sets error bar options for the series.
  /// </summary>
  /// <param name="Direction">The `Direction` parameter.</param>
  /// <param name="Include">The `Include` parameter.</param>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Amount">The `Amount` parameter.</param>
  /// <param name="MinusValues">The `MinusValues` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.errorbar?view=office-pia"/>
  public object ErrorBar
    (XlErrorBarDirection Direction, XlErrorBarInclude Include, XlErrorBarType Type, object Amount, object MinusValues);
  /// <summary>
  /// Pastes data into the series.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.paste?view=office-pia"/>
  public object Paste();
  /// <summary>
  /// Returns points in the series.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.points?view=office-pia"/>
  public object Points(object Index);
  /// <summary>
  /// Selects the series.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Returns trendlines for the series.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.trendlines?view=office-pia"/>
  public object Trendlines(object Index);
  /// <summary>
  /// Applies a custom chart type to the series.
  /// </summary>
  /// <param name="ChartType">The `ChartType` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applycustomtype?view=office-pia"/>
  public void ApplyCustomType(ChartType ChartType);
  /// <summary>
  /// Applies data labels to the series with detailed display options.
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applydatalabels?view=office-pia"/>
  public object ApplyDataLabels
  (XlDataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);
}

