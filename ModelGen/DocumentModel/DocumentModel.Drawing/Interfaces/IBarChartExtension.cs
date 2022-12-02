namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public interface IBarChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredBarSeries? FilteredBarSeries { get ; set; }
  
}
