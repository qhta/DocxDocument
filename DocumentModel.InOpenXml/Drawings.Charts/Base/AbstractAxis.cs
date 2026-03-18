namespace DocumentModel.Drawings.Charts;
/// <summary>
/// Abstract representation of an axis type. All specific axis types implement this class.
/// </summary>
public partial class AbstractAxis<T> : ModelElement<T>, IAxis where T : DX.OpenXmlCompositeElement
{
  /// <summary>
  ///   Identifier for the axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.AxisId))]
  public UInt32? AxisId { get; set; }

  /// <summary>
  ///   Scaling configuration for the axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.Scaling))]
  public Scaling? Scaling { get; set; }

  /// <summary>
  ///   Indicates whether the axis is deleted.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.Delete))]
  public bool? Delete { get; set; }

  /// <summary>
  ///   Position of the axis on the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.AxisPosition))]
  public AxisPosition? AxisPosition { get; set; }

  /// <summary>
  ///   Major gridlines configuration for the axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.MajorGridlines))]
  public MajorGridlines? MajorGridlines { get; set; }

  /// <summary>
  ///   Minor gridlines configuration for the axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.MinorGridlines))]
  public MinorGridlines? MinorGridlines { get; set; }

  /// <summary>
  ///   Title of the axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.Title))]
  public Title? Title { get; set; }

  /// <summary>
  ///   Number format for the axis labels.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.NumberingFormat))]
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   Major tick mark type for the axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.MajorTickMark))]
  public TickMark? MajorTickMark { get; set; }

  /// <summary>
  ///   Minor tick mark type for the axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.MinorTickMark))]
  public TickMark? MinorTickMark { get; set; }

  /// <summary>
  ///   Position of the tick labels on the axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.TickLabelPosition))]
  public TickLabelPosition? TickLabelPosition { get; set; }

  /// <summary>
  ///   Shape properties for the axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Text properties for the axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.TextProperties))]
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   Identifier of the crossing axis.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ValueAxis.CrossingAxis))]
  public UInt32? CrossingAxis { get; set; }
  /// <summary>
  ///   Specifies how the axis crosses.
  /// </summary>
  public Crosses? Crosses { get; set; }
  /// <summary>
  ///   Value at which the axis crosses.
  /// </summary>
  public Double? CrossesAt { get; set; }
}