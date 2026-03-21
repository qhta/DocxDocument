namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single axis in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis?view=word-pia"/>
public partial interface Axis : InteropObject
{
  /// <summary>
  /// The axis between categories.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.axisbetweencategories?view=word-pia"/>
  public bool AxisBetweenCategories { get; set; }

  /// <summary>
  /// The axis group.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.axisgroup?view=word-pia"/>
  public XlAxisGroup AxisGroup { get; }

  /// <summary>
  /// The axis title.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.axistitle?view=word-pia"/>
  public AxisTitle AxisTitle { get; }

  /// <summary>
  /// The category names.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.categorynames?view=word-pia"/>
  public object CategoryNames { get; set; }

  /// <summary>
  /// The crosses.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.crosses?view=word-pia"/>
  public XlAxisCrosses Crosses { get; set; }

  /// <summary>
  /// The crosses at.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.crossesat?view=word-pia"/>
  public double CrossesAt { get; set; }

  /// <summary>
  /// The has major gridlines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.hasmajorgridlines?view=word-pia"/>
  public bool HasMajorGridlines { get; set; }

  /// <summary>
  /// The has minor gridlines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.hasminorgridlines?view=word-pia"/>
  public bool HasMinorGridlines { get; set; }

  /// <summary>
  /// The has title.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.hastitle?view=word-pia"/>
  public bool HasTitle { get; set; }

  /// <summary>
  /// The major gridlines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.majorgridlines?view=word-pia"/>
  public Gridlines MajorGridlines { get; }

  /// <summary>
  /// The major tick mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.majortickmark?view=word-pia"/>
  public XlTickMark MajorTickMark { get; set; }

  /// <summary>
  /// The major unit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.majorunit?view=word-pia"/>
  public double MajorUnit { get; set; }

  /// <summary>
  /// The log base.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.logbase?view=word-pia"/>
  public double LogBase { get; set; }

  /// <summary>
  /// The tick label spacing is auto.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.ticklabelspacingisauto?view=word-pia"/>
  public bool TickLabelSpacingIsAuto { get; set; }

  /// <summary>
  /// The major unit is auto.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.majorunitisauto?view=word-pia"/>
  public bool MajorUnitIsAuto { get; set; }

  /// <summary>
  /// The maximum scale.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.maximumscale?view=word-pia"/>
  public double MaximumScale { get; set; }

  /// <summary>
  /// The maximum scale is auto.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.maximumscaleisauto?view=word-pia"/>
  public bool MaximumScaleIsAuto { get; set; }

  /// <summary>
  /// The minimum scale.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minimumscale?view=word-pia"/>
  public double MinimumScale { get; set; }

  /// <summary>
  /// The minimum scale is auto.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minimumscaleisauto?view=word-pia"/>
  public bool MinimumScaleIsAuto { get; set; }

  /// <summary>
  /// The minor gridlines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minorgridlines?view=word-pia"/>
  public Gridlines MinorGridlines { get; }

  /// <summary>
  /// The minor tick mark.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minortickmark?view=word-pia"/>
  public XlTickMark MinorTickMark { get; set; }

  /// <summary>
  /// The minor unit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minorunit?view=word-pia"/>
  public double MinorUnit { get; set; }

  /// <summary>
  /// The minor unit is auto.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minorunitisauto?view=word-pia"/>
  public bool MinorUnitIsAuto { get; set; }

  /// <summary>
  /// The reverse plot order.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.reverseplotorder?view=word-pia"/>
  public bool ReversePlotOrder { get; set; }

  /// <summary>
  /// The scale type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.scaletype?view=word-pia"/>
  public XlScaleType ScaleType { get; set; }

  /// <summary>
  /// The tick label position.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.ticklabelposition?view=word-pia"/>
  public XlTickLabelPosition TickLabelPosition { get; set; }

  /// <summary>
  /// The tick labels.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.ticklabels?view=word-pia"/>
  public TickLabels TickLabels { get; }

  /// <summary>
  /// The tick label spacing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.ticklabelspacing?view=word-pia"/>
  public int TickLabelSpacing { get; set; }

  /// <summary>
  /// The tick mark spacing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.tickmarkspacing?view=word-pia"/>
  public int TickMarkSpacing { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.type?view=word-pia"/>
  public XlAxisType Type { get; set; }

  /// <summary>
  /// The base unit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.baseunit?view=word-pia"/>
  public XlTimeUnit BaseUnit { get; set; }

  /// <summary>
  /// The base unit is auto.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.baseunitisauto?view=word-pia"/>
  public bool BaseUnitIsAuto { get; set; }

  /// <summary>
  /// The major unit scale.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.majorunitscale?view=word-pia"/>
  public XlTimeUnit MajorUnitScale { get; set; }

  /// <summary>
  /// The minor unit scale.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.minorunitscale?view=word-pia"/>
  public XlTimeUnit MinorUnitScale { get; set; }

  /// <summary>
  /// The category type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.categorytype?view=word-pia"/>
  public XlCategoryType CategoryType { get; set; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.left?view=word-pia"/>
  public double Left { get; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.top?view=word-pia"/>
  public double Top { get; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.width?view=word-pia"/>
  public double Width { get; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.height?view=word-pia"/>
  public double Height { get; }

  /// <summary>
  /// The display unit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.displayunit?view=word-pia"/>
  public XlDisplayUnit DisplayUnit { get; set; }

  /// <summary>
  /// The display unit custom.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.displayunitcustom?view=word-pia"/>
  public double DisplayUnitCustom { get; set; }

  /// <summary>
  /// The has display unit label.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.hasdisplayunitlabel?view=word-pia"/>
  public bool HasDisplayUnitLabel { get; set; }

  /// <summary>
  /// The display unit label.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.displayunitlabel?view=word-pia"/>
  public DisplayUnitLabel DisplayUnitLabel { get; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.axis.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
