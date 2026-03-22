namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class NoLineBreaksAfterKinsoku
{
  public bool ShouldSerializeLanguage() => Language is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
