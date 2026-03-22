namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class BuildDiagram
{
  public bool ShouldSerializeBuild() => !String.IsNullOrEmpty(Build);
  public bool ShouldSerializeReverseAnimation() => ReverseAnimation is not null;
}
