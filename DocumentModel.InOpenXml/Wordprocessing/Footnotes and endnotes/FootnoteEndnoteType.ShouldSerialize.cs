namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FootnoteEndnoteType
{
  public bool ShouldSerializeType() => Type is not null && ShouldSerialize(Type);
  public bool ShouldSerializeId() => Id is not null && ShouldSerialize(Id);
}
