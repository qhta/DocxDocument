namespace DocumentModel.Drawings.Charts;
/// <summary>
/// Abstract representation of an axis type. All specific axis types implement this class.
/// </summary>
public interface AbstractAxis
{
  /// <summary>
  ///   Identifier for the axis.
  /// </summary>
  public UInt32? AxisId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Scaling configuration for the axis.
  /// </summary>
  public Scaling? Scaling { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Indicates whether the axis is deleted.
  /// </summary>
  public bool? Delete { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Position of the axis on the chart.
  /// </summary>
  public AxisPosition? AxisPosition { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Major gridlines configuration for the axis.
  /// </summary>
  public MajorGridlines? MajorGridlines { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Minor gridlines configuration for the axis.
  /// </summary>
  public MinorGridlines? MinorGridlines { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Title of the axis.
  /// </summary>
  public Title? Title { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Number format for the axis labels.
  /// </summary>
  public NumberingFormat? NumberingFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Major tick mark type for the axis.
  /// </summary>
  public TickMark? MajorTickMark { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Minor tick mark type for the axis.
  /// </summary>
  public TickMark? MinorTickMark { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Position of the tick labels on the axis.
  /// </summary>
  public TickLabelPosition? TickLabelPosition { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Shape properties for the axis.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Text properties for the axis.
  /// </summary>
  public TextProperties? TextProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Identifier of the crossing axis.
  /// </summary>
  public UInt32? CrossingAxis { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Specifies how the axis crosses.
  /// </summary>
  public Crosses? Crosses { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Value at which the axis crosses.
  /// </summary>
  public Double? CrossesAt { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}