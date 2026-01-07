namespace DocumentModel.Drawings;

/// <summary>
/// Represents an image effect, including visibility, a variety of artistic effects, image adjustments, and extension options.
/// </summary>
public interface ImageEffect: ExtendableElement
{
  /// <summary>
  /// Gets or sets a value indicating whether the effect is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Artistic blur effect.
  /// </summary>
  public ArtisticBlur? ArtisticBlur { get; set; }

  /// <summary>
  /// Artistic cement effect.
  /// </summary>
  public ArtisticCement? ArtisticCement { get; set; }

  /// <summary>
  /// Artistic chalk sketch effect.
  /// </summary>
  public ArtisticChalkSketch? ArtisticChalkSketch { get; set; }

  /// <summary>
  /// Artistic crisscross etching effect.
  /// </summary>
  public ArtisticCrisscrossEtching? ArtisticCrisscrossEtching { get; set; }

  /// <summary>
  /// Artistic cutout effect.
  /// </summary>
  public ArtisticCutout? ArtisticCutout { get; set; }

  /// <summary>
  /// Artistic film grain effect.
  /// </summary>
  public ArtisticFilmGrain? ArtisticFilmGrain { get; set; }

  /// <summary>
  /// Artistic glass effect.
  /// </summary>
  public ArtisticGlass? ArtisticGlass { get; set; }

  /// <summary>
  /// Artistic diffused glow effect.
  /// </summary>
  public ArtisticGlowDiffused? ArtisticGlowDiffused { get; set; }

  /// <summary>
  /// Artistic glow edges effect.
  /// </summary>
  public ArtisticGlowEdges? ArtisticGlowEdges { get; set; }

  /// <summary>
  /// Artistic light screen effect.
  /// </summary>
  public ArtisticLightScreen? ArtisticLightScreen { get; set; }

  /// <summary>
  /// Artistic line drawing effect.
  /// </summary>
  public ArtisticLineDrawing? ArtisticLineDrawing { get; set; }

  /// <summary>
  /// Artistic marker effect.
  /// </summary>
  public ArtisticMarker? ArtisticMarker { get; set; }

  /// <summary>
  /// Artistic mosaic bubbles effect.
  /// </summary>
  public ArtisticMosaicBubbles? ArtisticMosaicBubbles { get; set; }

  /// <summary>
  /// Artistic paint strokes effect.
  /// </summary>
  public ArtisticPaintStrokes? ArtisticPaintStrokes { get; set; }

  /// <summary>
  /// Artistic paint brush effect.
  /// </summary>
  public ArtisticPaintBrush? ArtisticPaintBrush { get; set; }

  /// <summary>
  /// Artistic pastels smooth effect.
  /// </summary>
  public ArtisticPastelsSmooth? ArtisticPastelsSmooth { get; set; }

  /// <summary>
  /// Artistic pencil grayscale effect.
  /// </summary>
  public ArtisticPencilGrayscale? ArtisticPencilGrayscale { get; set; }

  /// <summary>
  /// Artistic pencil sketch effect.
  /// </summary>
  public ArtisticPencilSketch? ArtisticPencilSketch { get; set; }

  /// <summary>
  /// Artistic photocopy effect.
  /// </summary>
  public ArtisticPhotocopy? ArtisticPhotocopy { get; set; }

  /// <summary>
  /// Artistic plastic wrap effect.
  /// </summary>
  public ArtisticPlasticWrap? ArtisticPlasticWrap { get; set; }

  /// <summary>
  /// Artistic texturizer effect.
  /// </summary>
  public ArtisticTexturizer? ArtisticTexturizer { get; set; }

  /// <summary>
  /// Artistic watercolor sponge effect.
  /// </summary>
  public ArtisticWatercolorSponge? ArtisticWatercolorSponge { get; set; }

  /// <summary>
  /// Background removal effect.
  /// </summary>
  public BackgroundRemoval? BackgroundRemoval { get; set; }

  /// <summary>
  /// Brightness and contrast adjustment.
  /// </summary>
  public BrightnessContrast? BrightnessContrast { get; set; }

  /// <summary>
  /// Color temperature adjustment.
  /// </summary>
  public ColorTemperature? ColorTemperature { get; set; }

  /// <summary>
  /// Saturation adjustment.
  /// </summary>
  public Saturation? Saturation { get; set; }

  /// <summary>
  /// Sharpen or soften adjustment.
  /// </summary>
  public SharpenSoften? SharpenSoften { get; set; }
}