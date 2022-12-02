namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumberDiagramInfoList Class.
/// </summary>
public interface INumberDiagramInfoList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<INumberDiagramInfo>? NumberDiagramInfos { get ; set; }
  
}
