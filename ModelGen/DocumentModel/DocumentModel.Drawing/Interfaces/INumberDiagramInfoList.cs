namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumberDiagramInfoList Class.
/// </summary>
public interface INumberDiagramInfoList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.INumberDiagramInfo>? NumberDiagramInfos { get ; set; }
  
}
