namespace DocumentModel.Wordprocessing;

public partial class MoveBookmarkType
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeColumnFirst() => ColumnFirst is not null;
  public bool ShouldSerializeColumnLast() => ColumnLast is not null;
  public bool ShouldSerializeDisplacedByCustomXml() => DisplacedByCustomXml is not null;
  public bool ShouldSerializePairedElement() => PairedElement is not null;
}
