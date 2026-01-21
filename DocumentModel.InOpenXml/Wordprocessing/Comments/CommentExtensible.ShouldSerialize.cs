namespace DocumentModel.Wordprocessing;

public partial class CommentExtensible
{
  public bool ShouldSerializeDurableId() => DurableId is not null;
  public bool ShouldSerializeDateUtc() => DateUtc is not null;
  public bool ShouldSerializeIntelligentPlaceholder() => IntelligentPlaceholder is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
