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
    get
    {
      return _Element?.Visible?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Visible = null;
    }
  }
  
  
  /// <summary>
  ///   ArtisticBlur.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticBlur? ArtisticBlur
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticBlur>();
      if (element != null)
        return ArtisticBlurConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticBlur>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticBlurConverter.CreateOpenXmlElement<DXO10D.ArtisticBlur>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticCement.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticCement? ArtisticCement
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticCement>();
      if (element != null)
        return ArtisticCementConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticCement>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticCementConverter.CreateOpenXmlElement<DXO10D.ArtisticCement>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticChalkSketch.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticChalkSketch? ArtisticChalkSketch
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticChalkSketch>();
      if (element != null)
        return ArtisticChalkSketchConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticChalkSketch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticChalkSketchConverter.CreateOpenXmlElement<DXO10D.ArtisticChalkSketch>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticCrisscrossEtching.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticCrisscrossEtching? ArtisticCrisscrossEtching
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticCrisscrossEtching>();
      if (element != null)
        return ArtisticCrisscrossEtchingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticCrisscrossEtching>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticCrisscrossEtchingConverter.CreateOpenXmlElement<DXO10D.ArtisticCrisscrossEtching>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticCutout.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticCutout? ArtisticCutout
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticCutout>();
      if (element != null)
        return ArtisticCutoutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticCutout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticCutoutConverter.CreateOpenXmlElement<DXO10D.ArtisticCutout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticFilmGrain.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticFilmGrain? ArtisticFilmGrain
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticFilmGrain>();
      if (element != null)
        return ArtisticFilmGrainConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticFilmGrain>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticFilmGrainConverter.CreateOpenXmlElement<DXO10D.ArtisticFilmGrain>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticGlass.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticGlass? ArtisticGlass
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticGlass>();
      if (element != null)
        return ArtisticGlassConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticGlass>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticGlassConverter.CreateOpenXmlElement<DXO10D.ArtisticGlass>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticGlowDiffused.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticGlowDiffused? ArtisticGlowDiffused
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticGlowDiffused>();
      if (element != null)
        return ArtisticGlowDiffusedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticGlowDiffused>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticGlowDiffusedConverter.CreateOpenXmlElement<DXO10D.ArtisticGlowDiffused>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticGlowEdges.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticGlowEdges? ArtisticGlowEdges
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticGlowEdges>();
      if (element != null)
        return ArtisticGlowEdgesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticGlowEdges>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticGlowEdgesConverter.CreateOpenXmlElement<DXO10D.ArtisticGlowEdges>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticLightScreen.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticLightScreen? ArtisticLightScreen
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticLightScreen>();
      if (element != null)
        return ArtisticLightScreenConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticLightScreen>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticLightScreenConverter.CreateOpenXmlElement<DXO10D.ArtisticLightScreen>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticLineDrawing.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticLineDrawing? ArtisticLineDrawing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticLineDrawing>();
      if (element != null)
        return ArtisticLineDrawingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticLineDrawing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticLineDrawingConverter.CreateOpenXmlElement<DXO10D.ArtisticLineDrawing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticMarker.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticMarker? ArtisticMarker
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticMarker>();
      if (element != null)
        return ArtisticMarkerConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticMarker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticMarkerConverter.CreateOpenXmlElement<DXO10D.ArtisticMarker>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticMosaicBubbles.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticMosaicBubbles? ArtisticMosaicBubbles
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticMosaicBubbles>();
      if (element != null)
        return ArtisticMosaicBubblesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticMosaicBubbles>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticMosaicBubblesConverter.CreateOpenXmlElement<DXO10D.ArtisticMosaicBubbles>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticPaintStrokes.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPaintStrokes? ArtisticPaintStrokes
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticPaintStrokes>();
      if (element != null)
        return ArtisticPaintStrokesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticPaintStrokes>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPaintStrokesConverter.CreateOpenXmlElement<DXO10D.ArtisticPaintStrokes>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticPaintBrush.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPaintBrush? ArtisticPaintBrush
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticPaintBrush>();
      if (element != null)
        return ArtisticPaintBrushConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticPaintBrush>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPaintBrushConverter.CreateOpenXmlElement<DXO10D.ArtisticPaintBrush>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticPastelsSmooth.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPastelsSmooth? ArtisticPastelsSmooth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticPastelsSmooth>();
      if (element != null)
        return ArtisticPastelsSmoothConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticPastelsSmooth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPastelsSmoothConverter.CreateOpenXmlElement<DXO10D.ArtisticPastelsSmooth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticPencilGrayscale.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPencilGrayscale? ArtisticPencilGrayscale
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticPencilGrayscale>();
      if (element != null)
        return ArtisticPencilGrayscaleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticPencilGrayscale>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPencilGrayscaleConverter.CreateOpenXmlElement<DXO10D.ArtisticPencilGrayscale>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticPencilSketch.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPencilSketch? ArtisticPencilSketch
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticPencilSketch>();
      if (element != null)
        return ArtisticPencilSketchConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticPencilSketch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPencilSketchConverter.CreateOpenXmlElement<DXO10D.ArtisticPencilSketch>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticPhotocopy.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPhotocopy? ArtisticPhotocopy
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticPhotocopy>();
      if (element != null)
        return ArtisticPhotocopyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticPhotocopy>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPhotocopyConverter.CreateOpenXmlElement<DXO10D.ArtisticPhotocopy>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticPlasticWrap.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticPlasticWrap? ArtisticPlasticWrap
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticPlasticWrap>();
      if (element != null)
        return ArtisticPlasticWrapConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticPlasticWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPlasticWrapConverter.CreateOpenXmlElement<DXO10D.ArtisticPlasticWrap>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticTexturizer.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticTexturizer? ArtisticTexturizer
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticTexturizer>();
      if (element != null)
        return ArtisticTexturizerConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticTexturizer>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticTexturizerConverter.CreateOpenXmlElement<DXO10D.ArtisticTexturizer>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ArtisticWatercolorSponge.
  /// </summary>
  [DataMember]
  public DMD10.ArtisticWatercolorSponge? ArtisticWatercolorSponge
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ArtisticWatercolorSponge>();
      if (element != null)
        return ArtisticWatercolorSpongeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ArtisticWatercolorSponge>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticWatercolorSpongeConverter.CreateOpenXmlElement<DXO10D.ArtisticWatercolorSponge>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   BackgroundRemoval.
  /// </summary>
  [DataMember]
  public DMD10.BackgroundRemoval? BackgroundRemoval
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.BackgroundRemoval>();
      if (element != null)
        return BackgroundRemovalConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.BackgroundRemoval>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundRemovalConverter.CreateOpenXmlElement<DXO10D.BackgroundRemoval>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   BrightnessContrast.
  /// </summary>
  [DataMember]
  public DMD10.BrightnessContrast? BrightnessContrast
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.BrightnessContrast>();
      if (element != null)
        return BrightnessContrastConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.BrightnessContrast>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BrightnessContrastConverter.CreateOpenXmlElement<DXO10D.BrightnessContrast>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ColorTemperature.
  /// </summary>
  [DataMember]
  public DMD10.ColorTemperature? ColorTemperature
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.ColorTemperature>();
      if (element != null)
        return ColorTemperatureConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.ColorTemperature>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorTemperatureConverter.CreateOpenXmlElement<DXO10D.ColorTemperature>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Saturation.
  /// </summary>
  [DataMember]
  public DMD10.Saturation? Saturation
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.Saturation>();
      if (element != null)
        return SaturationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.Saturation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SaturationConverter.CreateOpenXmlElement<DXO10D.Saturation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   SharpenSoften.
  /// </summary>
  [DataMember]
  public DMD10.SharpenSoften? SharpenSoften
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.SharpenSoften>();
      if (element != null)
        return SharpenSoftenConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.SharpenSoften>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SharpenSoftenConverter.CreateOpenXmlElement<DXO10D.SharpenSoften>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
