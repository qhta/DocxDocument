namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ScatterChartExtensionList Class.
/// </summary>
public interface IScatterChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IScatterChartExtension>? ScatterChartExtensions { get ; set; }
  
}
