namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ScatterChartExtensionList Class.
/// </summary>
public interface IScatterChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IScatterChartExtension>? ScatterChartExtensions { get ; set; }
  
}
