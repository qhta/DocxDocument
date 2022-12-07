namespace DocumentModel.Drawings;

/// <summary>
/// Date Axis.
/// </summary>
public interface DateAxis
{
  /// <summary>
  /// Scaling.
  /// </summary>
  public Scaling? Scaling { get ; set; }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public AxisPositionKind? AxisPosition { get ; set; }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  public MajorGridlines? MajorGridlines { get ; set; }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public MinorGridlines? MinorGridlines { get ; set; }
  
  /// <summary>
  /// Title.
  /// </summary>
  public Title2? Title { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public NumberingFormat1? NumberingFormat { get ; set; }
  
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
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public TextProperties1? TextProperties { get ; set; }
  
  public CrossesKind? Crosses { get ; set; }
  
  public TimeUnitKind? BaseTimeUnit { get ; set; }
  
  public TimeUnitKind? MajorTimeUnit { get ; set; }
  
  public TimeUnitKind? MinorTimeUnit { get ; set; }
  
  public DateAxExtensionList? DateAxExtensionList { get ; set; }
  
}
