namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class BlipExtension
{
  public bool ShouldSerializeImageProperties() => ImageProperties is not null;
  public bool ShouldSerializeUseLocalDpi() => UseLocalDpi is not null;
  public bool ShouldSerializeWebVideoProperty() => WebVideoProperty is not null;
  public bool ShouldSerializeSVGBlip() => SVGBlip is not null;
  public bool ShouldSerializePictureAttributionSourceURL() => PictureAttributionSourceURL is not null;
  public bool ShouldSerializeOEmbed() => OEmbed is not null;
  public bool ShouldSerializeOEmbedShared() => OEmbedShared is not null;
  public bool ShouldSerializeUri() => Uri is not null;
}
