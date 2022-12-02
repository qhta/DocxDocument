namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Area3DChartExtensionList Class.
/// </summary>
public interface IArea3DChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IArea3DChartExtension>? Area3DChartExtensions { get ; set; }
  
}
