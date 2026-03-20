
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
  /// Gets or sets the `AxisGroup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.axisgroup?view=office-pia
  /// </remarks>
  public XlAxisGroup AxisGroup { get; set; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.border?view=office-pia
  /// </remarks>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `ErrorBars` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.errorbars?view=office-pia
  /// </remarks>
  public IMsoErrorBars ErrorBars { get; }
  /// <summary>
  /// Gets or sets the `Explosion` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.explosion?view=office-pia
  /// </remarks>
  public int Explosion { get; set; }
  /// <summary>
  /// Gets or sets the `Formula` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formula?view=office-pia
  /// </remarks>
  public string Formula { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaLocal` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formulalocal?view=office-pia
  /// </remarks>
  public string FormulaLocal { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formular1c1?view=office-pia
  /// </remarks>
  public string FormulaR1C1 { get; set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1Local` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formular1c1local?view=office-pia
  /// </remarks>
  public string FormulaR1C1Local { get; set; }
  /// <summary>
  /// Gets or sets the `HasDataLabels` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.hasdatalabels?view=office-pia
  /// </remarks>
  public bool HasDataLabels { get; set; }
  /// <summary>
  /// Gets or sets the `HasErrorBars` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.haserrorbars?view=office-pia
  /// </remarks>
  public bool HasErrorBars { get; set; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.interior?view=office-pia
  /// </remarks>
  public IMsoInterior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.fill?view=office-pia
  /// </remarks>
  public ChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `InvertIfNegative` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.invertifnegative?view=office-pia
  /// </remarks>
  public bool InvertIfNegative { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerbackgroundcolor?view=office-pia
  /// </remarks>
  public int MarkerBackgroundColor { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColorIndex` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerbackgroundcolorindex?view=office-pia
  /// </remarks>
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerforegroundcolor?view=office-pia
  /// </remarks>
  public int MarkerForegroundColor { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColorIndex` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerforegroundcolorindex?view=office-pia
  /// </remarks>
  public XlColorIndex MarkerForegroundColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerSize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markersize?view=office-pia
  /// </remarks>
  public int MarkerSize { get; set; }
  /// <summary>
  /// Gets or sets the `MarkerStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerstyle?view=office-pia
  /// </remarks>
  public XlMarkerStyle MarkerStyle { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `PictureType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.picturetype?view=office-pia
  /// </remarks>
  public XlChartPictureType PictureType { get; set; }
  /// <summary>
  /// Gets or sets the `PictureUnit` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.pictureunit?view=office-pia
  /// </remarks>
  public double PictureUnit { get; set; }
  /// <summary>
  /// Gets or sets the `PlotOrder` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.plotorder?view=office-pia
  /// </remarks>
  public int PlotOrder { get; set; }
  /// <summary>
  /// Gets or sets the `Smooth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.smooth?view=office-pia
  /// </remarks>
  public bool Smooth { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.type?view=office-pia
  /// </remarks>
  public int Type { get; set; }
  /// <summary>
  /// Gets or sets the `ChartType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.charttype?view=office-pia
  /// </remarks>
  public XlChartType ChartType { get; set; }
  /// <summary>
  /// Gets or sets the `Values` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.values?view=office-pia
  /// </remarks>
  public object Values { get; set; }
  /// <summary>
  /// Gets or sets the `XValues` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.xvalues?view=office-pia
  /// </remarks>
  public object XValues { get; set; }
  /// <summary>
  /// Gets or sets the `BubbleSizes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.bubblesizes?view=office-pia
  /// </remarks>
  public object BubbleSizes { get; set; }
  /// <summary>
  /// Gets or sets the `BarShape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.barshape?view=office-pia
  /// </remarks>
  public XlBarShape BarShape { get; set; }
  /// <summary>
  /// Gets or sets the `ApplyPictToSides` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applypicttosides?view=office-pia
  /// </remarks>
  public bool ApplyPictToSides { get; set; }
  /// <summary>
  /// Gets or sets the `ApplyPictToFront` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applypicttofront?view=office-pia
  /// </remarks>
  public bool ApplyPictToFront { get; set; }
  /// <summary>
  /// Gets or sets the `ApplyPictToEnd` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applypicttoend?view=office-pia
  /// </remarks>
  public bool ApplyPictToEnd { get; set; }
  /// <summary>
  /// Gets or sets the `Has3DEffect` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.has3deffect?view=office-pia
  /// </remarks>
  public bool Has3DEffect { get; set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.shadow?view=office-pia
  /// </remarks>
  public bool Shadow { get; set; }
  /// <summary>
  /// Gets or sets the `HasLeaderLines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.hasleaderlines?view=office-pia
  /// </remarks>
  public bool HasLeaderLines { get; set; }
  /// <summary>
  /// Gets the `LeaderLines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.leaderlines?view=office-pia
  /// </remarks>
  public IMsoLeaderLines LeaderLines { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.format?view=office-pia
  /// </remarks>
  public IMsoChartFormat Format { get; }
  /// <summary>
  /// Gets or sets the `PictureUnit2` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.pictureunit2?view=office-pia
  /// </remarks>
  public double PictureUnit2 { get; set; }
  /// <summary>
  /// Gets the `PlotColorIndex` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.plotcolorindex?view=office-pia
  /// </remarks>
  public int PlotColorIndex { get; }
  /// <summary>
  /// Gets or sets the `InvertColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.invertcolor?view=office-pia
  /// </remarks>
  public int InvertColor { get; set; }
  /// <summary>
  /// Gets or sets the `InvertColorIndex` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.invertcolorindex?view=office-pia
  /// </remarks>
  public XlColorIndex InvertColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `IsFiltered` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.isfiltered?view=office-pia
  /// </remarks>
  public bool IsFiltered { get; set; }
}
