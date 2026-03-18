namespace DocumentModel.Interop;

/// <summary>
/// Represents a single axis in a chart.
/// </summary>
public partial interface Axis : InteropObject
{
  /// <summary>
  /// The axis between categories.
  /// </summary>
  public bool AxisBetweenCategories { get; set; }

  /// <summary>
  /// The axis group.
  /// </summary>
  public XlAxisGroup AxisGroup { get; }

  /// <summary>
  /// The axis title.
  /// </summary>
  public AxisTitle AxisTitle { get; }

  /// <summary>
  /// The category names.
  /// </summary>
  public object CategoryNames { get; set; }

  /// <summary>
  /// The crosses.
  /// </summary>
  public XlAxisCrosses Crosses { get; set; }

  /// <summary>
  /// The crosses at.
  /// </summary>
  public double CrossesAt { get; set; }

  /// <summary>
  /// The has major gridlines.
  /// </summary>
  public bool HasMajorGridlines { get; set; }

  /// <summary>
  /// The has minor gridlines.
  /// </summary>
  public bool HasMinorGridlines { get; set; }

  /// <summary>
  /// The has title.
  /// </summary>
  public bool HasTitle { get; set; }

  /// <summary>
  /// The major gridlines.
  /// </summary>
  public Gridlines MajorGridlines { get; }

  /// <summary>
  /// The major tick mark.
  /// </summary>
  public XlTickMark MajorTickMark { get; set; }

  /// <summary>
  /// The major unit.
  /// </summary>
  public double MajorUnit { get; set; }

  /// <summary>
  /// The log base.
  /// </summary>
  public double LogBase { get; set; }

  /// <summary>
  /// The tick label spacing is auto.
  /// </summary>
  public bool TickLabelSpacingIsAuto { get; set; }

  /// <summary>
  /// The major unit is auto.
  /// </summary>
  public bool MajorUnitIsAuto { get; set; }

  /// <summary>
  /// The maximum scale.
  /// </summary>
  public double MaximumScale { get; set; }

  /// <summary>
  /// The maximum scale is auto.
  /// </summary>
  public bool MaximumScaleIsAuto { get; set; }

  /// <summary>
  /// The minimum scale.
  /// </summary>
  public double MinimumScale { get; set; }

  /// <summary>
  /// The minimum scale is auto.
  /// </summary>
  public bool MinimumScaleIsAuto { get; set; }

  /// <summary>
  /// The minor gridlines.
  /// </summary>
  public Gridlines MinorGridlines { get; }

  /// <summary>
  /// The minor tick mark.
  /// </summary>
  public XlTickMark MinorTickMark { get; set; }

  /// <summary>
  /// The minor unit.
  /// </summary>
  public double MinorUnit { get; set; }

  /// <summary>
  /// The minor unit is auto.
  /// </summary>
  public bool MinorUnitIsAuto { get; set; }

  /// <summary>
  /// The reverse plot order.
  /// </summary>
  public bool ReversePlotOrder { get; set; }

  /// <summary>
  /// The scale type.
  /// </summary>
  public XlScaleType ScaleType { get; set; }

  /// <summary>
  /// The tick label position.
  /// </summary>
  public XlTickLabelPosition TickLabelPosition { get; set; }

  /// <summary>
  /// The tick labels.
  /// </summary>
  public TickLabels TickLabels { get; }

  /// <summary>
  /// The tick label spacing.
  /// </summary>
  public int TickLabelSpacing { get; set; }

  /// <summary>
  /// The tick mark spacing.
  /// </summary>
  public int TickMarkSpacing { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public XlAxisType Type { get; set; }

  /// <summary>
  /// The base unit.
  /// </summary>
  public XlTimeUnit BaseUnit { get; set; }

  /// <summary>
  /// The base unit is auto.
  /// </summary>
  public bool BaseUnitIsAuto { get; set; }

  /// <summary>
  /// The major unit scale.
  /// </summary>
  public XlTimeUnit MajorUnitScale { get; set; }

  /// <summary>
  /// The minor unit scale.
  /// </summary>
  public XlTimeUnit MinorUnitScale { get; set; }

  /// <summary>
  /// The category type.
  /// </summary>
  public XlCategoryType CategoryType { get; set; }

  /// <summary>
  /// The left.
  /// </summary>
  public double Left { get; }

  /// <summary>
  /// The top.
  /// </summary>
  public double Top { get; }

  /// <summary>
  /// The width.
  /// </summary>
  public double Width { get; }

  /// <summary>
  /// The height.
  /// </summary>
  public double Height { get; }

  /// <summary>
  /// The display unit.
  /// </summary>
  public XlDisplayUnit DisplayUnit { get; set; }

  /// <summary>
  /// The display unit custom.
  /// </summary>
  public double DisplayUnitCustom { get; set; }

  /// <summary>
  /// The has display unit label.
  /// </summary>
  public bool HasDisplayUnitLabel { get; set; }

  /// <summary>
  /// The display unit label.
  /// </summary>
  public DisplayUnitLabel DisplayUnitLabel { get; }

  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
