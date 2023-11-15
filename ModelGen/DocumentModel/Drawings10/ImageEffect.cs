namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ImageEffect Class.
/// </summary>
public partial class ImageEffect: ModelElement<DXO10D.ImageEffect>
{
  public ImageEffect(): base(){ }
  
  public ImageEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ImageEffect(DXO10D.ImageEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Visible
  {
    get => _Element?.Visible?.Value;
    set => _ExistingElement.Visible = value;
  }
  
  
  /// <summary>
  ///   ArtisticBlur.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticBlur? ArtisticBlur
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticCement.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticCement? ArtisticCement
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticChalkSketch.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticChalkSketch? ArtisticChalkSketch
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticCrisscrossEtching.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticCrisscrossEtching? ArtisticCrisscrossEtching
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticCutout.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticCutout? ArtisticCutout
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticFilmGrain.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticFilmGrain? ArtisticFilmGrain
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticGlass.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticGlass? ArtisticGlass
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticGlowDiffused.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticGlowDiffused? ArtisticGlowDiffused
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticGlowEdges.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticGlowEdges? ArtisticGlowEdges
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticLightScreen.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticLightScreen? ArtisticLightScreen
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticLineDrawing.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticLineDrawing? ArtisticLineDrawing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticMarker.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticMarker? ArtisticMarker
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticMosaicBubbles.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticMosaicBubbles? ArtisticMosaicBubbles
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticPaintStrokes.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPaintStrokes? ArtisticPaintStrokes
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticPaintBrush.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPaintBrush? ArtisticPaintBrush
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticPastelsSmooth.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPastelsSmooth? ArtisticPastelsSmooth
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticPencilGrayscale.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPencilGrayscale? ArtisticPencilGrayscale
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticPencilSketch.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPencilSketch? ArtisticPencilSketch
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticPhotocopy.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPhotocopy? ArtisticPhotocopy
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticPlasticWrap.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPlasticWrap? ArtisticPlasticWrap
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticTexturizer.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticTexturizer? ArtisticTexturizer
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ArtisticWatercolorSponge.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticWatercolorSponge? ArtisticWatercolorSponge
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   BackgroundRemoval.
  /// </summary>
  [DataMember]
  public DMD10.BackgroundRemoval? BackgroundRemoval
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   BrightnessContrast.
  /// </summary>
  [DataMember]
  public DMD10.BrightnessContrast? BrightnessContrast
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ColorTemperature.
  /// </summary>
  [DataMember]
  public DMD10.ColorTemperature? ColorTemperature
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Saturation.
  /// </summary>
  [DataMember]
  public DMD10.Saturation? Saturation
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   SharpenSoften.
  /// </summary>
  [DataMember]
  public DMD10.SharpenSoften? SharpenSoften
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
