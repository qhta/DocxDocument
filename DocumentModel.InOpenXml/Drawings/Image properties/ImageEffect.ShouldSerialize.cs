namespace DocumentModel.Drawings;

public partial class ImageEffect
{
  public bool ShouldSerializeVisible() => Visible is not null;
  public bool ShouldSerializeArtisticBlur() => ArtisticBlur is not null;
  public bool ShouldSerializeArtisticCement() => ArtisticCement is not null;
  public bool ShouldSerializeArtisticChalkSketch() => ArtisticChalkSketch is not null;
  public bool ShouldSerializeArtisticCrisscrossEtching() => ArtisticCrisscrossEtching is not null;
  public bool ShouldSerializeArtisticCutout() => ArtisticCutout is not null;
  public bool ShouldSerializeArtisticFilmGrain() => ArtisticFilmGrain is not null;
  public bool ShouldSerializeArtisticGlass() => ArtisticGlass is not null;
  public bool ShouldSerializeArtisticGlowDiffused() => ArtisticGlowDiffused is not null;
  public bool ShouldSerializeArtisticGlowEdges() => ArtisticGlowEdges is not null;
  public bool ShouldSerializeArtisticLightScreen() => ArtisticLightScreen is not null;
  public bool ShouldSerializeArtisticLineDrawing() => ArtisticLineDrawing is not null;
  public bool ShouldSerializeArtisticMarker() => ArtisticMarker is not null;
  public bool ShouldSerializeArtisticMosaicBubbles() => ArtisticMosaicBubbles is not null;
  public bool ShouldSerializeArtisticPaintStrokes() => ArtisticPaintStrokes is not null;
  public bool ShouldSerializeArtisticPaintBrush() => ArtisticPaintBrush is not null;
  public bool ShouldSerializeArtisticPastelsSmooth() => ArtisticPastelsSmooth is not null;
  public bool ShouldSerializeArtisticPencilGrayscale() => ArtisticPencilGrayscale is not null;
  public bool ShouldSerializeArtisticPencilSketch() => ArtisticPencilSketch is not null;
  public bool ShouldSerializeArtisticPhotocopy() => ArtisticPhotocopy is not null;
  public bool ShouldSerializeArtisticPlasticWrap() => ArtisticPlasticWrap is not null;
  public bool ShouldSerializeArtisticTexturizer() => ArtisticTexturizer is not null;
  public bool ShouldSerializeArtisticWatercolorSponge() => ArtisticWatercolorSponge is not null;
  public bool ShouldSerializeBackgroundRemoval() => BackgroundRemoval is not null;
  public bool ShouldSerializeBrightnessContrast() => BrightnessContrast is not null;
  public bool ShouldSerializeColorTemperature() => ColorTemperature is not null;
  public bool ShouldSerializeSaturation() => Saturation is not null;
  public bool ShouldSerializeSharpenSoften() => SharpenSoften is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
