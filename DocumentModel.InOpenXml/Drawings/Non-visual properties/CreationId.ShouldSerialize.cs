namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class CreationId
{
  public bool ShouldSerializeId() => Id is not null;
}
