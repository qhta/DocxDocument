namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public interface IScatterChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredScatterSeries? FilteredScatterSeries { get ; set; }
  
}
