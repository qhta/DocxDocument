namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public interface IPie3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
