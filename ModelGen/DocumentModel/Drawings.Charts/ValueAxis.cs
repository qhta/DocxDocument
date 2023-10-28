namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Value Axis.
/// </summary>
public partial class ValueAxis
{
  
  /// <summary>
  ///   Axis ID.
  /// </summary>
  public DMDC.AxisId? AxisId { get; set; }
  
  
  /// <summary>
  ///   Scaling.
  /// </summary>
  public DMDC.Scaling? Scaling { get; set; }
  
  
  /// <summary>
  ///   Delete.
  /// </summary>
  public DMDC.Delete? Delete { get; set; }
  
  
  /// <summary>
  ///   Axis Position.
  /// </summary>
  public DMDC.AxisPositionKind? AxisPosition { get; set; }
  
  
  /// <summary>
  ///   Major Gridlines.
  /// </summary>
  public DMDC.MajorGridlines? MajorGridlines { get; set; }
  
  
  /// <summary>
  ///   Minor Gridlines.
  /// </summary>
  public DMDC.MinorGridlines? MinorGridlines { get; set; }
  
  
  /// <summary>
  ///   Title.
  /// </summary>
  public DMDC.Title? Title { get; set; }
  
  
  /// <summary>
  ///   Number Format.
  /// </summary>
  public DMDC.NumberingFormat? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   Major Tick Mark.
  /// </summary>
  public DMDC.MajorTickMark? MajorTickMark { get; set; }
  
  
  /// <summary>
  ///   Minor Tick Mark.
  /// </summary>
  public DMDC.MinorTickMark? MinorTickMark { get; set; }
  
  
  /// <summary>
  ///   Tick Label Position.
  /// </summary>
  public DMDC.TickLabelPositionKind? TickLabelPosition { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DMDC.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   TextProperties.
  /// </summary>
  public DMDC.TextProperties? TextProperties { get; set; }
  
  
  /// <summary>
  ///   Crossing Axis ID.
  /// </summary>
  public DMDC.CrossingAxis? CrossingAxis { get; set; }
  
  public DMDC.CrossesKind? Crosses { get; set; }
  
  public DMDC.CrossesAt? CrossesAt { get; set; }
  
  public DMDC.CrossBetweenKind? CrossBetween { get; set; }
  
  public DMDC.MajorUnit? MajorUnit { get; set; }
  
  public DMDC.MinorUnit? MinorUnit { get; set; }
  
  public DMDC.DisplayUnits? DisplayUnits { get; set; }
  
  public DMDC.ValAxExtensionList? ValAxExtensionList { get; set; }
  
}
