namespace DocumentModel.Drawings;

public partial class CreationId
{
  public bool ShouldSerializeId() => Id is not null;
}
