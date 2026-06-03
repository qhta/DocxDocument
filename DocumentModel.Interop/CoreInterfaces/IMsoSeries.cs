
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries?view=office-pia"/>
public interface IMsoSeries
{
  /// <summary>
  /// Gets or sets the `AxisGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.axisgroup?view=office-pia"/>
  public AxisGroup AxisGroup { get; set; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `ErrorBars` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.errorbars?view=office-pia"/>
  public IMsoErrorBars ErrorBars { get; }
  /// <summary>
  /// Gets or sets the `Explosion` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.explosion?view=office-pia"/>
  public int Explosion { get; set; }
  /// <summary>
  /// Gets or sets the `Formula` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formula?view=office-pia"/>
  public string Formula { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaLocal` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formulalocal?view=office-pia"/>
  public string FormulaLocal { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formular1c1?view=office-pia"/>
  public string FormulaR1C1 { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1Local` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formular1c1local?view=office-pia"/>
  public string FormulaR1C1Local { get; set; }
  /// <summary>
  /// Gets or sets the `HasDataLabels` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.hasdatalabels?view=office-pia"/>
  public bool HasDataLabels { get; set; }
  /// <summary>
  /// Gets or sets the `HasErrorBars` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.haserrorbars?view=office-pia"/>
  public bool HasErrorBars { get; set; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.interior?view=office-pia"/>
  public IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.fill?view=office-pia"/>
  public IChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `InvertIfNegative` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.invertifnegative?view=office-pia"/>
  public bool InvertIfNegative { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerbackgroundcolor?view=office-pia"/>
  public int MarkerBackgroundColor { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColorIndex` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerbackgroundcolorindex?view=office-pia"/>
  public ColorIndex MarkerBackgroundColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerforegroundcolor?view=office-pia"/>
  public int MarkerForegroundColor { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColorIndex` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerforegroundcolorindex?view=office-pia"/>
  public ColorIndex MarkerForegroundColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerSize` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markersize?view=office-pia"/>
  public int MarkerSize { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerstyle?view=office-pia"/>
  public MarkerStyle MarkerStyle { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.name?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `PictureType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.picturetype?view=office-pia"/>
  public ChartPictureType PictureType { get; set; }
  /// <summary>
  /// Gets or sets the `PictureUnit` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.pictureunit?view=office-pia"/>
  public double PictureUnit { get; set; }
  /// <summary>
  /// Gets or sets the `PlotOrder` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.plotorder?view=office-pia"/>
  public int PlotOrder { get; set; }
  /// <summary>
  /// Gets or sets the `Smooth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.smooth?view=office-pia"/>
  public bool Smooth { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.type?view=office-pia"/>
  public int Type { get; set; }
  /// <summary>
  /// Gets or sets the `ChartType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.charttype?view=office-pia"/>
  public ChartType ChartType { get; set; }
  /// <summary>
  /// Gets or sets the `Values` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.values?view=office-pia"/>
  public object Values { get; set; }
  /// <summary>
  /// Gets or sets the `XValues` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.xvalues?view=office-pia"/>
  public object XValues { get; set; }
  /// <summary>
  /// Gets or sets the `BubbleSizes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.bubblesizes?view=office-pia"/>
  public object BubbleSizes { get; set; }
  /// <summary>
  /// Gets or sets the `BarShape` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.barshape?view=office-pia"/>
  public BarShape BarShape { get; set; }
  /// <summary>
  /// Gets or sets the `ApplyPictToSides` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applypicttosides?view=office-pia"/>
  public bool ApplyPictToSides { get; set; }
  /// <summary>
  /// Gets or sets the `ApplyPictToFront` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applypicttofront?view=office-pia"/>
  public bool ApplyPictToFront { get; set; }
  /// <summary>
  /// Gets or sets the `ApplyPictToEnd` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applypicttoend?view=office-pia"/>
  public bool ApplyPictToEnd { get; set; }
  /// <summary>
  /// Gets or sets the `Has3DEffect` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.has3deffect?view=office-pia"/>
  public bool Has3DEffect { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.shadow?view=office-pia"/>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `HasLeaderLines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.hasleaderlines?view=office-pia"/>
  public bool HasLeaderLines { get; set; }
  /// <summary>
  /// Gets the `LeaderLines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.leaderlines?view=office-pia"/>
  public IMsoLeaderLines LeaderLines { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.format?view=office-pia"/>
  public IMsoChartFormat Format { get; }
  /// <summary>
  /// Gets or sets the `PictureUnit2` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.pictureunit2?view=office-pia"/>
  public double PictureUnit2 { get; set; }
  /// <summary>
  /// Gets the `PlotColorIndex` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.plotcolorindex?view=office-pia"/>
  public int PlotColorIndex { get; }
  /// <summary>
  /// Gets or sets the `InvertColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.invertcolor?view=office-pia"/>
  public int InvertColor { get; set; }
  /// <summary>
  /// Gets or sets the `InvertColorIndex` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.invertcolorindex?view=office-pia"/>
  public ColorIndex InvertColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `IsFiltered` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.isfiltered?view=office-pia"/>
  public bool IsFiltered { get; set; }


  #region methods

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
  (DataLabelsType Type, object IMsoLegendKey, object AutoText,
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
    (ErrorBarDirection Direction, ErrorBarInclude Include, ErrorBarType Type, object Amount, object MinusValues);
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
  (DataLabelsType Type, object IMsoLegendKey, object AutoText,
    object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,
    object ShowBubbleSize, object Separator);

  #endregion methods
}

