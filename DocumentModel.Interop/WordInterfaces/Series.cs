namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a series in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series?view=word-pia"/>
public partial interface Series : InteropObject
{
  /// <summary>
  /// The axis group.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.axisgroup?view=word-pia"/>
  public XlAxisGroup AxisGroup { get; set; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The error bars.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.errorbars?view=word-pia"/>
  public ErrorBars ErrorBars { get; }

  /// <summary>
  /// The explosion.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.explosion?view=word-pia"/>
  public int Explosion { get; set; }

  /// <summary>
  /// The formula.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formula?view=word-pia"/>
  public string Formula { get; set; }

  /// <summary>
  /// The formula local.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formulalocal?view=word-pia"/>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// The formula r1 c1.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formular1c1?view=word-pia"/>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// The formula r1 c1 local.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formular1c1local?view=word-pia"/>
  public string FormulaR1C1Local { get; set; }

  /// <summary>
  /// The has data labels.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.hasdatalabels?view=word-pia"/>
  public bool HasDataLabels { get; set; }

  /// <summary>
  /// The has error bars.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.haserrorbars?view=word-pia"/>
  public bool HasErrorBars { get; set; }

  /// <summary>
  /// The interior.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The invert if negative.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.invertifnegative?view=word-pia"/>
  public bool InvertIfNegative { get; set; }

  /// <summary>
  /// The marker background color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerbackgroundcolor?view=word-pia"/>
  public int MarkerBackgroundColor { get; set; }

  /// <summary>
  /// The marker background color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerbackgroundcolorindex?view=word-pia"/>
  public XlColorIndex MarkerBackgroundColorIndex { get; set; }

  /// <summary>
  /// The marker foreground color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerforegroundcolor?view=word-pia"/>
  public int MarkerForegroundColor { get; set; }

  /// <summary>
  /// The marker foreground color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerforegroundcolorindex?view=word-pia"/>
  public XlColorIndex MarkerForegroundColorIndex { get; set; }

  /// <summary>
  /// The marker size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markersize?view=word-pia"/>
  public int MarkerSize { get; set; }

  /// <summary>
  /// The marker style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerstyle?view=word-pia"/>
  public XlMarkerStyle MarkerStyle { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The picture type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.picturetype?view=word-pia"/>
  public XlChartPictureType PictureType { get; set; }

  /// <summary>
  /// The picture unit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.pictureunit?view=word-pia"/>
  public double PictureUnit { get; set; }

  /// <summary>
  /// The plot order.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.plotorder?view=word-pia"/>
  public int PlotOrder { get; set; }

  /// <summary>
  /// The smooth.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.smooth?view=word-pia"/>
  public bool Smooth { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.type?view=word-pia"/>
  public int Type { get; set; }

  /// <summary>
  /// The chart type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.charttype?view=word-pia"/>
  public object ChartType { get; set; }

  /// <summary>
  /// The values.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.values?view=word-pia"/>
  public object Values { get; set; }

  /// <summary>
  /// The xvalues.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.xvalues?view=word-pia"/>
  public object XValues { get; set; }

  /// <summary>
  /// The bubble sizes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.bubblesizes?view=word-pia"/>
  public object BubbleSizes { get; set; }

  /// <summary>
  /// The bar shape.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.barshape?view=word-pia"/>
  public XlBarShape BarShape { get; set; }

  /// <summary>
  /// The apply pict to sides.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.applypicttosides?view=word-pia"/>
  public bool ApplyPictToSides { get; set; }

  /// <summary>
  /// The apply pict to front.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.applypicttofront?view=word-pia"/>
  public bool ApplyPictToFront { get; set; }

  /// <summary>
  /// The apply pict to end.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.applypicttoend?view=word-pia"/>
  public bool ApplyPictToEnd { get; set; }

  /// <summary>
  /// The has3 deffect.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.has3deffect?view=word-pia"/>
  public bool Has3DEffect { get; set; }

  /// <summary>
  /// The shadow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// The has leader lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.hasleaderlines?view=word-pia"/>
  public bool HasLeaderLines { get; set; }

  /// <summary>
  /// The leader lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.leaderlines?view=word-pia"/>
  public LeaderLines LeaderLines { get; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// The picture unit2.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.pictureunit2?view=word-pia"/>
  public double PictureUnit2 { get; set; }

  /// <summary>
  /// The plot color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.plotcolorindex?view=word-pia"/>
  public int PlotColorIndex { get; }

  /// <summary>
  /// The invert color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.invertcolor?view=word-pia"/>
  public int InvertColor { get; set; }

  /// <summary>
  /// The invert color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.invertcolorindex?view=word-pia"/>
  public XlColorIndex InvertColorIndex { get; set; }

  /// <summary>
  /// The is filtered.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.isfiltered?view=word-pia"/>
  public bool IsFiltered { get; set; }
}
