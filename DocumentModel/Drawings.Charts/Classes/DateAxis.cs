namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Date Axis.
/// </summary>
public record DateAxis
{
  /// <summary>
  ///   Axis ID.
  /// </summary>
  public UInt32? AxisId { get; set; }

  /// <summary>
  ///   Scaling.
  /// </summary>
  public Scaling? Scaling { get; set; }

  /// <summary>
  ///   Delete.
  /// </summary>
  public Boolean? Delete { get; set; }

  /// <summary>
  ///   Axis Position.
  /// </summary>
  public AxisPositionKind? AxisPosition { get; set; }

  /// <summary>
  ///   Major Gridlines.
  /// </summary>
  public MajorGridlines? MajorGridlines { get; set; }

  /// <summary>
  ///   Minor Gridlines.
  /// </summary>
  public MinorGridlines? MinorGridlines { get; set; }

  /// <summary>
  ///   Title.
  /// </summary>
  public Title? Title { get; set; }

  /// <summary>
  ///   Number Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   Major Tick Mark.
  /// </summary>
  public TickMarkKind? MajorTickMark { get; set; }

  /// <summary>
  ///   Minor Tick Mark.
  /// </summary>
  public TickMarkKind? MinorTickMark { get; set; }

  /// <summary>
  ///   Tick Label Position.
  /// </summary>
  public TickLabelPositionKind? TickLabelPosition { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   TextProperties.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   Crossing Axis ID.
  /// </summary>
  public UInt32? CrossingAxis { get; set; }

  public CrossesKind? Crosses { get; set; }

  public Double? CrossesAt { get; set; }

  public Boolean? AutoLabeled { get; set; }

  public UInt16? LabelOffset { get; set; }

  public TimeUnitKind? BaseTimeUnit { get; set; }

  public Double? MajorUnit { get; set; }

  public TimeUnitKind? MajorTimeUnit { get; set; }

  public Double? MinorUnit { get; set; }

  public TimeUnitKind? MinorTimeUnit { get; set; }

  public DateAxExtensionList? DateAxExtensionList { get; set; }
}