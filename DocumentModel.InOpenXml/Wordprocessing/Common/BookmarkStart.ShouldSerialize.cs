namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BookmarkStart
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeColumnFirst() => ColumnFirst is not null;
  public bool ShouldSerializeColumnLast() => ColumnLast is not null;
}
