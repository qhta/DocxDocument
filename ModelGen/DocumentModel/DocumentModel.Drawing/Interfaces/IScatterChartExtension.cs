namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public interface IScatterChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredScatterSeries? FilteredScatterSeries { get ; set; }
  
}
