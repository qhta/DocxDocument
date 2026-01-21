namespace DocumentModel.Wordprocessing;

public partial class RelationshipType<T> 
{
  public bool ShouldSerializeId() => Id is not null;
}
