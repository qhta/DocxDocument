namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableRowProperties
{
  public bool ShouldSerializeInserted() => Inserted is not null && ShouldSerialize(Inserted);
  public bool ShouldSerializeDeleted() => Deleted is not null && ShouldSerialize(Deleted);
  public bool ShouldSerializeTableRowPropertiesChange() => TableRowPropertiesChange is not null && ShouldSerialize(TableRowPropertiesChange);
  public bool ShouldSerializeConflictInsertion() => ConflictInsertion is not null && ShouldSerialize(ConflictInsertion);
  public bool ShouldSerializeConflictDeletion() => ConflictDeletion is not null && ShouldSerialize(ConflictDeletion);
}
