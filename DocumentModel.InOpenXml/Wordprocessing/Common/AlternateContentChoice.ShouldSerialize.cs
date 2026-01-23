namespace DocumentModel;

public partial class AlternateContentChoice
{
  public bool ShouldSerializeRequires() => Requires is not null;
}
