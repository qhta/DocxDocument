namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Line3DChartExtensionList Class.
/// </summary>
public interface ILine3DChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ILine3DChartExtension>? Line3DChartExtensions { get ; set; }
  
}
