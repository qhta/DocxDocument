namespace DocumentModel.Drawings.Charts;
/// <summary>
/// Abstract representation of an axis type. All specific axis types implement this class.
/// </summary>
[DataContract]
[XmlRoot("AbstractAxis", Namespace = "DocumentModel.Drawings.Charts")]
public partial class AbstractAxis<T> : ModelElement<T>, AbstractAxis where T : DX.OpenXmlCompositeElement
{
 /// <summary>
 ///   Identifier for the axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.AxisId))]
 public UInt32? AxisId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Scaling configuration for the axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.Scaling))]
 public Scaling? Scaling { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Indicates whether the axis is deleted.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.Delete))]
 public bool? Delete { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Position of the axis on the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.AxisPosition))]
 public AxisPosition? AxisPosition { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Major gridlines configuration for the axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.MajorGridlines))]
 public MajorGridlines? MajorGridlines { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Minor gridlines configuration for the axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.MinorGridlines))]
 public MinorGridlines? MinorGridlines { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Title of the axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.Title))]
 public Title? Title { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Number format for the axis labels.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.NumberingFormat))]
 public NumberingFormat? NumberingFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Major tick mark type for the axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.MajorTickMark))]
 public TickMark? MajorTickMark { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Minor tick mark type for the axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.MinorTickMark))]
 public TickMark? MinorTickMark { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Position of the tick labels on the axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.TickLabelPosition))]
 public TickLabelPosition? TickLabelPosition { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Shape properties for the axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.ChartShapeProperties))]
 public ChartShapeProperties? ChartShapeProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Text properties for the axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.TextProperties))]
 public TextProperties? TextProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

 /// <summary>
 ///   Identifier of the crossing axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ValueAxis.CrossingAxis))]
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