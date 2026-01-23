namespace DocumentModel.Wordprocessing;

public partial class BookmarkStart
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeColumnFirst() => ColumnFirst is not null;
  public bool ShouldSerializeColumnLast() => ColumnLast is not null;
}
