namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Line3DChartExtensionList Class.
/// </summary>
public interface ILine3DChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ILine3DChartExtension>? Line3DChartExtensions { get ; set; }
  
}
