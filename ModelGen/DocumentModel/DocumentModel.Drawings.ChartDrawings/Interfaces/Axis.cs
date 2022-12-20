namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Axis Class.
/// </summary>
public partial interface Axis
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Hidden { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.CategoryAxisScaling? CategoryAxisScaling { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ValueAxisScaling? ValueAxisScaling { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.AxisTitle? AxisTitle { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.AxisUnits? AxisUnits { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.MajorGridlinesGridlines? MajorGridlinesGridlines { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.MinorGridlinesGridlines? MinorGridlinesGridlines { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.MajorTickMarksTickMarks? MajorTickMarksTickMarks { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.MinorTickMarksTickMarks? MinorTickMarksTickMarks { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.TickLabels? TickLabels { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.NumberFormat? NumberFormat { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.TxPrTextBody? TxPrTextBody { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
}
