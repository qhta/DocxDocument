namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public interface ILine3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
