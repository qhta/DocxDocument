namespace DocumentModel;

public partial class AlternateContent
{
  public bool ShouldSerializeChoices() => Choices is not null;
  public bool ShouldSerializeFallback() => Fallback is not null;
}
