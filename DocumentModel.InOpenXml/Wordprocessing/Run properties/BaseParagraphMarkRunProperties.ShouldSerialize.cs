namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class BaseParagraphMarkRunProperties<T> 
{
  public bool ShouldSerializeInserted() => Inserted is not null;
  public bool ShouldSerializeDeleted() => Deleted is not null;
  public bool ShouldSerializeMoveFrom() => MoveFrom is not null;
  public bool ShouldSerializeMoveTo() => MoveTo is not null;
  public bool ShouldSerializeConflictInsertion() => ConflictInsertion is not null;
  public bool ShouldSerializeConflictDeletion() => ConflictDeletion is not null;
  public bool ShouldSerializeOfficeMath() => OfficeMath is not null;
}
