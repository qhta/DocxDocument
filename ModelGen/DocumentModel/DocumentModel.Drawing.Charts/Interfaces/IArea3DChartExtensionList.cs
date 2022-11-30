namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Area3DChartExtensionList Class.
/// </summary>
public interface IArea3DChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IArea3DChartExtension>? Area3DChartExtensions { get ; set; }
  
}
