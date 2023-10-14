namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Series Axis.
/// </summary>
public partial class SeriesAxis
{
  
  /// <summary>
  ///   Axis ID.
  /// </summary>
  public DocumentModel.Drawings.Charts.AxisId? AxisId { get; set; }
  
  
  /// <summary>
  ///   Scaling.
  /// </summary>
  public DocumentModel.Drawings.Charts.Scaling? Scaling { get; set; }
  
  
  /// <summary>
  ///   Delete.
  /// </summary>
  public DocumentModel.Drawings.Charts.Delete? Delete { get; set; }
  
  
  /// <summary>
  ///   Axis Position.
  /// </summary>
  public DocumentModel.Drawings.Charts.AxisPositionKind? AxisPosition { get; set; }
  
  
  /// <summary>
  ///   Major Gridlines.
  /// </summary>
  public DocumentModel.Drawings.Charts.MajorGridlines? MajorGridlines { get; set; }
  
  
  /// <summary>
  ///   Minor Gridlines.
  /// </summary>
  public DocumentModel.Drawings.Charts.MinorGridlines? MinorGridlines { get; set; }
  
  
  /// <summary>
  ///   Title.
  /// </summary>
  public DocumentModel.Drawings.Charts.Title? Title { get; set; }
  
  
  /// <summary>
  ///   Number Format.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberingFormat? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   Major Tick Mark.
  /// </summary>
  public DocumentModel.Drawings.Charts.MajorTickMark? MajorTickMark { get; set; }
  
  
  /// <summary>
  ///   Minor Tick Mark.
  /// </summary>
  public DocumentModel.Drawings.Charts.MinorTickMark? MinorTickMark { get; set; }
  
  
  /// <summary>
  ///   Tick Label Position.
  /// </summary>
  public DocumentModel.Drawings.Charts.TickLabelPositionKind? TickLabelPosition { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   TextProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  
  /// <summary>
  ///   Crossing Axis ID.
  /// </summary>
  public DocumentModel.Drawings.Charts.CrossingAxis? CrossingAxis { get; set; }
  
  public DocumentModel.Drawings.Charts.CrossesKind? Crosses { get; set; }
  
  public DocumentModel.Drawings.Charts.CrossesAt? CrossesAt { get; set; }
  
  public DocumentModel.Drawings.Charts.TickLabelSkip? TickLabelSkip { get; set; }
  
  public DocumentModel.Drawings.Charts.TickMarkSkip? TickMarkSkip { get; set; }
  
  public DocumentModel.Drawings.Charts.SerAxExtensionList? SerAxExtensionList { get; set; }
  
}
