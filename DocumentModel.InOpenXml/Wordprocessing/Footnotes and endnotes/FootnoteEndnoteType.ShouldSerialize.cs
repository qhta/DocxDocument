namespace DocumentModel.Wordprocessing;

public partial class FootnoteEndnoteType
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeId() => Id is not null;
}
