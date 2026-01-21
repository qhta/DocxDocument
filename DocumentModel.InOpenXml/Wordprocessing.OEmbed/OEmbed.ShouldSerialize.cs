namespace DocumentModel.Wordprocessing.OEmbed;

public partial class OEmbed
{
  public bool ShouldSerializeOEmbedUrl() => OEmbedUrl is not null;
  public bool ShouldSerializeMediaType() => MediaType is not null;
  public bool ShouldSerializePicLocksAutoForOEmbed() => PicLocksAutoForOEmbed is not null;
}
