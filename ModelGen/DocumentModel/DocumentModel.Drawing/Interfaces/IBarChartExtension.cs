namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public interface IBarChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredBarSeries? FilteredBarSeries { get ; set; }
  
}
