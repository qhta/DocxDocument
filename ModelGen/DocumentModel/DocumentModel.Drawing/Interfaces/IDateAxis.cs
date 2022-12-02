namespace DocumentModel.Drawing;

/// <summary>
/// Date Axis.
/// </summary>
public interface IDateAxis // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  public UInt32? AxisId { get ; set; }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public IScaling? Scaling { get ; set; }
  
  /// <summary>
  /// Delete.
  /// </summary>
  public Boolean? Delete { get ; set; }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public AxisPositionKind? AxisPosition { get ; set; }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  public IMajorGridlines? MajorGridlines { get ; set; }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public IMinorGridlines? MinorGridlines { get ; set; }
  
  /// <summary>
  /// Title.
  /// </summary>
  public ITitle? Title { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  public TickMarkKind? MajorTickMark { get ; set; }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  public TickMarkKind? MinorTickMark { get ; set; }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  public TickLabelPositionKind? TickLabelPosition { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  public UInt32? CrossingAxis { get ; set; }
  
  public CrossesKind? Crosses { get ; set; }
  
  public Double? CrossesAt { get ; set; }
  
  public Boolean? AutoLabeled { get ; set; }
  
  public UInt16? LabelOffset { get ; set; }
  
  public TimeUnitKind? BaseTimeUnit { get ; set; }
  
  public Double? MajorUnit { get ; set; }
  
  public TimeUnitKind? MajorTimeUnit { get ; set; }
  
  public Double? MinorUnit { get ; set; }
  
  public TimeUnitKind? MinorTimeUnit { get ; set; }
  
  public IDateAxExtensionList? DateAxExtensionList { get ; set; }
  
}
