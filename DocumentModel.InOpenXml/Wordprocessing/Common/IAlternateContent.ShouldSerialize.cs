namespace DocumentModel;

public partial class IAlternateContent
{
  public bool ShouldSerializeChoices() => Choices is not null;
  public bool ShouldSerializeFallback() => Fallback is not null;
}
