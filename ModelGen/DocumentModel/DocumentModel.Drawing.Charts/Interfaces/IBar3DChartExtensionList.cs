namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Bar3DChartExtensionList Class.
/// </summary>
public interface IBar3DChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IBar3DChartExtension>? Bar3DChartExtensions { get ; set; }
  
}
