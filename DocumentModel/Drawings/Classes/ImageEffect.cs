namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ImageEffect Class.
/// </summary>
public class ImageEffect: ModelElement
{
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible { get; set; }

  /// <summary>
  ///   ArtisticBlur.
  /// </summary>
  public ArtisticBlur? ArtisticBlur { get; set; }

  /// <summary>
  ///   ArtisticCement.
  /// </summary>
  public ArtisticCement? ArtisticCement { get; set; }

  /// <summary>
  ///   ArtisticChalkSketch.
  /// </summary>
  public ArtisticChalkSketch? ArtisticChalkSketch { get; set; }

  /// <summary>
  ///   ArtisticCrisscrossEtching.
  /// </summary>
  public ArtisticCrisscrossEtching? ArtisticCrisscrossEtching { get; set; }

  /// <summary>
  ///   ArtisticCutout.
  /// </summary>
  public ArtisticCutout? ArtisticCutout { get; set; }

  /// <summary>
  ///   ArtisticFilmGrain.
  /// </summary>
  public ArtisticFilmGrain? ArtisticFilmGrain { get; set; }

  /// <summary>
  ///   ArtisticGlass.
  /// </summary>
  public ArtisticGlass? ArtisticGlass { get; set; }

  /// <summary>
  ///   ArtisticGlowDiffused.
  /// </summary>
  public ArtisticGlowDiffused? ArtisticGlowDiffused { get; set; }

  /// <summary>
  ///   ArtisticGlowEdges.
  /// </summary>
  public ArtisticGlowEdges? ArtisticGlowEdges { get; set; }

  /// <summary>
  ///   ArtisticLightScreen.
  /// </summary>
  public ArtisticLightScreen? ArtisticLightScreen { get; set; }

  /// <summary>
  ///   ArtisticLineDrawing.
  /// </summary>
  public ArtisticLineDrawing? ArtisticLineDrawing { get; set; }

  /// <summary>
  ///   ArtisticMarker.
  /// </summary>
  public ArtisticMarker? ArtisticMarker { get; set; }

  /// <summary>
  ///   ArtisticMosaicBubbles.
  /// </summary>
  public ArtisticMosaicBubbles? ArtisticMosaicBubbles { get; set; }

  /// <summary>
  ///   ArtisticPaintStrokes.
  /// </summary>
  public ArtisticPaintStrokes? ArtisticPaintStrokes { get; set; }

  /// <summary>
  ///   ArtisticPaintBrush.
  /// </summary>
  public ArtisticPaintBrush? ArtisticPaintBrush { get; set; }

  /// <summary>
  ///   ArtisticPastelsSmooth.
  /// </summary>
  public ArtisticPastelsSmooth? ArtisticPastelsSmooth { get; set; }

  /// <summary>
  ///   ArtisticPencilGrayscale.
  /// </summary>
  public ArtisticPencilGrayscale? ArtisticPencilGrayscale { get; set; }

  /// <summary>
  ///   ArtisticPencilSketch.
  /// </summary>
  public ArtisticPencilSketch? ArtisticPencilSketch { get; set; }

  /// <summary>
  ///   ArtisticPhotocopy.
  /// </summary>
  public ArtisticPhotocopy? ArtisticPhotocopy { get; set; }

  /// <summary>
  ///   ArtisticPlasticWrap.
  /// </summary>
  public ArtisticPlasticWrap? ArtisticPlasticWrap { get; set; }

  /// <summary>
  ///   ArtisticTexturizer.
  /// </summary>
  public ArtisticTexturizer? ArtisticTexturizer { get; set; }

  /// <summary>
  ///   ArtisticWatercolorSponge.
  /// </summary>
  public ArtisticWatercolorSponge? ArtisticWatercolorSponge { get; set; }

  /// <summary>
  ///   BackgroundRemoval.
  /// </summary>
  public BackgroundRemoval? BackgroundRemoval { get; set; }

  /// <summary>
  ///   BrightnessContrast.
  /// </summary>
  public BrightnessContrast? BrightnessContrast { get; set; }

  /// <summary>
  ///   ColorTemperature.
  /// </summary>
  public ColorTemperature? ColorTemperature { get; set; }

  /// <summary>
  ///   Saturation.
  /// </summary>
  public Saturation2? Saturation { get; set; }

  /// <summary>
  ///   SharpenSoften.
  /// </summary>
  public SharpenSoften? SharpenSoften { get; set; }
}