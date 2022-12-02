namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public interface IPieChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
