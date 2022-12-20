namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Date Axis.
/// </summary>
public partial interface DateAxis
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  public UInt32? AxisId { get; set; }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public DocumentModel.Drawings.Charts.Scaling? Scaling { get; set; }
  
  /// <summary>
  /// Delete.
  /// </summary>
  public Boolean? Delete { get; set; }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public DocumentModel.Drawings.Charts.AxisPositionKind? AxisPosition { get; set; }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  public DocumentModel.Drawings.Charts.MajorGridlines? MajorGridlines { get; set; }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public DocumentModel.Drawings.Charts.MinorGridlines? MinorGridlines { get; set; }
  
  /// <summary>
  /// Title.
  /// </summary>
  public DocumentModel.Drawings.Charts.Title? Title { get; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberingFormat? NumberingFormat { get; set; }
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  public DocumentModel.Drawings.Charts.TickMarkKind? MajorTickMark { get; set; }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  public DocumentModel.Drawings.Charts.TickMarkKind? MinorTickMark { get; set; }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  public DocumentModel.Drawings.Charts.TickLabelPositionKind? TickLabelPosition { get; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  public UInt32? CrossingAxis { get; set; }
  
  public DocumentModel.Drawings.Charts.CrossesKind? Crosses { get; set; }
  
  public Double? CrossesAt { get; set; }
  
  public Boolean? AutoLabeled { get; set; }
  
  public UInt16? LabelOffset { get; set; }
  
  public DocumentModel.Drawings.Charts.TimeUnitKind? BaseTimeUnit { get; set; }
  
  public Double? MajorUnit { get; set; }
  
  public DocumentModel.Drawings.Charts.TimeUnitKind? MajorTimeUnit { get; set; }
  
  public Double? MinorUnit { get; set; }
  
  public DocumentModel.Drawings.Charts.TimeUnitKind? MinorTimeUnit { get; set; }
  
  public DocumentModel.Drawings.Charts.DateAxExtensionList? DateAxExtensionList { get; set; }
  
}
