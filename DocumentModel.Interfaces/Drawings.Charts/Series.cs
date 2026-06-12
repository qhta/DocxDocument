
using DocumentModel.Wordprocessing;

namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a chart series.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries?view=office-pia"/>
public partial interface ISeries: IModelObject
{
  /// <summary>
  /// Gets or sets the `AxisGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.axisgroup?view=office-pia"/>
  public XlAxisGroup XlAxisGroup { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.border?view=office-pia"/>
  public IBorder Border { get; }
  /// <summary>
  /// Gets the `ErrorBars` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.errorbars?view=office-pia"/>
  public IErrorBars ErrorBars { get; }
  /// <summary>
  /// Gets or sets the `Explosion` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.explosion?view=office-pia"/>
  public int Explosion { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Formula` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formula?view=office-pia"/>
  public string Formula { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FormulaLocal` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formulalocal?view=office-pia"/>
  public string FormulaLocal { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formular1c1?view=office-pia"/>
  public string FormulaR1C1 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `FormulaR1C1Local` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.formular1c1local?view=office-pia"/>
  public string FormulaR1C1Local { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `HasDataLabels` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.hasdatalabels?view=office-pia"/>
  public bool HasDataLabels { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `HasErrorBars` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.haserrorbars?view=office-pia"/>
  public bool HasErrorBars { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `Interior` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.interior?view=office-pia"/>
  public Interior Interior { get; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.fill?view=office-pia"/>
  public IChartFillFormat Fill { get; }
  /// <summary>
  /// Gets or sets the `InvertIfNegative` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.invertifnegative?view=office-pia"/>
  public bool InvertIfNegative { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerbackgroundcolor?view=office-pia"/>
  public int MarkerBackgroundColor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerBackgroundColorIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerbackgroundcolorindex?view=office-pia"/>
  public ColorIndex MarkerBackgroundColorIndex { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerforegroundcolor?view=office-pia"/>
  public int MarkerForegroundColor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerForegroundColorIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerforegroundcolorindex?view=office-pia"/>
  public ColorIndex MarkerForegroundColorIndex { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerSize` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markersize?view=office-pia"/>
  public int MarkerSize { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `MarkerStyle` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.markerstyle?view=office-pia"/>
  public MarkerStyle MarkerStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.name?view=office-pia"/>
  public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `PictureType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.picturetype?view=office-pia"/>
  public XlChartPictureType PictureType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `PictureUnit` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.pictureunit?view=office-pia"/>
  public double PictureUnit { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `PlotOrder` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.plotorder?view=office-pia"/>
  public int PlotOrder { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Smooth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.smooth?view=office-pia"/>
  public bool Smooth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.type?view=office-pia"/>
  public int Type { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ChartType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.charttype?view=office-pia"/>
  public ChartType ChartType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Values` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.values?view=office-pia"/>
  public object Values { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `XValues` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.xvalues?view=office-pia"/>
  public object XValues { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `BubbleSizes` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.bubblesizes?view=office-pia"/>
  public object BubbleSizes { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `BarShape` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.barshape?view=office-pia"/>
  public XlBarShape BarShape { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ApplyPictToSides` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applypicttosides?view=office-pia"/>
  public bool ApplyPictToSides { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ApplyPictToFront` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applypicttofront?view=office-pia"/>
  public bool ApplyPictToFront { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ApplyPictToEnd` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.applypicttoend?view=office-pia"/>
  public bool ApplyPictToEnd { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Has3DEffect` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.has3deffect?view=office-pia"/>
  public bool Has3DEffect { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Shadow` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.shadow?view=office-pia"/>
  public bool Shadow { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `HasLeaderLines` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.hasleaderlines?view=office-pia"/>
  public bool HasLeaderLines { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `LeaderLines` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.leaderlines?view=office-pia"/>
  public ILeaderLines LeaderLines { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.format?view=office-pia"/>
  public IChartFormat Format { get; }
  /// <summary>
  /// Gets or sets the `PictureUnit2` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.pictureunit2?view=office-pia"/>
  public double PictureUnit2 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets the `PlotColorIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.plotcolorindex?view=office-pia"/>
  public int PlotColorIndex { get; }
  /// <summary>
  /// Gets or sets the `InvertColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.invertcolor?view=office-pia"/>
  public int InvertColor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `InvertColorIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.invertcolorindex?view=office-pia"/>
  public ColorIndex InvertColorIndex { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `IsFiltered` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoseries.isfiltered?view=office-pia"/>
  public bool IsFiltered { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

