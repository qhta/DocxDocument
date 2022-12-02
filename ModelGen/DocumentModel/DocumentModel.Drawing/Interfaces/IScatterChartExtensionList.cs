namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ScatterChartExtensionList Class.
/// </summary>
public interface IScatterChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IScatterChartExtension>? ScatterChartExtensions { get ; set; }
  
}
