namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Area3DChartExtension Class.
/// </summary>
public interface IArea3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredAreaSeries? FilteredAreaSeries { get ; set; }
  
}
