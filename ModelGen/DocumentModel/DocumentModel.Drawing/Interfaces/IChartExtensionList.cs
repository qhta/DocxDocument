namespace DocumentModel.Drawing;

/// <summary>
/// Extensibility container.
/// </summary>
public interface IChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IDataDisplayOptions16>? DataDisplayOptions16s { get ; set; }
  
}
