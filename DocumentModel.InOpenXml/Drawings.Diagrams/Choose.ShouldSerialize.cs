namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class Choose
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeDiagramChooseIf() => DiagramChooseIf is not null;
  public bool ShouldSerializeDiagramChooseElse() => DiagramChooseElse is not null;
}
