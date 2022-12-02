namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AreaChartExtensionList Class.
/// </summary>
public interface IAreaChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IAreaChartExtension>? AreaChartExtensions { get ; set; }
  
}
