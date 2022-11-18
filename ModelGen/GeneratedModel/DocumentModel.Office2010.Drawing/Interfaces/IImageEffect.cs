namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ImageEffect Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IBackgroundRemoval))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticBlur))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IBrightnessContrast))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticCement))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticChalkSketch))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IColorTemperature))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticCrisscrossEtching))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticCutout))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticFilmGrain))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticGlass))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticGlowDiffused))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticGlowEdges))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticLightScreen))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticLineDrawing))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticMarker))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticMosaicBubbles))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticPaintBrush))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticPaintStrokes))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticPastelsSmooth))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticPencilGrayscale))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticPencilSketch))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticPhotocopy))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticPlasticWrap))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ISaturation))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ISharpenSoften))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticTexturizer))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IArtisticWatercolorSponge))]
public interface IImageEffect // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get ; set; }
  
  /// <summary>
  /// ArtisticBlur.
  /// </summary>
  public IArtisticBlur? ArtisticBlur { get ; set; }
  
  /// <summary>
  /// ArtisticCement.
  /// </summary>
  public IArtisticCement? ArtisticCement { get ; set; }
  
  /// <summary>
  /// ArtisticChalkSketch.
  /// </summary>
  public IArtisticChalkSketch? ArtisticChalkSketch { get ; set; }
  
  /// <summary>
  /// ArtisticCrisscrossEtching.
  /// </summary>
  public IArtisticCrisscrossEtching? ArtisticCrisscrossEtching { get ; set; }
  
  /// <summary>
  /// ArtisticCutout.
  /// </summary>
  public IArtisticCutout? ArtisticCutout { get ; set; }
  
  /// <summary>
  /// ArtisticFilmGrain.
  /// </summary>
  public IArtisticFilmGrain? ArtisticFilmGrain { get ; set; }
  
  /// <summary>
  /// ArtisticGlass.
  /// </summary>
  public IArtisticGlass? ArtisticGlass { get ; set; }
  
  /// <summary>
  /// ArtisticGlowDiffused.
  /// </summary>
  public IArtisticGlowDiffused? ArtisticGlowDiffused { get ; set; }
  
  /// <summary>
  /// ArtisticGlowEdges.
  /// </summary>
  public IArtisticGlowEdges? ArtisticGlowEdges { get ; set; }
  
  /// <summary>
  /// ArtisticLightScreen.
  /// </summary>
  public IArtisticLightScreen? ArtisticLightScreen { get ; set; }
  
  /// <summary>
  /// ArtisticLineDrawing.
  /// </summary>
  public IArtisticLineDrawing? ArtisticLineDrawing { get ; set; }
  
  /// <summary>
  /// ArtisticMarker.
  /// </summary>
  public IArtisticMarker? ArtisticMarker { get ; set; }
  
  /// <summary>
  /// ArtisticMosaicBubbles.
  /// </summary>
  public IArtisticMosaicBubbles? ArtisticMosaicBubbles { get ; set; }
  
  /// <summary>
  /// ArtisticPaintStrokes.
  /// </summary>
  public IArtisticPaintStrokes? ArtisticPaintStrokes { get ; set; }
  
  /// <summary>
  /// ArtisticPaintBrush.
  /// </summary>
  public IArtisticPaintBrush? ArtisticPaintBrush { get ; set; }
  
  /// <summary>
  /// ArtisticPastelsSmooth.
  /// </summary>
  public IArtisticPastelsSmooth? ArtisticPastelsSmooth { get ; set; }
  
  /// <summary>
  /// ArtisticPencilGrayscale.
  /// </summary>
  public IArtisticPencilGrayscale? ArtisticPencilGrayscale { get ; set; }
  
  /// <summary>
  /// ArtisticPencilSketch.
  /// </summary>
  public IArtisticPencilSketch? ArtisticPencilSketch { get ; set; }
  
  /// <summary>
  /// ArtisticPhotocopy.
  /// </summary>
  public IArtisticPhotocopy? ArtisticPhotocopy { get ; set; }
  
  /// <summary>
  /// ArtisticPlasticWrap.
  /// </summary>
  public IArtisticPlasticWrap? ArtisticPlasticWrap { get ; set; }
  
  /// <summary>
  /// ArtisticTexturizer.
  /// </summary>
  public IArtisticTexturizer? ArtisticTexturizer { get ; set; }
  
  /// <summary>
  /// ArtisticWatercolorSponge.
  /// </summary>
  public IArtisticWatercolorSponge? ArtisticWatercolorSponge { get ; set; }
  
  /// <summary>
  /// BackgroundRemoval.
  /// </summary>
  public IBackgroundRemoval? BackgroundRemoval { get ; set; }
  
  /// <summary>
  /// BrightnessContrast.
  /// </summary>
  public IBrightnessContrast? BrightnessContrast { get ; set; }
  
  /// <summary>
  /// ColorTemperature.
  /// </summary>
  public IColorTemperature? ColorTemperature { get ; set; }
  
  /// <summary>
  /// Saturation.
  /// </summary>
  public DocumentModel.Office2010.Drawing.ISaturation? Saturation { get ; set; }
  
  /// <summary>
  /// SharpenSoften.
  /// </summary>
  public ISharpenSoften? SharpenSoften { get ; set; }
  
}
