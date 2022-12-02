namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public interface IPie3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
