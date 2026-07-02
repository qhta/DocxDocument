namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FootnoteEndnoteSeparatorReferenceType<T>
{
  public bool ShouldSerializeId() => Id is not null && ShouldSerialize(Id);
}
