namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   ICategory IAxis Data.
/// </summary>
public class CategoryAxis: ModelElement
{
  /// <summary>
  ///   IAxis ID.
  /// </summary>
  public UInt32? AxisId { get; set; }

  /// <summary>
  ///   Scaling.
  /// </summary>
  public Scaling? Scaling { get; set; }

  /// <summary>
  ///   Delete.
  /// </summary>
  public bool? Delete { get; set; }

  /// <summary>
  ///   IAxis Position.
  /// </summary>
  public AxisPositionKind? AxisPosition { get; set; }

  /// <summary>
  ///   Major IGridlines.
  /// </summary>
  public MajorGridlines? MajorGridlines { get; set; }

  /// <summary>
  ///   Minor IGridlines.
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
  ///   Crossing IAxis ID.
  /// </summary>
  public UInt32? CrossingAxis { get; set; }

  public CrossesKind? Crosses { get; set; }

  public Double? CrossesAt { get; set; }

  public bool? AutoLabeled { get; set; }

  public LabelAlignmentKind? LabelAlignment { get; set; }

  public UInt16? LabelOffset { get; set; }

  public Int32? TickLabelSkip { get; set; }

  public Int32? TickMarkSkip { get; set; }

  public bool? NoMultiLevelLabels { get; set; }

  public CatAxExtensionList? CatAxExtensionList { get; set; }
}
