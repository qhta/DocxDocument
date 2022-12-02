namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public interface IBar3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredBarSeries? FilteredBarSeries { get ; set; }
  
}
