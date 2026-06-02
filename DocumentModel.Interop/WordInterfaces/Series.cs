namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a series in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series?view=word-pia"/>
public partial interface ISeries : IInteropObject
{
  /// <summary>
  /// Returns an AxisGroup value that represents the type of axis group. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.axisgroup?view=word-pia"/>
  public AxisGroup AxisGroup { get; set; }

  /// <summary>
  /// Returns a ChartBorder object that represents the border of the object. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns an ErrorBars object that represents the error bars for the series. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.errorbars?view=word-pia"/>
  public ErrorBars ErrorBars { get; }

  /// <summary>
  /// Returns or sets the explosion value for a pie-chart or doughnut-chart slice. Returns 0 (zero) if there's no
  /// explosion (the tip of the slice is in the center of the pie). Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.explosion?view=word-pia"/>
  public int Explosion { get; set; }

  /// <summary>
  /// Returns or sets a String value that represents the object's formula in A1-style notation and in the language
  /// of the macro.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formula?view=word-pia"/>
  public string Formula { get; set; }

  /// <summary>
  /// Returns or sets the formula for the object, using A1-style references in the language of the user. Read/write
  /// String.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formulalocal?view=word-pia"/>
  public string FormulaLocal { get; set; }

  /// <summary>
  /// Returns or sets the formula for the object, using R1C1-style notation in the language of the macro. Read/write
  /// String.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formular1c1?view=word-pia"/>
  public string FormulaR1C1 { get; set; }

  /// <summary>
  /// Returns or sets the formula for the object, using R1C1-style notation in the language of the user. Read/write
  /// String.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.formular1c1local?view=word-pia"/>
  public string FormulaR1C1Local { get; set; }

  /// <summary>
  /// True if the series has data labels. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.hasdatalabels?view=word-pia"/>
  public bool HasDataLabels { get; set; }

  /// <summary>
  /// True if the series has error bars. This property isn’t available for 3-D charts. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.haserrorbars?view=word-pia"/>
  public bool HasErrorBars { get; set; }

  /// <summary>
  /// Returns the Interior object for the series.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Returns the ChartFillFormat for this series.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// True if Microsoft Word inverts the pattern in the object when it corresponds to a negative number. Read/write
  /// Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.invertifnegative?view=word-pia"/>
  public bool InvertIfNegative { get; set; }

  /// <summary>
  /// Sets the marker background color as an RGB value or returns the corresponding color index value. Applies only
  /// to line, scatter, and radar charts. Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerbackgroundcolor?view=word-pia"/>
  public int MarkerBackgroundColor { get; set; }

  /// <summary>
  /// Returns or sets the marker background color as an index into the current color palette, or as one of the
  /// following ColorIndex constants: xlColorIndexAutomatic or xlColorIndexNone. Applies only to line, scatter,
  /// and radar charts. Read/write
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerbackgroundcolorindex?view=word-pia"/>
  public ColorIndex MarkerBackgroundColorIndex { get; set; }

  /// <summary>
  /// Sets the marker foreground color as an RGB value or returns the corresponding color index value. Applies only
  /// to line, scatter, and radar charts. Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerforegroundcolor?view=word-pia"/>
  public int MarkerForegroundColor { get; set; }

  /// <summary>
  /// Returns or sets the marker foreground color as an index into the current color palette, or as one of the
  /// following ColorIndex constants: xlColorIndexAutomatic or xlColorIndexNone. Applies only to line, scatter,
  /// and radar charts. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerforegroundcolorindex?view=word-pia"/>
  public ColorIndex MarkerForegroundColorIndex { get; set; }

  /// <summary>
  /// Returns or sets the data-marker size, in points. Can be a value from 2 through 72. Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markersize?view=word-pia"/>
  public int MarkerSize { get; set; }

  /// <summary>
  /// Returns or sets the marker style for a point or series in a line chart, scatter chart, or radar chart.
  /// Read/write MarkerStyle.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.markerstyle?view=word-pia"/>
  public MarkerStyle MarkerStyle { get; set; }

  /// <summary>
  /// Returns or sets a String value that represents the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Returns or sets a ChartPictureType value that represents the way pictures are displayed on a column or bar
  /// picture chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.picturetype?view=word-pia"/>
  public ChartPictureType PictureType { get; set; }

  /// <summary>
  /// Returns or sets the unit for each picture on the chart if the PictureType property is set to xlStackScale (if
  /// not, this property is ignored).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.pictureunit?view=word-pia"/>
  public double PictureUnit { get; set; }

  /// <summary>
  /// Returns or sets the plot order for the selected series within the chart group. Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.plotorder?view=word-pia"/>
  public int PlotOrder { get; set; }

  /// <summary>
  /// True if curve smoothing is turned on for the line chart or scatter chart. Applies only to line and scatter
  /// charts. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.smooth?view=word-pia"/>
  public bool Smooth { get; set; }

  /// <summary>
  /// Returns or sets a Integer value that represents the series type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.type?view=word-pia"/>
  public int Type { get; set; }

  /// <summary>
  /// Returns or sets the chart type. Read/write ChartType.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.charttype?view=word-pia"/>
  public object ChartType { get; set; }

  /// <summary>
  /// Returns or sets a Object value that represents a collection of all the values in the series.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.values?view=word-pia"/>
  public object Values { get; set; }

  /// <summary>
  /// Returns or sets an array of x values for a chart series. The XValues property can be set to a range on a
  /// worksheet or to an array of values, but it cannot be a combination of both. Read/write Object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.xvalues?view=word-pia"/>
  public object XValues { get; set; }

  /// <summary>
  /// Returns or sets a string that refers to the worksheet cells containing the x-value, y-value and size data for
  /// the bubble chart. Read/write Object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.bubblesizes?view=word-pia"/>
  public object BubbleSizes { get; set; }

  /// <summary>
  /// Returns or sets the shape used for a single series in a 3-D bar or column chart. Read/write BarShape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.barshape?view=word-pia"/>
  public BarShape BarShape { get; set; }

  /// <summary>
  /// True if a picture is applied to the sides of the point or all points in the series. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.applypicttosides?view=word-pia"/>
  public bool ApplyPictToSides { get; set; }

  /// <summary>
  /// True if a picture is applied to the front of the point or all points in the series. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.applypicttofront?view=word-pia"/>
  public bool ApplyPictToFront { get; set; }

  /// <summary>
  /// True if a picture is applied to the end of the point or all points in the series. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.applypicttoend?view=word-pia"/>
  public bool ApplyPictToEnd { get; set; }

  /// <summary>
  /// True if the series has a three-dimensional appearance. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.has3deffect?view=word-pia"/>
  public bool Has3DEffect { get; set; }

  /// <summary>
  /// Returns or sets a Boolean value that determines if the object has a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// True if the series has leader lines. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.hasleaderlines?view=word-pia"/>
  public bool HasLeaderLines { get; set; }

  /// <summary>
  /// Returns a LeaderLines object that represents the leader lines for the series. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.leaderlines?view=word-pia"/>
  public LeaderLines LeaderLines { get; }

  /// <summary>
  /// Returns the line, fill, and effect formatting for the object. Read-only ChartFormat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.format?view=word-pia"/>
  public ChartFormat Format { get; }

  /// <summary>
  /// Returns or sets the unit for each picture on the chart if the PictureType property is set to xlStackScale (if
  /// not, this property is ignored). Read/write Double.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.pictureunit2?view=word-pia"/>
  public double PictureUnit2 { get; set; }

  /// <summary>
  /// Gets an index value that is used internally to associate series formatting with chart elements.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.plotcolorindex?view=word-pia"/>
  public int PlotColorIndex { get; }

  /// <summary>
  /// Gets or sets the fill color for negative data points in a series.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.invertcolor?view=word-pia"/>
  public int InvertColor { get; set; }

  /// <summary>
  /// Gets or sets the fill color for negative data points in a series.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.invertcolorindex?view=word-pia"/>
  public ColorIndex InvertColorIndex { get; set; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) that determines whether the specified chart series is filtered out from
  /// the chart. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.series.isfiltered?view=word-pia"/>
  public bool IsFiltered { get; set; }
}
