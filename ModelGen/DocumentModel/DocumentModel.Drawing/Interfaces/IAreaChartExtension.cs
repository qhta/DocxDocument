namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public interface IAreaChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredAreaSeries? FilteredAreaSeries { get ; set; }
  
}
