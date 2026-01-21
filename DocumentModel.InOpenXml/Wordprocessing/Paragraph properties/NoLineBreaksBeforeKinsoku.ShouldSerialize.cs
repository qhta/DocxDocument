namespace DocumentModel.Wordprocessing;

public partial class NoLineBreaksBeforeKinsoku
{
  public bool ShouldSerializeLanguage() => Language is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
