namespace DocumentModel.Wordprocessing;

public partial class NoLineBreaksAfterKinsoku
{
  public bool ShouldSerializeLanguage() => Language is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
