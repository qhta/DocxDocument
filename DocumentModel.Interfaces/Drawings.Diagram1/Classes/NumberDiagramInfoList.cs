namespace DocumentModel.Drawings.Diagram1;

/// <summary>
///   Defines the NumberDiagramInfoList Class.
/// </summary>
public interface NumberDiagramInfoList: IModelElement
{
  public Collection<NumberDiagramInfo>? NumberDiagramInfos { get; set; }
}