namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BookmarkStart
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeColumnFirst() => ColumnFirst is not null && ShouldSerialize(ColumnFirst);
  public bool ShouldSerializeColumnLast() => ColumnLast is not null && ShouldSerialize(ColumnLast);
}
