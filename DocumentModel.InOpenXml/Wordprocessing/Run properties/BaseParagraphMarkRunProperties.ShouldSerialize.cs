namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BaseParagraphMarkRunProperties<T> 
{
  public bool ShouldSerializeInserted() => Inserted is not null && ShouldSerialize(Inserted);
  public bool ShouldSerializeDeleted() => Deleted is not null && ShouldSerialize(Deleted);
  public bool ShouldSerializeMoveFrom() => MoveFrom is not null && ShouldSerialize(MoveFrom);
  public bool ShouldSerializeMoveTo() => MoveTo is not null && ShouldSerialize(MoveTo);
  public bool ShouldSerializeConflictInsertion() => ConflictInsertion is not null && ShouldSerialize(ConflictInsertion);
  public bool ShouldSerializeConflictDeletion() => ConflictDeletion is not null && ShouldSerialize(ConflictDeletion);
  public bool ShouldSerializeOfficeMath() => OfficeMath is not null;
}
