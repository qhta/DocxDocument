namespace DocumentModel.Wordprocessing;

public partial class Person
{
  public bool ShouldSerializeContact() => Contact is not null;
  public bool ShouldSerializeAuthor() => Author is not null;
  public bool ShouldSerializePresenceInfo() => PresenceInfo is not null;
}
