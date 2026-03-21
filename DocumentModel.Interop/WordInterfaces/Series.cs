namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a series in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series?view=word-pia"/>
public partial interface Series : InteropObject
{
  /// <summary>
  /// Returns or sets the axis group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.axisgroup?view=word-pia"/>
  public XlAxisGroup AxisGroup { get; set; }

  /// <summary>
  /// Returns the border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns the error bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.errorbars?view=word-pia"/>
  public ErrorBars ErrorBars { get; }

  /// <summary>
  /// Returns or sets the explosion.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.explosion?view=word-pia"/>
  public int Explosion { get; set; }

  /// <summary>
  /// Returns or sets the formula.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formula?view=word-pia"/>
  public string Formula { get; set; }

  /// <summary>
  /// Returns or sets the formula local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formulalocal?view=word-pia"/>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// Returns or sets the formula r1 c1.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formular1c1?view=word-pia"/>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// Returns or sets the formula r1 c1 local.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formular1c1local?view=word-pia"/>
  public string FormulaR1C1Local { get; set; }

  /// <summary>
  /// Returns or sets whether data labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.hasdatalabels?view=word-pia"/>
  public bool HasDataLabels { get; set; }

  /// <summary>
  /// Returns or sets whether error bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.haserrorbars?view=word-pia"/>
  public bool HasErrorBars { get; set; }

  /// <summary>
  /// Returns the interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Returns the fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Returns or sets whether invert if negative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.invertifnegative?view=word-pia"/>
  public bool InvertIfNegative { get; set; }

  /// <summary>
  /// Returns or sets the marker background color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerbackgroundcolor?view=word-pia"/>
  public int MarkerBackgroundColor { get; set; }

  /// <summary>
  /// Returns or sets the marker background color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerbackgroundcolorindex?view=word-pia"/>
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }

  /// <summary>
  /// Returns or sets the marker foreground color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerforegroundcolor?view=word-pia"/>
  public int MarkerForegroundColor { get; set; }

  /// <summary>
  /// Returns or sets the marker foreground color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerforegroundcolorindex?view=word-pia"/>
  public XlColorIndex MarkerForegroundColorIndex { get; set; }

  /// <summary>
  /// Returns or sets the marker size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markersize?view=word-pia"/>
  public int MarkerSize { get; set; }

  /// <summary>
  /// Returns or sets the marker style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerstyle?view=word-pia"/>
  public XlMarkerStyle MarkerStyle { get; set; }

  /// <summary>
  /// Returns or sets the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Returns or sets the picture type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.picturetype?view=word-pia"/>
  public XlChartPictureType PictureType { get; set; }

  /// <summary>
  /// Returns or sets the picture unit.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.pictureunit?view=word-pia"/>
  public double PictureUnit { get; set; }

  /// <summary>
  /// Returns or sets the plot order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.plotorder?view=word-pia"/>
  public int PlotOrder { get; set; }

  /// <summary>
  /// Returns or sets whether smooth.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.smooth?view=word-pia"/>
  public bool Smooth { get; set; }

  /// <summary>
  /// Returns or sets the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.type?view=word-pia"/>
  public int Type { get; set; }

  /// <summary>
  /// Returns or sets the chart type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.charttype?view=word-pia"/>
  public object ChartType { get; set; }

  /// <summary>
  /// Returns or sets the values.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.values?view=word-pia"/>
  public object Values { get; set; }

  /// <summary>
  /// Returns or sets the x values.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.xvalues?view=word-pia"/>
  public object XValues { get; set; }

  /// <summary>
  /// Returns or sets the bubble sizes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.bubblesizes?view=word-pia"/>
  public object BubbleSizes { get; set; }

  /// <summary>
  /// Returns or sets the bar shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.barshape?view=word-pia"/>
  public XlBarShape BarShape { get; set; }

  /// <summary>
  /// Returns or sets whether apply pict to sides.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.applypicttosides?view=word-pia"/>
  public bool ApplyPictToSides { get; set; }

  /// <summary>
  /// Returns or sets whether apply pict to front.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.applypicttofront?view=word-pia"/>
  public bool ApplyPictToFront { get; set; }

  /// <summary>
  /// Returns or sets whether apply pict to end.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.applypicttoend?view=word-pia"/>
  public bool ApplyPictToEnd { get; set; }

  /// <summary>
  /// Returns or sets whether 3 d effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.has3deffect?view=word-pia"/>
  public bool Has3DEffect { get; set; }

  /// <summary>
  /// Returns or sets whether shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Returns or sets whether leader lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.hasleaderlines?view=word-pia"/>
  public bool HasLeaderLines { get; set; }

  /// <summary>
  /// Returns the leader lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.leaderlines?view=word-pia"/>
  public LeaderLines LeaderLines { get; }

  /// <summary>
  /// Returns the format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Returns or sets the picture unit2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.pictureunit2?view=word-pia"/>
  public double PictureUnit2 { get; set; }

  /// <summary>
  /// Returns the plot color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.plotcolorindex?view=word-pia"/>
  public int PlotColorIndex { get; }

  /// <summary>
  /// Returns or sets the invert color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.invertcolor?view=word-pia"/>
  public int InvertColor { get; set; }

  /// <summary>
  /// Returns or sets the invert color index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.invertcolorindex?view=word-pia"/>
  public XlColorIndex InvertColorIndex { get; set; }

  /// <summary>
  /// Returns or sets whether filtered.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.isfiltered?view=word-pia"/>
  public bool IsFiltered { get; set; }
}
