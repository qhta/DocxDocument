namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Axis Class.
/// </summary>
public interface Axis
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
  public DocumentModel.Drawings16.Charts.CategoryAxisScaling? CategoryAxisScaling { get ; set; }
  
  public DocumentModel.Drawings16.Charts.ValueAxisScaling? ValueAxisScaling { get ; set; }
  
  public DocumentModel.Drawings16.Charts.AxisTitle? AxisTitle { get ; set; }
  
  public DocumentModel.Drawings16.Charts.AxisUnits? AxisUnits { get ; set; }
  
  public DocumentModel.Drawings16.Charts.MajorGridlinesGridlines? MajorGridlinesGridlines { get ; set; }
  
  public DocumentModel.Drawings16.Charts.MinorGridlinesGridlines? MinorGridlinesGridlines { get ; set; }
  
  public DocumentModel.Drawings16.Charts.MajorTickMarksTickMarks? MajorTickMarksTickMarks { get ; set; }
  
  public DocumentModel.Drawings16.Charts.MinorTickMarksTickMarks? MinorTickMarksTickMarks { get ; set; }
  
  public DocumentModel.Drawings16.Charts.TickLabels? TickLabels { get ; set; }
  
  public DocumentModel.Drawings16.Charts.NumberFormat? NumberFormat { get ; set; }
  
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawings16.Charts.TxPrTextBody? TxPrTextBody { get ; set; }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
