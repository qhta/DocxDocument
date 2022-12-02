namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Axis Class.
/// </summary>
public interface IAxis // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
  public ICategoryAxisScaling? CategoryAxisScaling { get ; set; }
  
  public IValueAxisScaling? ValueAxisScaling { get ; set; }
  
  public IAxisTitle? AxisTitle { get ; set; }
  
  public IAxisUnits? AxisUnits { get ; set; }
  
  public IMajorGridlinesGridlines? MajorGridlinesGridlines { get ; set; }
  
  public IMinorGridlinesGridlines? MinorGridlinesGridlines { get ; set; }
  
  public IMajorTickMarksTickMarks? MajorTickMarksTickMarks { get ; set; }
  
  public IMinorTickMarksTickMarks? MinorTickMarksTickMarks { get ; set; }
  
  public ITickLabels? TickLabels { get ; set; }
  
  public INumberFormat? NumberFormat { get ; set; }
  
  public IShapeProperties? ShapeProperties { get ; set; }
  
  public ITxPrTextBody? TxPrTextBody { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
