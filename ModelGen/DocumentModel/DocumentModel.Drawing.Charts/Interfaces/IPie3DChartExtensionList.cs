namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Pie3DChartExtensionList Class.
/// </summary>
public interface IPie3DChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IPie3DChartExtension>? Pie3DChartExtensions { get ; set; }
  
}
