namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Value Axis.
/// </summary>
public partial interface ValueAxis
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
  
  public DocumentModel.Drawings.Charts.CrossBetweenKind? CrossBetween { get; set; }
  
  public Double? MajorUnit { get; set; }
  
  public Double? MinorUnit { get; set; }
  
  public DocumentModel.Drawings.Charts.DisplayUnits? DisplayUnits { get; set; }
  
  public DocumentModel.Drawings.Charts.ValAxExtensionList? ValAxExtensionList { get; set; }
  
}
