namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ImageEffect Class.
/// </summary>
public interface IImageEffect // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Visible { get ; set; }
  
  /// <summary>
  /// ArtisticBlur.
  /// </summary>
  public DocumentModel.Drawing.IArtisticBlur? ArtisticBlur { get ; set; }
  
  /// <summary>
  /// ArtisticCement.
  /// </summary>
  public DocumentModel.Drawing.IArtisticCement? ArtisticCement { get ; set; }
  
  /// <summary>
  /// ArtisticChalkSketch.
  /// </summary>
  public DocumentModel.Drawing.IArtisticChalkSketch? ArtisticChalkSketch { get ; set; }
  
  /// <summary>
  /// ArtisticCrisscrossEtching.
  /// </summary>
  public DocumentModel.Drawing.IArtisticCrisscrossEtching? ArtisticCrisscrossEtching { get ; set; }
  
  /// <summary>
  /// ArtisticCutout.
  /// </summary>
  public DocumentModel.Drawing.IArtisticCutout? ArtisticCutout { get ; set; }
  
  /// <summary>
  /// ArtisticFilmGrain.
  /// </summary>
  public DocumentModel.Drawing.IArtisticFilmGrain? ArtisticFilmGrain { get ; set; }
  
  /// <summary>
  /// ArtisticGlass.
  /// </summary>
  public DocumentModel.Drawing.IArtisticGlass? ArtisticGlass { get ; set; }
  
  /// <summary>
  /// ArtisticGlowDiffused.
  /// </summary>
  public DocumentModel.Drawing.IArtisticGlowDiffused? ArtisticGlowDiffused { get ; set; }
  
  /// <summary>
  /// ArtisticGlowEdges.
  /// </summary>
  public DocumentModel.Drawing.IArtisticGlowEdges? ArtisticGlowEdges { get ; set; }
  
  /// <summary>
  /// ArtisticLightScreen.
  /// </summary>
  public DocumentModel.Drawing.IArtisticLightScreen? ArtisticLightScreen { get ; set; }
  
  /// <summary>
  /// ArtisticLineDrawing.
  /// </summary>
  public DocumentModel.Drawing.IArtisticLineDrawing? ArtisticLineDrawing { get ; set; }
  
  /// <summary>
  /// ArtisticMarker.
  /// </summary>
  public DocumentModel.Drawing.IArtisticMarker? ArtisticMarker { get ; set; }
  
  /// <summary>
  /// ArtisticMosaicBubbles.
  /// </summary>
  public DocumentModel.Drawing.IArtisticMosaicBubbles? ArtisticMosaicBubbles { get ; set; }
  
  /// <summary>
  /// ArtisticPaintStrokes.
  /// </summary>
  public DocumentModel.Drawing.IArtisticPaintStrokes? ArtisticPaintStrokes { get ; set; }
  
  /// <summary>
  /// ArtisticPaintBrush.
  /// </summary>
  public DocumentModel.Drawing.IArtisticPaintBrush? ArtisticPaintBrush { get ; set; }
  
  /// <summary>
  /// ArtisticPastelsSmooth.
  /// </summary>
  public DocumentModel.Drawing.IArtisticPastelsSmooth? ArtisticPastelsSmooth { get ; set; }
  
  /// <summary>
  /// ArtisticPencilGrayscale.
  /// </summary>
  public DocumentModel.Drawing.IArtisticPencilGrayscale? ArtisticPencilGrayscale { get ; set; }
  
  /// <summary>
  /// ArtisticPencilSketch.
  /// </summary>
  public DocumentModel.Drawing.IArtisticPencilSketch? ArtisticPencilSketch { get ; set; }
  
  /// <summary>
  /// ArtisticPhotocopy.
  /// </summary>
  public DocumentModel.Drawing.IArtisticPhotocopy? ArtisticPhotocopy { get ; set; }
  
  /// <summary>
  /// ArtisticPlasticWrap.
  /// </summary>
  public DocumentModel.Drawing.IArtisticPlasticWrap? ArtisticPlasticWrap { get ; set; }
  
  /// <summary>
  /// ArtisticTexturizer.
  /// </summary>
  public DocumentModel.Drawing.IArtisticTexturizer? ArtisticTexturizer { get ; set; }
  
  /// <summary>
  /// ArtisticWatercolorSponge.
  /// </summary>
  public DocumentModel.Drawing.IArtisticWatercolorSponge? ArtisticWatercolorSponge { get ; set; }
  
  /// <summary>
  /// BackgroundRemoval.
  /// </summary>
  public DocumentModel.Drawing.IBackgroundRemoval? BackgroundRemoval { get ; set; }
  
  /// <summary>
  /// BrightnessContrast.
  /// </summary>
  public DocumentModel.Drawing.IBrightnessContrast? BrightnessContrast { get ; set; }
  
  /// <summary>
  /// ColorTemperature.
  /// </summary>
  public DocumentModel.Drawing.IColorTemperature? ColorTemperature { get ; set; }
  
  /// <summary>
  /// Saturation.
  /// </summary>
  public DocumentModel.Drawing.ISaturation? Saturation { get ; set; }
  
  /// <summary>
  /// SharpenSoften.
  /// </summary>
  public DocumentModel.Drawing.ISharpenSoften? SharpenSoften { get ; set; }
  
}
