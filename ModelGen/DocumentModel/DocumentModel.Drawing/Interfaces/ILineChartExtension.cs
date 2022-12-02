namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public interface ILineChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
