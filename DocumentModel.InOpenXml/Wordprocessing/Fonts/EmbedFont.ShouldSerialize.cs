namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class EmbedFont
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeFontKey() => FontKey is not null && ShouldSerialize(FontKey);
  public bool ShouldSerializeSubsetted() => Subsetted is not null;
}
