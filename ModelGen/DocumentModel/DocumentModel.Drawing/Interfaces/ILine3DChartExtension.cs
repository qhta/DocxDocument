namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public interface ILine3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
