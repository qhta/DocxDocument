namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public interface IAreaChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredAreaSeries? FilteredAreaSeries { get ; set; }
  
}
