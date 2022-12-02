namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public interface ILineChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
