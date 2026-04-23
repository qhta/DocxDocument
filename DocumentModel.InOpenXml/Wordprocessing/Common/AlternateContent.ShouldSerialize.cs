namespace DocumentModel;

#pragma warning disable CS1591

public partial class AlternateContent
{
  public bool ShouldSerializeChoices() => Choices is not null && ShouldSerialize(Choices);
  public bool ShouldSerializeFallback() => Fallback is not null && ShouldSerialize(Fallback);
}
