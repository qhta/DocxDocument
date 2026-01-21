namespace DocumentModel.Wordprocessing;

public partial class LanguageType
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeEastAsia() => EastAsia is not null;
  public bool ShouldSerializeBidi() => Bidi is not null;
}
