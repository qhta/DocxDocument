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
        _ExistingElement.Visible = new DX.BooleanValue { Value = (Boolean)value };
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
      return _Element?.GetObject<DMD10.ArtisticBlur,DXO10D.ArtisticBlur>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticBlur,DXO10D.ArtisticBlur>(value);
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
      return _Element?.GetObject<DMD10.ArtisticCement,DXO10D.ArtisticCement>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticCement,DXO10D.ArtisticCement>(value);
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
      return _Element?.GetObject<DMD10.ArtisticChalkSketch,DXO10D.ArtisticChalkSketch>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticChalkSketch,DXO10D.ArtisticChalkSketch>(value);
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
      return _Element?.GetObject<DMD10.ArtisticCrisscrossEtching,DXO10D.ArtisticCrisscrossEtching>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticCrisscrossEtching,DXO10D.ArtisticCrisscrossEtching>(value);
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
      return _Element?.GetObject<DMD10.ArtisticCutout,DXO10D.ArtisticCutout>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticCutout,DXO10D.ArtisticCutout>(value);
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
      return _Element?.GetObject<DMD10.ArtisticFilmGrain,DXO10D.ArtisticFilmGrain>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticFilmGrain,DXO10D.ArtisticFilmGrain>(value);
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
      return _Element?.GetObject<DMD10.ArtisticGlass,DXO10D.ArtisticGlass>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticGlass,DXO10D.ArtisticGlass>(value);
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
      return _Element?.GetObject<DMD10.ArtisticGlowDiffused,DXO10D.ArtisticGlowDiffused>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticGlowDiffused,DXO10D.ArtisticGlowDiffused>(value);
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
      return _Element?.GetObject<DMD10.ArtisticGlowEdges,DXO10D.ArtisticGlowEdges>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticGlowEdges,DXO10D.ArtisticGlowEdges>(value);
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
      return _Element?.GetObject<DMD10.ArtisticLightScreen,DXO10D.ArtisticLightScreen>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticLightScreen,DXO10D.ArtisticLightScreen>(value);
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
      return _Element?.GetObject<DMD10.ArtisticLineDrawing,DXO10D.ArtisticLineDrawing>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticLineDrawing,DXO10D.ArtisticLineDrawing>(value);
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
      return _Element?.GetObject<DMD10.ArtisticMarker,DXO10D.ArtisticMarker>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticMarker,DXO10D.ArtisticMarker>(value);
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
      return _Element?.GetObject<DMD10.ArtisticMosaicBubbles,DXO10D.ArtisticMosaicBubbles>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticMosaicBubbles,DXO10D.ArtisticMosaicBubbles>(value);
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
      return _Element?.GetObject<DMD10.ArtisticPaintStrokes,DXO10D.ArtisticPaintStrokes>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticPaintStrokes,DXO10D.ArtisticPaintStrokes>(value);
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
      return _Element?.GetObject<DMD10.ArtisticPaintBrush,DXO10D.ArtisticPaintBrush>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticPaintBrush,DXO10D.ArtisticPaintBrush>(value);
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
      return _Element?.GetObject<DMD10.ArtisticPastelsSmooth,DXO10D.ArtisticPastelsSmooth>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticPastelsSmooth,DXO10D.ArtisticPastelsSmooth>(value);
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
      return _Element?.GetObject<DMD10.ArtisticPencilGrayscale,DXO10D.ArtisticPencilGrayscale>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticPencilGrayscale,DXO10D.ArtisticPencilGrayscale>(value);
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
      return _Element?.GetObject<DMD10.ArtisticPencilSketch,DXO10D.ArtisticPencilSketch>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticPencilSketch,DXO10D.ArtisticPencilSketch>(value);
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
      return _Element?.GetObject<DMD10.ArtisticPhotocopy,DXO10D.ArtisticPhotocopy>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticPhotocopy,DXO10D.ArtisticPhotocopy>(value);
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
      return _Element?.GetObject<DMD10.ArtisticPlasticWrap,DXO10D.ArtisticPlasticWrap>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticPlasticWrap,DXO10D.ArtisticPlasticWrap>(value);
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
      return _Element?.GetObject<DMD10.ArtisticTexturizer,DXO10D.ArtisticTexturizer>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticTexturizer,DXO10D.ArtisticTexturizer>(value);
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
      return _Element?.GetObject<DMD10.ArtisticWatercolorSponge,DXO10D.ArtisticWatercolorSponge>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ArtisticWatercolorSponge,DXO10D.ArtisticWatercolorSponge>(value);
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
      return _Element?.GetObject<DMD10.BackgroundRemoval,DXO10D.BackgroundRemoval>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.BackgroundRemoval,DXO10D.BackgroundRemoval>(value);
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
      return _Element?.GetObject<DMD10.BrightnessContrast,DXO10D.BrightnessContrast>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.BrightnessContrast,DXO10D.BrightnessContrast>(value);
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
      return _Element?.GetObject<DMD10.ColorTemperature,DXO10D.ColorTemperature>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.ColorTemperature,DXO10D.ColorTemperature>(value);
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
      return _Element?.GetObject<DMD10.Saturation,DXO10D.Saturation>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.Saturation,DXO10D.Saturation>(value);
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
      return _Element?.GetObject<DMD10.SharpenSoften,DXO10D.SharpenSoften>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.SharpenSoften,DXO10D.SharpenSoften>(value);
    }
  }
  
}
