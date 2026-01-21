namespace DocumentModel.Wordprocessing;

public partial class TableRowProperties
{
  public bool ShouldSerializeInserted() => Inserted is not null;
  public bool ShouldSerializeDeleted() => Deleted is not null;
  public bool ShouldSerializeTableRowPropertiesChange() => TableRowPropertiesChange is not null;
  public bool ShouldSerializeConflictInsertion() => ConflictInsertion is not null;
  public bool ShouldSerializeConflictDeletion() => ConflictDeletion is not null;
}
