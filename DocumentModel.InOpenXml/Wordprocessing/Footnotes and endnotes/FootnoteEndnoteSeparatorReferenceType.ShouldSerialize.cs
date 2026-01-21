namespace DocumentModel.Wordprocessing;

public partial class FootnoteEndnoteSeparatorReferenceType
{
  public bool ShouldSerializeId() => Id is not null;
}
