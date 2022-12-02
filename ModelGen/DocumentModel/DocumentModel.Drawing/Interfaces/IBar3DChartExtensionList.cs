namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Bar3DChartExtensionList Class.
/// </summary>
public interface IBar3DChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IBar3DChartExtension>? Bar3DChartExtensions { get ; set; }
  
}
