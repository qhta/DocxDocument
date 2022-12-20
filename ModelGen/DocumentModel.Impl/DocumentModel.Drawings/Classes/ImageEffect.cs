namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ImageEffect Class.
/// </summary>
public partial class ImageEffectImpl: ModelElementImpl, ImageEffect
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticBlurImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticBlurImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticCement.
  /// </summary>
  public DocumentModel.Drawings.ArtisticCement? ArtisticCement
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticCementImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticCementImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticChalkSketch.
  /// </summary>
  public DocumentModel.Drawings.ArtisticChalkSketch? ArtisticChalkSketch
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticChalkSketchImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticChalkSketchImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticCrisscrossEtching.
  /// </summary>
  public DocumentModel.Drawings.ArtisticCrisscrossEtching? ArtisticCrisscrossEtching
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticCrisscrossEtchingImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticCrisscrossEtchingImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticCutout.
  /// </summary>
  public DocumentModel.Drawings.ArtisticCutout? ArtisticCutout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticCutoutImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticCutoutImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticFilmGrain.
  /// </summary>
  public DocumentModel.Drawings.ArtisticFilmGrain? ArtisticFilmGrain
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticFilmGrainImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticFilmGrainImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticGlass.
  /// </summary>
  public DocumentModel.Drawings.ArtisticGlass? ArtisticGlass
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticGlassImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticGlassImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticGlowDiffused.
  /// </summary>
  public DocumentModel.Drawings.ArtisticGlowDiffused? ArtisticGlowDiffused
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticGlowDiffusedImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticGlowDiffusedImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticGlowEdges.
  /// </summary>
  public DocumentModel.Drawings.ArtisticGlowEdges? ArtisticGlowEdges
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticGlowEdgesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticGlowEdgesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticLightScreen.
  /// </summary>
  public DocumentModel.Drawings.ArtisticLightScreen? ArtisticLightScreen
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticLightScreenImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticLightScreenImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticLineDrawing.
  /// </summary>
  public DocumentModel.Drawings.ArtisticLineDrawing? ArtisticLineDrawing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticLineDrawingImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticLineDrawingImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticMarker.
  /// </summary>
  public DocumentModel.Drawings.ArtisticMarker? ArtisticMarker
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticMarkerImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticMarkerImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticMosaicBubbles.
  /// </summary>
  public DocumentModel.Drawings.ArtisticMosaicBubbles? ArtisticMosaicBubbles
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticMosaicBubblesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticMosaicBubblesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticPaintStrokes.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPaintStrokes? ArtisticPaintStrokes
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticPaintStrokesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticPaintStrokesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticPaintBrush.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPaintBrush? ArtisticPaintBrush
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticPaintBrushImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticPaintBrushImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticPastelsSmooth.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPastelsSmooth? ArtisticPastelsSmooth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticPastelsSmoothImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticPastelsSmoothImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticPencilGrayscale.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPencilGrayscale? ArtisticPencilGrayscale
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticPencilGrayscaleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticPencilGrayscaleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticPencilSketch.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPencilSketch? ArtisticPencilSketch
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticPencilSketchImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticPencilSketchImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticPhotocopy.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPhotocopy? ArtisticPhotocopy
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticPhotocopyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticPhotocopyImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticPlasticWrap.
  /// </summary>
  public DocumentModel.Drawings.ArtisticPlasticWrap? ArtisticPlasticWrap
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticPlasticWrapImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticPlasticWrapImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticTexturizer.
  /// </summary>
  public DocumentModel.Drawings.ArtisticTexturizer? ArtisticTexturizer
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticTexturizerImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticTexturizerImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ArtisticWatercolorSponge.
  /// </summary>
  public DocumentModel.Drawings.ArtisticWatercolorSponge? ArtisticWatercolorSponge
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>();
        if (item != null)
          return new DocumentModel.Drawings.ArtisticWatercolorSpongeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ArtisticWatercolorSpongeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// BackgroundRemoval.
  /// </summary>
  public DocumentModel.Drawings.BackgroundRemoval? BackgroundRemoval
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>();
        if (item != null)
          return new DocumentModel.Drawings.BackgroundRemovalImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.BackgroundRemovalImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// BrightnessContrast.
  /// </summary>
  public DocumentModel.Drawings.BrightnessContrast? BrightnessContrast
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>();
        if (item != null)
          return new DocumentModel.Drawings.BrightnessContrastImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.BrightnessContrastImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ColorTemperature.
  /// </summary>
  public DocumentModel.Drawings.ColorTemperature? ColorTemperature
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>();
        if (item != null)
          return new DocumentModel.Drawings.ColorTemperatureImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ColorTemperatureImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Saturation.
  /// </summary>
  public DocumentModel.Drawings.Saturation2? Saturation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Saturation>();
        if (item != null)
          return new DocumentModel.Drawings.Saturation2Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Saturation>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Saturation2Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// SharpenSoften.
  /// </summary>
  public DocumentModel.Drawings.SharpenSoften? SharpenSoften
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>();
        if (item != null)
          return new DocumentModel.Drawings.SharpenSoftenImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.SharpenSoftenImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
