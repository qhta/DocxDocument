namespace DocumentModel;

#pragma warning disable CS1591

public partial class AlternateContentChoice
{
  public bool ShouldSerializeRequires() => Requires is not null;
}
