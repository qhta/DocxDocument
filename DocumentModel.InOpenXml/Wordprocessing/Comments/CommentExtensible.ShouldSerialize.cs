namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CommentExtensible
{
  public bool ShouldSerializeDurableId() => DurableId is not null && ShouldSerialize(DurableId);
  public bool ShouldSerializeDateUtc() => DateUtc is not null && ShouldSerialize(DateUtc);
  public bool ShouldSerializeIntelligentPlaceholder() => IntelligentPlaceholder is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ShouldSerialize(ExtensionList);
}
