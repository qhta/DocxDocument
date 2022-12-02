namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public interface IPieChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
