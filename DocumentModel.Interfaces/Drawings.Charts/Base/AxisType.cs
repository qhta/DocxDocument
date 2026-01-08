namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Abstract representation of an axis type. All specific axis types implement this interface.
/// </summary>
public interface AxisType: CollectionItem
{
  /// <summary>
  ///   Identifier for the axis.
  /// </summary>
  public UInt32? AxisId { get; set; }

  /// <summary>
  ///   Scaling configuration for the axis.
  /// </summary>
  public Scaling? Scaling { get; set; }

  /// <summary>
  ///   Indicates whether the axis is deleted.
  /// </summary>
  public bool? Delete { get; set; }

  /// <summary>
  ///   Position of the axis on the chart.
  /// </summary>
  public AxisPositionKind? AxisPosition { get; set; }

  /// <summary>
  ///   Major gridlines configuration for the axis.
  /// </summary>
  public MajorGridlines? MajorGridlines { get; set; }

  /// <summary>
  ///   Minor gridlines configuration for the axis.
  /// </summary>
  public MinorGridlines? MinorGridlines { get; set; }

  /// <summary>
  ///   Title of the axis.
  /// </summary>
  public Title? Title { get; set; }

  /// <summary>
  ///   Number format for the axis labels.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   Major tick mark type for the axis.
  /// </summary>
  public TickMarkKind? MajorTickMark { get; set; }

  /// <summary>
  ///   Minor tick mark type for the axis.
  /// </summary>
  public TickMarkKind? MinorTickMark { get; set; }

  /// <summary>
  ///   Position of the tick labels on the axis.
  /// </summary>
  public TickLabelPositionKind? TickLabelPosition { get; set; }

  /// <summary>
  ///   Shape properties for the axis.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Text properties for the axis.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   Identifier of the crossing axis.
  /// </summary>
  public UInt32? CrossingAxis { get; set; }

  /// <summary>
  ///   Specifies how the axis crosses.
  /// </summary>
  public CrossesKind? Crosses { get; set; }

  /// <summary>
  ///   Value at which the axis crosses.
  /// </summary>
  public Double? CrossesAt { get; set; }


}