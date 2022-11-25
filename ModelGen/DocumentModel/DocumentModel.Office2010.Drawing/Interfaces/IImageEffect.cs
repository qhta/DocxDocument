namespace DocumentModel.Office2010.Drawing;

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
  public DocumentModel.Office2010.Drawing.IArtisticBlur? ArtisticBlur { get ; set; }
  
  /// <summary>
  /// ArtisticCement.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticCement? ArtisticCement { get ; set; }
  
  /// <summary>
  /// ArtisticChalkSketch.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticChalkSketch? ArtisticChalkSketch { get ; set; }
  
  /// <summary>
  /// ArtisticCrisscrossEtching.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticCrisscrossEtching? ArtisticCrisscrossEtching { get ; set; }
  
  /// <summary>
  /// ArtisticCutout.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticCutout? ArtisticCutout { get ; set; }
  
  /// <summary>
  /// ArtisticFilmGrain.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticFilmGrain? ArtisticFilmGrain { get ; set; }
  
  /// <summary>
  /// ArtisticGlass.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticGlass? ArtisticGlass { get ; set; }
  
  /// <summary>
  /// ArtisticGlowDiffused.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticGlowDiffused? ArtisticGlowDiffused { get ; set; }
  
  /// <summary>
  /// ArtisticGlowEdges.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticGlowEdges? ArtisticGlowEdges { get ; set; }
  
  /// <summary>
  /// ArtisticLightScreen.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticLightScreen? ArtisticLightScreen { get ; set; }
  
  /// <summary>
  /// ArtisticLineDrawing.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticLineDrawing? ArtisticLineDrawing { get ; set; }
  
  /// <summary>
  /// ArtisticMarker.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticMarker? ArtisticMarker { get ; set; }
  
  /// <summary>
  /// ArtisticMosaicBubbles.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticMosaicBubbles? ArtisticMosaicBubbles { get ; set; }
  
  /// <summary>
  /// ArtisticPaintStrokes.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticPaintStrokes? ArtisticPaintStrokes { get ; set; }
  
  /// <summary>
  /// ArtisticPaintBrush.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticPaintBrush? ArtisticPaintBrush { get ; set; }
  
  /// <summary>
  /// ArtisticPastelsSmooth.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticPastelsSmooth? ArtisticPastelsSmooth { get ; set; }
  
  /// <summary>
  /// ArtisticPencilGrayscale.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticPencilGrayscale? ArtisticPencilGrayscale { get ; set; }
  
  /// <summary>
  /// ArtisticPencilSketch.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticPencilSketch? ArtisticPencilSketch { get ; set; }
  
  /// <summary>
  /// ArtisticPhotocopy.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticPhotocopy? ArtisticPhotocopy { get ; set; }
  
  /// <summary>
  /// ArtisticPlasticWrap.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticPlasticWrap? ArtisticPlasticWrap { get ; set; }
  
  /// <summary>
  /// ArtisticTexturizer.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticTexturizer? ArtisticTexturizer { get ; set; }
  
  /// <summary>
  /// ArtisticWatercolorSponge.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IArtisticWatercolorSponge? ArtisticWatercolorSponge { get ; set; }
  
  /// <summary>
  /// BackgroundRemoval.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IBackgroundRemoval? BackgroundRemoval { get ; set; }
  
  /// <summary>
  /// BrightnessContrast.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IBrightnessContrast? BrightnessContrast { get ; set; }
  
  /// <summary>
  /// ColorTemperature.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IColorTemperature? ColorTemperature { get ; set; }
  
  /// <summary>
  /// Saturation.
  /// </summary>
  public DocumentModel.Office2010.Drawing.ISaturation? Saturation { get ; set; }
  
  /// <summary>
  /// SharpenSoften.
  /// </summary>
  public DocumentModel.Office2010.Drawing.ISharpenSoften? SharpenSoften { get ; set; }
  
}
