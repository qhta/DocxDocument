namespace DocumentModel.Drawings;

/// <summary>
/// Value Axis.
/// </summary>
public interface ValueAxis1
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  public UInt32? AxisId { get ; set; }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public Scaling? Scaling { get ; set; }
  
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
  public MajorGridlines? MajorGridlines { get ; set; }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public MinorGridlines? MinorGridlines { get ; set; }
  
  /// <summary>
  /// Title.
  /// </summary>
  public Title1? Title { get ; set; }
  
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
  public TextProperties2? TextProperties { get ; set; }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  public UInt32? CrossingAxis { get ; set; }
  
  public CrossesKind? Crosses { get ; set; }
  
  public Double? CrossesAt { get ; set; }
  
  public CrossBetweenKind? CrossBetween { get ; set; }
  
  public Double? MajorUnit { get ; set; }
  
  public Double? MinorUnit { get ; set; }
  
  public DisplayUnits? DisplayUnits { get ; set; }
  
  public ValAxExtensionList? ValAxExtensionList { get ; set; }
  
}
