namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class Algorithm
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeRevision() => Revision is not null;
  public bool ShouldSerializeParameters() => Parameters is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
