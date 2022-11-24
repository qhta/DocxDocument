namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Category Axis Data.
/// </summary>
public interface ICategoryAxis // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  public IAxisId? AxisId { get ; set; }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public IScaling? Scaling { get ; set; }
  
  /// <summary>
  /// Delete.
  /// </summary>
  public IDelete? Delete { get ; set; }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public IAxisPosition? AxisPosition { get ; set; }
  
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
  public IMajorTickMark? MajorTickMark { get ; set; }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  public IMinorTickMark? MinorTickMark { get ; set; }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  public ITickLabelPosition? TickLabelPosition { get ; set; }
  
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
  public ICrossingAxis? CrossingAxis { get ; set; }
  
}
