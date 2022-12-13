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
  
  public ImageEffectImpl(): base() {}
  
  public ImageEffectImpl(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible
  {
    get => (System.Boolean?)OpenXmlElement?.Visible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Visible = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// ArtisticBlur.
  /// </summary>
  public DocumentModel.Drawings.ArtisticBlur? ArtisticBlur
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticCement.
  /// </summary>
  public DocumentModel.Drawings.ArtisticCement? ArtisticCement
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticChalkSketch.
  /// </summary>
  public DocumentModel.Drawings.ArtisticChalkSketch? ArtisticChalkSketch
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticCrisscrossEtching.
  /// </summary>
  public DocumentModel.Drawings.ArtisticCrisscrossEtching? ArtisticCrisscrossEtching
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticCutout.
  /// </summary>
  public DocumentModel.Drawings.ArtisticCutout? ArtisticCutout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticFilmGrain.
  /// </summary>
  public DocumentModel.Drawings.ArtisticFilmGrain? ArtisticFilmGrain
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticGlass.
  /// </summary>
  public DocumentModel.Drawings.ArtisticGlass? ArtisticGlass
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticGlowDiffused.
  /// </summary>
  public DocumentModel.Drawings.ArtisticGlowDiffused? ArtisticGlowDiffused
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticGlowEdges.
  /// </summary>
  public DocumentModel.Drawings.ArtisticGlowEdges? ArtisticGlowEdges
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticLightScreen.
  /// </summary>
  public DocumentModel.Drawings.ArtisticLightScreen? ArtisticLightScreen
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticLineDrawing.
  /// </summary>
  public DocumentModel.Drawings.ArtisticLineDrawing? ArtisticLineDrawing
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticMarker.
  /// </summary>
  public DocumentModel.Drawings.ArtisticMarker? ArtisticMarker
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticMosaicBubbles.
  /// </summary>
  public DocumentModel.Drawings.ArtisticMosaicBubbles? ArtisticMosaicBubbles
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPaintStrokes.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPaintStrokes? ArtisticPaintStrokes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPaintBrush.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPaintBrush? ArtisticPaintBrush
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPastelsSmooth.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPastelsSmooth? ArtisticPastelsSmooth
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPencilGrayscale.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPencilGrayscale? ArtisticPencilGrayscale
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPencilSketch.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPencilSketch? ArtisticPencilSketch
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPhotocopy.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPhotocopy? ArtisticPhotocopy
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticPlasticWrap.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPlasticWrap? ArtisticPlasticWrap
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticTexturizer.
  /// </summary>
  public DocumentModel.Drawings.ArtisticTexturizer? ArtisticTexturizer
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ArtisticWatercolorSponge.
  /// </summary>
  public DocumentModel.Drawings.ArtisticWatercolorSponge? ArtisticWatercolorSponge
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// BackgroundRemoval.
  /// </summary>
  public DocumentModel.Drawings.BackgroundRemoval? BackgroundRemoval
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// BrightnessContrast.
  /// </summary>
  public DocumentModel.Drawings.BrightnessContrast? BrightnessContrast
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ColorTemperature.
  /// </summary>
  public DocumentModel.Drawings.ColorTemperature? ColorTemperature
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Saturation.
  /// </summary>
  public DocumentModel.Drawings.Saturation? Saturation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// SharpenSoften.
  /// </summary>
  public DocumentModel.Drawings.SharpenSoften? SharpenSoften
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
