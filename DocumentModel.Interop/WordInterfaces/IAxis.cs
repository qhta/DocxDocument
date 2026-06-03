namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single axis in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis?view=word-pia"/>
public interface IAxis : IInteropObject
{
  /// <summary>
  /// Gets or sets a value indicating whether the value axis crosses between categories.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.axisbetweencategories?view=word-pia"/>
  public bool AxisBetweenCategories { get; set; }

  /// <summary>
  /// Gets the axis group.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.axisgroup?view=word-pia"/>
  public AxisGroup AxisGroup { get; }

  /// <summary>
  /// Gets the axis title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.axistitle?view=word-pia"/>
  public IAxisTitle AxisTitle { get; }

  /// <summary>
  /// Gets or sets the category names.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.categorynames?view=word-pia"/>
  public object CategoryNames { get; set; }

  /// <summary>
  /// Gets or sets how the specified axis crosses the other axis.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.crosses?view=word-pia"/>
  public AxisCrosses Crosses { get; set; }

  /// <summary>
  /// Gets or sets the point, on the category axis, where the value axis crosses it.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.crossesat?view=word-pia"/>
  public double CrossesAt { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the axis has major gridlines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.hasmajorgridlines?view=word-pia"/>
  public bool HasMajorGridlines { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the axis has minor gridlines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.hasminorgridlines?view=word-pia"/>
  public bool HasMinorGridlines { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the axis has a visible title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.hastitle?view=word-pia"/>
  public bool HasTitle { get; set; }

  /// <summary>
  /// Gets the major gridlines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.majorgridlines?view=word-pia"/>
  public IGridlines MajorGridlines { get; }

  /// <summary>
  /// Gets or sets the major tick mark type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.majortickmark?view=word-pia"/>
  public TickMark MajorTickMark { get; set; }

  /// <summary>
  /// Gets or sets the major unit value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.majorunit?view=word-pia"/>
  public double MajorUnit { get; set; }

  /// <summary>
  /// Gets or sets the logarithmic base value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.logbase?view=word-pia"/>
  public double LogBase { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether tick-label spacing is calculated automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.ticklabelspacingisauto?view=word-pia"/>
  public bool TickLabelSpacingIsAuto { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the major unit is calculated automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.majorunitisauto?view=word-pia"/>
  public bool MajorUnitIsAuto { get; set; }

  /// <summary>
  /// Gets or sets the maximum scale value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.maximumscale?view=word-pia"/>
  public double MaximumScale { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the maximum scale is calculated automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.maximumscaleisauto?view=word-pia"/>
  public bool MaximumScaleIsAuto { get; set; }

  /// <summary>
  /// Gets or sets the minimum scale value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minimumscale?view=word-pia"/>
  public double MinimumScale { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the minimum scale is calculated automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minimumscaleisauto?view=word-pia"/>
  public bool MinimumScaleIsAuto { get; set; }

  /// <summary>
  /// Gets the minor gridlines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minorgridlines?view=word-pia"/>
  public IGridlines MinorGridlines { get; }

  /// <summary>
  /// Gets or sets the minor tick mark type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minortickmark?view=word-pia"/>
  public TickMark MinorTickMark { get; set; }

  /// <summary>
  /// Gets or sets the minor unit value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minorunit?view=word-pia"/>
  public double MinorUnit { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the minor unit is calculated automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minorunitisauto?view=word-pia"/>
  public bool MinorUnitIsAuto { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether categories or values are plotted in reverse order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.reverseplotorder?view=word-pia"/>
  public bool ReversePlotOrder { get; set; }

  /// <summary>
  /// Gets or sets the axis scale type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.scaletype?view=word-pia"/>
  public ScaleType ScaleType { get; set; }

  /// <summary>
  /// Gets or sets the tick-label position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.ticklabelposition?view=word-pia"/>
  public TickLabelPosition TickLabelPosition { get; set; }

  /// <summary>
  /// Gets the tick labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.ticklabels?view=word-pia"/>
  public ITickLabels TickLabels { get; }

  /// <summary>
  /// Gets or sets the tick-label spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.ticklabelspacing?view=word-pia"/>
  public int TickLabelSpacing { get; set; }

  /// <summary>
  /// Gets or sets the tick-mark spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.tickmarkspacing?view=word-pia"/>
  public int TickMarkSpacing { get; set; }

  /// <summary>
  /// Gets or sets the axis type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.type?view=word-pia"/>
  public AxisType Type { get; set; }

  /// <summary>
  /// Gets or sets the base time unit for category-axis labels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.baseunit?view=word-pia"/>
  public TimeUnit BaseUnit { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the base time unit is calculated automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.baseunitisauto?view=word-pia"/>
  public bool BaseUnitIsAuto { get; set; }

  /// <summary>
  /// Gets or sets the major time-unit scale.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.majorunitscale?view=word-pia"/>
  public TimeUnit MajorUnitScale { get; set; }

  /// <summary>
  /// Gets or sets the minor time-unit scale.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minorunitscale?view=word-pia"/>
  public TimeUnit MinorUnitScale { get; set; }

  /// <summary>
  /// Gets or sets the category-axis type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.categorytype?view=word-pia"/>
  public CategoryType CategoryType { get; set; }

  /// <summary>
  /// Gets the distance, in points, from the left edge of the chart area to the left edge of the axis.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.left?view=word-pia"/>
  public double Left { get; }

  /// <summary>
  /// Gets the distance, in points, from the top edge of the chart area to the top edge of the axis.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.top?view=word-pia"/>
  public double Top { get; }

  /// <summary>
  /// Gets the width of the axis, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// Gets the height of the axis, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// Gets or sets the display unit for the value axis.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.displayunit?view=word-pia"/>
  public DisplayUnit DisplayUnit { get; set; }

  /// <summary>
  /// Gets or sets the custom display-unit value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.displayunitcustom?view=word-pia"/>
  public double DisplayUnitCustom { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the axis has a display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.hasdisplayunitlabel?view=word-pia"/>
  public bool HasDisplayUnitLabel { get; set; }

  /// <summary>
  /// Gets the display-unit label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.displayunitlabel?view=word-pia"/>
  public IDisplayUnitLabel DisplayUnitLabel { get; }

  /// <summary>
  /// Gets the axis border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.border?view=word-pia"/>
  public IChartBorder Border { get; }

  /// <summary>
  /// Gets the chart formatting for the axis.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.format?view=word-pia"/>
  public IChartFormat Format { get; }


  #region methods

/// <summary>
  /// Deletes the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.delete?view=word-pia"/>
  public void Delete();

  #endregion methods
}
