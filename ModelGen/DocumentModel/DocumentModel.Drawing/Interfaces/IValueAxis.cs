namespace DocumentModel.Drawing;

/// <summary>
/// Value Axis.
/// </summary>
public interface IValueAxis // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  public System.UInt32? AxisId { get ; set; }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public DocumentModel.Drawing.IScaling? Scaling { get ; set; }
  
  /// <summary>
  /// Delete.
  /// </summary>
  public System.Boolean? Delete { get ; set; }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public DocumentModel.Drawing.AxisPositionKind? AxisPosition { get ; set; }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  public DocumentModel.Drawing.IMajorGridlines? MajorGridlines { get ; set; }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public DocumentModel.Drawing.IMinorGridlines? MinorGridlines { get ; set; }
  
  /// <summary>
  /// Title.
  /// </summary>
  public DocumentModel.Drawing.ITitle? Title { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public DocumentModel.Drawing.INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  public DocumentModel.Drawing.TickMarkKind? MajorTickMark { get ; set; }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  public DocumentModel.Drawing.TickMarkKind? MinorTickMark { get ; set; }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  public DocumentModel.Drawing.TickLabelPositionKind? TickLabelPosition { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawing.ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  public System.UInt32? CrossingAxis { get ; set; }
  
  public DocumentModel.Drawing.CrossesKind? Crosses { get ; set; }
  
  public System.Double? CrossesAt { get ; set; }
  
  public DocumentModel.Drawing.CrossBetweenKind? CrossBetween { get ; set; }
  
  public System.Double? MajorUnit { get ; set; }
  
  public System.Double? MinorUnit { get ; set; }
  
  public DocumentModel.Drawing.IDisplayUnits? DisplayUnits { get ; set; }
  
  public DocumentModel.Drawing.IValAxExtensionList? ValAxExtensionList { get ; set; }
  
}
