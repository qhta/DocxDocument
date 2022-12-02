namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AreaChartExtensionList Class.
/// </summary>
public interface IAreaChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IAreaChartExtension>? AreaChartExtensions { get ; set; }
  
}
