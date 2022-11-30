namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Date Axis.
/// </summary>
public interface IDateAxis // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  public System.UInt32? AxisId { get ; set; }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public DocumentModel.Drawing.Charts.IScaling? Scaling { get ; set; }
  
  /// <summary>
  /// Delete.
  /// </summary>
  public System.Boolean? Delete { get ; set; }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public DocumentModel.Drawing.Charts.AxisPositionKind? AxisPosition { get ; set; }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  public DocumentModel.Drawing.Charts.IMajorGridlines? MajorGridlines { get ; set; }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public DocumentModel.Drawing.Charts.IMinorGridlines? MinorGridlines { get ; set; }
  
  /// <summary>
  /// Title.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITitle? Title { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  public DocumentModel.Drawing.Charts.TickMarkKind? MajorTickMark { get ; set; }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  public DocumentModel.Drawing.Charts.TickMarkKind? MinorTickMark { get ; set; }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  public DocumentModel.Drawing.Charts.TickLabelPositionKind? TickLabelPosition { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  public System.UInt32? CrossingAxis { get ; set; }
  
  public DocumentModel.Drawing.Charts.CrossesKind? Crosses { get ; set; }
  
  public System.Double? CrossesAt { get ; set; }
  
  public System.Boolean? AutoLabeled { get ; set; }
  
  public System.UInt16? LabelOffset { get ; set; }
  
  public DocumentModel.Drawing.Charts.TimeUnitKind? BaseTimeUnit { get ; set; }
  
  public System.Double? MajorUnit { get ; set; }
  
  public DocumentModel.Drawing.Charts.TimeUnitKind? MajorTimeUnit { get ; set; }
  
  public System.Double? MinorUnit { get ; set; }
  
  public DocumentModel.Drawing.Charts.TimeUnitKind? MinorTimeUnit { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDateAxExtensionList? DateAxExtensionList { get ; set; }
  
}
