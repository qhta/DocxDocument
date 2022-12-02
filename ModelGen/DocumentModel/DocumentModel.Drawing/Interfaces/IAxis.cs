namespace DocumentModel.Drawing;

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
  
  public DocumentModel.Drawing.ICategoryAxisScaling? CategoryAxisScaling { get ; set; }
  
  public DocumentModel.Drawing.IValueAxisScaling? ValueAxisScaling { get ; set; }
  
  public DocumentModel.Drawing.IAxisTitle? AxisTitle { get ; set; }
  
  public DocumentModel.Drawing.IAxisUnits? AxisUnits { get ; set; }
  
  public DocumentModel.Drawing.IMajorGridlinesGridlines? MajorGridlinesGridlines { get ; set; }
  
  public DocumentModel.Drawing.IMinorGridlinesGridlines? MinorGridlinesGridlines { get ; set; }
  
  public DocumentModel.Drawing.IMajorTickMarksTickMarks? MajorTickMarksTickMarks { get ; set; }
  
  public DocumentModel.Drawing.IMinorTickMarksTickMarks? MinorTickMarksTickMarks { get ; set; }
  
  public DocumentModel.Drawing.ITickLabels? TickLabels { get ; set; }
  
  public DocumentModel.Drawing.INumberFormat? NumberFormat { get ; set; }
  
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.ITxPrTextBody? TxPrTextBody { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
