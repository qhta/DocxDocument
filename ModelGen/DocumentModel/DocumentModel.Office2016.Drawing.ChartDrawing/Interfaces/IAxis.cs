namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Axis Class.
/// </summary>
public interface IAxis // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.ICategoryAxisScaling? CategoryAxisScaling { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IValueAxisScaling? ValueAxisScaling { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IAxisTitle? AxisTitle { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IAxisUnits? AxisUnits { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IMajorGridlinesGridlines? MajorGridlinesGridlines { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IMinorGridlinesGridlines? MinorGridlinesGridlines { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IMajorTickMarksTickMarks? MajorTickMarksTickMarks { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IMinorTickMarksTickMarks? MinorTickMarksTickMarks { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.ITickLabels? TickLabels { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.INumberFormat? NumberFormat { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.ITxPrTextBody? TxPrTextBody { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
