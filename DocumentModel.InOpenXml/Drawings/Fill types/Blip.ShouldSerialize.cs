namespace DocumentModel.Drawings;

public partial class Blip
{
  public bool ShouldSerializeEmbed() => Embed is not null;
  public bool ShouldSerializeLink() => Link is not null;
  public bool ShouldSerializeCompressionState() => CompressionState is not null;
  public bool ShouldSerializeAlphaBiLevel() => AlphaBiLevel is not null;
  public bool ShouldSerializeAlphaCeiling() => AlphaCeiling is not null;
  public bool ShouldSerializeAlphaFloor() => AlphaFloor is not null;
  public bool ShouldSerializeAlphaInverse() => AlphaInverse is not null;
  public bool ShouldSerializeAlphaModulationEffect() => AlphaModulationEffect is not null;
  public bool ShouldSerializeAlphaModulationFixed() => AlphaModulationFixed is not null;
  public bool ShouldSerializeAlphaReplace() => AlphaReplace is not null;
  public bool ShouldSerializeBiLevel() => BiLevel is not null;
  public bool ShouldSerializeBlur() => Blur is not null;
  public bool ShouldSerializeColorChange() => ColorChange is not null;
  public bool ShouldSerializeColorReplacement() => ColorReplacement is not null;
  public bool ShouldSerializeDuotone() => Duotone is not null;
  public bool ShouldSerializeFillOverlay() => FillOverlay is not null;
  public bool ShouldSerializeHsl() => Hsl is not null;
  public bool ShouldSerializeLuminanceEffect() => LuminanceEffect is not null;
  public bool ShouldSerializeTintEffect() => TintEffect is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
