namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NoLineBreaksBeforeKinsoku
{
  public bool ShouldSerializeLanguage() => !String.IsNullOrEmpty(Language);
  public bool ShouldSerializeVal() => !String.IsNullOrEmpty(Val);
}
