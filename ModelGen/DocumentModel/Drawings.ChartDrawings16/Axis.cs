namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Axis Class.
/// </summary>
public partial class Axis
{
  
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get; set; }
  
  
  /// <summary>
  ///   hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Hidden { get; set; }
  
  public DMDCD16.CategoryAxisScaling? CategoryAxisScaling { get; set; }
  
  public DMDCD16.ValueAxisScaling? ValueAxisScaling { get; set; }
  
  public DMDCD16.AxisTitle? AxisTitle { get; set; }
  
  public DMDCD16.AxisUnits? AxisUnits { get; set; }
  
  public DMDCD16.MajorGridlinesGridlines? MajorGridlinesGridlines { get; set; }
  
  public DMDCD16.MinorGridlinesGridlines? MinorGridlinesGridlines { get; set; }
  
  public DMDCD16.MajorTickMarksTickMarks? MajorTickMarksTickMarks { get; set; }
  
  public DMDCD16.MinorTickMarksTickMarks? MinorTickMarksTickMarks { get; set; }
  
  public DMDCD16.TickLabels? TickLabels { get; set; }
  
  public DMDCD16.NumberFormat? NumberFormat { get; set; }
  
  public DMDCD16.ShapeProperties? ShapeProperties { get; set; }
  
  public DMDCD16.TxPrTextBody? TxPrTextBody { get; set; }
  
  public DMDCD16.ExtensionList? ExtensionList { get; set; }
  
}
