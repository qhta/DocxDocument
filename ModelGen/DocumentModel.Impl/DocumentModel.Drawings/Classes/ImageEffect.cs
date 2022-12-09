namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ImageEffect Class.
/// </summary>
public class ImageEffectImpl: ModelElementImpl, ImageEffect
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible
  {
    get => (Boolean?)OpenXmlElement?.Visible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Visible = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// ArtisticBlur.
  /// </summary>
  public ArtisticBlur? ArtisticBlur
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticCement.
  /// </summary>
  public ArtisticCement? ArtisticCement
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticChalkSketch.
  /// </summary>
  public ArtisticChalkSketch? ArtisticChalkSketch
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticCrisscrossEtching.
  /// </summary>
  public ArtisticCrisscrossEtching? ArtisticCrisscrossEtching
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticCutout.
  /// </summary>
  public ArtisticCutout? ArtisticCutout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticFilmGrain.
  /// </summary>
  public ArtisticFilmGrain? ArtisticFilmGrain
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticGlass.
  /// </summary>
  public ArtisticGlass? ArtisticGlass
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticGlowDiffused.
  /// </summary>
  public ArtisticGlowDiffused? ArtisticGlowDiffused
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticGlowEdges.
  /// </summary>
  public ArtisticGlowEdges? ArtisticGlowEdges
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticLightScreen.
  /// </summary>
  public ArtisticLightScreen? ArtisticLightScreen
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticLineDrawing.
  /// </summary>
  public ArtisticLineDrawing? ArtisticLineDrawing
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticMarker.
  /// </summary>
  public ArtisticMarker? ArtisticMarker
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticMosaicBubbles.
  /// </summary>
  public ArtisticMosaicBubbles? ArtisticMosaicBubbles
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPaintStrokes.
  /// </summary>
  public ArtisticPaintStrokes? ArtisticPaintStrokes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPaintBrush.
  /// </summary>
  public ArtisticPaintBrush? ArtisticPaintBrush
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPastelsSmooth.
  /// </summary>
  public ArtisticPastelsSmooth? ArtisticPastelsSmooth
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPencilGrayscale.
  /// </summary>
  public ArtisticPencilGrayscale? ArtisticPencilGrayscale
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPencilSketch.
  /// </summary>
  public ArtisticPencilSketch? ArtisticPencilSketch
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPhotocopy.
  /// </summary>
  public ArtisticPhotocopy? ArtisticPhotocopy
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPlasticWrap.
  /// </summary>
  public ArtisticPlasticWrap? ArtisticPlasticWrap
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticTexturizer.
  /// </summary>
  public ArtisticTexturizer? ArtisticTexturizer
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticWatercolorSponge.
  /// </summary>
  public ArtisticWatercolorSponge? ArtisticWatercolorSponge
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// BackgroundRemoval.
  /// </summary>
  public BackgroundRemoval? BackgroundRemoval
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// BrightnessContrast.
  /// </summary>
  public BrightnessContrast? BrightnessContrast
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ColorTemperature.
  /// </summary>
  public ColorTemperature? ColorTemperature
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Saturation.
  /// </summary>
  public Saturation1? Saturation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// SharpenSoften.
  /// </summary>
  public SharpenSoften? SharpenSoften
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
