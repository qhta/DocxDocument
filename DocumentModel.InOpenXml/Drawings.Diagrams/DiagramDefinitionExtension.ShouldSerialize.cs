namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class DiagramDefinitionExtension
{
  public bool ShouldSerializeNumberDiagramInfoList() => NumberDiagramInfoList is not null && NumberDiagramInfoList.Count > 0;
  public bool ShouldSerializeTextListStyleType() => TextListStyleType is not null;
}
