namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ImageEffect Class.
/// </summary>
public static class ImageEffectConverter
{
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010Draw.ImageEffect openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DXO2010Draw.ImageEffect openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// ArtisticBlur.
  /// </summary>
  private static DMDraws.ArtisticBlur? GetArtisticBlur(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticBlur>();
    if (itemElement != null)
      return DMXDraws.ArtisticBlurConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticBlur(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticBlur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticBlur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticBlurConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticBlur>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticCement.
  /// </summary>
  private static DMDraws.ArtisticCement? GetArtisticCement(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticCement>();
    if (itemElement != null)
      return DMXDraws.ArtisticCementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticCement(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticCement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticCement>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticCementConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticCement>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticChalkSketch.
  /// </summary>
  private static DMDraws.ArtisticChalkSketch? GetArtisticChalkSketch(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticChalkSketch>();
    if (itemElement != null)
      return DMXDraws.ArtisticChalkSketchConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticChalkSketch(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticChalkSketch? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticChalkSketch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticChalkSketchConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticChalkSketch>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticCrisscrossEtching.
  /// </summary>
  private static DMDraws.ArtisticCrisscrossEtching? GetArtisticCrisscrossEtching(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticCrisscrossEtching>();
    if (itemElement != null)
      return DMXDraws.ArtisticCrisscrossEtchingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticCrisscrossEtching(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticCrisscrossEtching? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticCrisscrossEtching>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticCrisscrossEtchingConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticCrisscrossEtching>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticCutout.
  /// </summary>
  private static DMDraws.ArtisticCutout? GetArtisticCutout(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticCutout>();
    if (itemElement != null)
      return DMXDraws.ArtisticCutoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticCutout(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticCutout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticCutout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticCutoutConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticCutout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticFilmGrain.
  /// </summary>
  private static DMDraws.ArtisticFilmGrain? GetArtisticFilmGrain(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticFilmGrain>();
    if (itemElement != null)
      return DMXDraws.ArtisticFilmGrainConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticFilmGrain(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticFilmGrain? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticFilmGrain>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticFilmGrainConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticFilmGrain>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticGlass.
  /// </summary>
  private static DMDraws.ArtisticGlass? GetArtisticGlass(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticGlass>();
    if (itemElement != null)
      return DMXDraws.ArtisticGlassConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticGlass(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticGlass? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticGlass>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticGlassConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticGlass>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticGlowDiffused.
  /// </summary>
  private static DMDraws.ArtisticGlowDiffused? GetArtisticGlowDiffused(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticGlowDiffused>();
    if (itemElement != null)
      return DMXDraws.ArtisticGlowDiffusedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticGlowDiffused(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticGlowDiffused? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticGlowDiffused>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticGlowDiffusedConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticGlowDiffused>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticGlowEdges.
  /// </summary>
  private static DMDraws.ArtisticGlowEdges? GetArtisticGlowEdges(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticGlowEdges>();
    if (itemElement != null)
      return DMXDraws.ArtisticGlowEdgesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticGlowEdges(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticGlowEdges? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticGlowEdges>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticGlowEdgesConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticGlowEdges>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticLightScreen.
  /// </summary>
  private static DMDraws.ArtisticLightScreen? GetArtisticLightScreen(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticLightScreen>();
    if (itemElement != null)
      return DMXDraws.ArtisticLightScreenConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticLightScreen(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticLightScreen? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticLightScreen>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticLightScreenConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticLightScreen>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticLineDrawing.
  /// </summary>
  private static DMDraws.ArtisticLineDrawing? GetArtisticLineDrawing(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticLineDrawing>();
    if (itemElement != null)
      return DMXDraws.ArtisticLineDrawingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticLineDrawing(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticLineDrawing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticLineDrawing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticLineDrawingConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticLineDrawing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticMarker.
  /// </summary>
  private static DMDraws.ArtisticMarker? GetArtisticMarker(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticMarker>();
    if (itemElement != null)
      return DMXDraws.ArtisticMarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticMarker(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticMarker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticMarker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticMarkerConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticMarker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticMosaicBubbles.
  /// </summary>
  private static DMDraws.ArtisticMosaicBubbles? GetArtisticMosaicBubbles(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticMosaicBubbles>();
    if (itemElement != null)
      return DMXDraws.ArtisticMosaicBubblesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticMosaicBubbles(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticMosaicBubbles? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticMosaicBubbles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticMosaicBubblesConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticMosaicBubbles>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPaintStrokes.
  /// </summary>
  private static DMDraws.ArtisticPaintStrokes? GetArtisticPaintStrokes(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticPaintStrokes>();
    if (itemElement != null)
      return DMXDraws.ArtisticPaintStrokesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPaintStrokes(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticPaintStrokes? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticPaintStrokes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticPaintStrokesConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticPaintStrokes>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPaintBrush.
  /// </summary>
  private static DMDraws.ArtisticPaintBrush? GetArtisticPaintBrush(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticPaintBrush>();
    if (itemElement != null)
      return DMXDraws.ArtisticPaintBrushConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPaintBrush(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticPaintBrush? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticPaintBrush>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticPaintBrushConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticPaintBrush>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPastelsSmooth.
  /// </summary>
  private static DMDraws.ArtisticPastelsSmooth? GetArtisticPastelsSmooth(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticPastelsSmooth>();
    if (itemElement != null)
      return DMXDraws.ArtisticPastelsSmoothConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPastelsSmooth(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticPastelsSmooth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticPastelsSmooth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticPastelsSmoothConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticPastelsSmooth>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPencilGrayscale.
  /// </summary>
  private static DMDraws.ArtisticPencilGrayscale? GetArtisticPencilGrayscale(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticPencilGrayscale>();
    if (itemElement != null)
      return DMXDraws.ArtisticPencilGrayscaleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPencilGrayscale(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticPencilGrayscale? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticPencilGrayscale>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticPencilGrayscaleConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticPencilGrayscale>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPencilSketch.
  /// </summary>
  private static DMDraws.ArtisticPencilSketch? GetArtisticPencilSketch(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticPencilSketch>();
    if (itemElement != null)
      return DMXDraws.ArtisticPencilSketchConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPencilSketch(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticPencilSketch? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticPencilSketch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticPencilSketchConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticPencilSketch>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPhotocopy.
  /// </summary>
  private static DMDraws.ArtisticPhotocopy? GetArtisticPhotocopy(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticPhotocopy>();
    if (itemElement != null)
      return DMXDraws.ArtisticPhotocopyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPhotocopy(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticPhotocopy? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticPhotocopy>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticPhotocopyConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticPhotocopy>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPlasticWrap.
  /// </summary>
  private static DMDraws.ArtisticPlasticWrap? GetArtisticPlasticWrap(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticPlasticWrap>();
    if (itemElement != null)
      return DMXDraws.ArtisticPlasticWrapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPlasticWrap(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticPlasticWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticPlasticWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticPlasticWrapConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticPlasticWrap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticTexturizer.
  /// </summary>
  private static DMDraws.ArtisticTexturizer? GetArtisticTexturizer(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticTexturizer>();
    if (itemElement != null)
      return DMXDraws.ArtisticTexturizerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticTexturizer(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticTexturizer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticTexturizer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticTexturizerConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticTexturizer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticWatercolorSponge.
  /// </summary>
  private static DMDraws.ArtisticWatercolorSponge? GetArtisticWatercolorSponge(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ArtisticWatercolorSponge>();
    if (itemElement != null)
      return DMXDraws.ArtisticWatercolorSpongeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticWatercolorSponge(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ArtisticWatercolorSponge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ArtisticWatercolorSponge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArtisticWatercolorSpongeConverter.CreateOpenXmlElement<DXO2010Draw.ArtisticWatercolorSponge>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BackgroundRemoval.
  /// </summary>
  private static DMDraws.BackgroundRemoval? GetBackgroundRemoval(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.BackgroundRemoval>();
    if (itemElement != null)
      return DMXDraws.BackgroundRemovalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackgroundRemoval(DXO2010Draw.ImageEffect openXmlElement, DMDraws.BackgroundRemoval? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.BackgroundRemoval>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BackgroundRemovalConverter.CreateOpenXmlElement<DXO2010Draw.BackgroundRemoval>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BrightnessContrast.
  /// </summary>
  private static DMDraws.BrightnessContrast? GetBrightnessContrast(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.BrightnessContrast>();
    if (itemElement != null)
      return DMXDraws.BrightnessContrastConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBrightnessContrast(DXO2010Draw.ImageEffect openXmlElement, DMDraws.BrightnessContrast? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.BrightnessContrast>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BrightnessContrastConverter.CreateOpenXmlElement<DXO2010Draw.BrightnessContrast>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ColorTemperature.
  /// </summary>
  private static DMDraws.ColorTemperature? GetColorTemperature(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ColorTemperature>();
    if (itemElement != null)
      return DMXDraws.ColorTemperatureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorTemperature(DXO2010Draw.ImageEffect openXmlElement, DMDraws.ColorTemperature? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ColorTemperature>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorTemperatureConverter.CreateOpenXmlElement<DXO2010Draw.ColorTemperature>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Saturation.
  /// </summary>
  private static DMDraws.Saturation2? GetSaturation(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.Saturation>();
    if (itemElement != null)
      return DMXDraws.Saturation2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSaturation(DXO2010Draw.ImageEffect openXmlElement, DMDraws.Saturation2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.Saturation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Saturation2Converter.CreateOpenXmlElement<DXO2010Draw.Saturation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SharpenSoften.
  /// </summary>
  private static DMDraws.SharpenSoften? GetSharpenSoften(DXO2010Draw.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.SharpenSoften>();
    if (itemElement != null)
      return DMXDraws.SharpenSoftenConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSharpenSoften(DXO2010Draw.ImageEffect openXmlElement, DMDraws.SharpenSoften? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.SharpenSoften>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SharpenSoftenConverter.CreateOpenXmlElement<DXO2010Draw.SharpenSoften>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ImageEffect? CreateModelElement(DXO2010Draw.ImageEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ImageEffect();
      value.Visible = GetVisible(openXmlElement);
      value.ArtisticBlur = GetArtisticBlur(openXmlElement);
      value.ArtisticCement = GetArtisticCement(openXmlElement);
      value.ArtisticChalkSketch = GetArtisticChalkSketch(openXmlElement);
      value.ArtisticCrisscrossEtching = GetArtisticCrisscrossEtching(openXmlElement);
      value.ArtisticCutout = GetArtisticCutout(openXmlElement);
      value.ArtisticFilmGrain = GetArtisticFilmGrain(openXmlElement);
      value.ArtisticGlass = GetArtisticGlass(openXmlElement);
      value.ArtisticGlowDiffused = GetArtisticGlowDiffused(openXmlElement);
      value.ArtisticGlowEdges = GetArtisticGlowEdges(openXmlElement);
      value.ArtisticLightScreen = GetArtisticLightScreen(openXmlElement);
      value.ArtisticLineDrawing = GetArtisticLineDrawing(openXmlElement);
      value.ArtisticMarker = GetArtisticMarker(openXmlElement);
      value.ArtisticMosaicBubbles = GetArtisticMosaicBubbles(openXmlElement);
      value.ArtisticPaintStrokes = GetArtisticPaintStrokes(openXmlElement);
      value.ArtisticPaintBrush = GetArtisticPaintBrush(openXmlElement);
      value.ArtisticPastelsSmooth = GetArtisticPastelsSmooth(openXmlElement);
      value.ArtisticPencilGrayscale = GetArtisticPencilGrayscale(openXmlElement);
      value.ArtisticPencilSketch = GetArtisticPencilSketch(openXmlElement);
      value.ArtisticPhotocopy = GetArtisticPhotocopy(openXmlElement);
      value.ArtisticPlasticWrap = GetArtisticPlasticWrap(openXmlElement);
      value.ArtisticTexturizer = GetArtisticTexturizer(openXmlElement);
      value.ArtisticWatercolorSponge = GetArtisticWatercolorSponge(openXmlElement);
      value.BackgroundRemoval = GetBackgroundRemoval(openXmlElement);
      value.BrightnessContrast = GetBrightnessContrast(openXmlElement);
      value.ColorTemperature = GetColorTemperature(openXmlElement);
      value.Saturation = GetSaturation(openXmlElement);
      value.SharpenSoften = GetSharpenSoften(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ImageEffect? value)
    where OpenXmlElementType: DXO2010Draw.ImageEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVisible(openXmlElement, value?.Visible);
      SetArtisticBlur(openXmlElement, value?.ArtisticBlur);
      SetArtisticCement(openXmlElement, value?.ArtisticCement);
      SetArtisticChalkSketch(openXmlElement, value?.ArtisticChalkSketch);
      SetArtisticCrisscrossEtching(openXmlElement, value?.ArtisticCrisscrossEtching);
      SetArtisticCutout(openXmlElement, value?.ArtisticCutout);
      SetArtisticFilmGrain(openXmlElement, value?.ArtisticFilmGrain);
      SetArtisticGlass(openXmlElement, value?.ArtisticGlass);
      SetArtisticGlowDiffused(openXmlElement, value?.ArtisticGlowDiffused);
      SetArtisticGlowEdges(openXmlElement, value?.ArtisticGlowEdges);
      SetArtisticLightScreen(openXmlElement, value?.ArtisticLightScreen);
      SetArtisticLineDrawing(openXmlElement, value?.ArtisticLineDrawing);
      SetArtisticMarker(openXmlElement, value?.ArtisticMarker);
      SetArtisticMosaicBubbles(openXmlElement, value?.ArtisticMosaicBubbles);
      SetArtisticPaintStrokes(openXmlElement, value?.ArtisticPaintStrokes);
      SetArtisticPaintBrush(openXmlElement, value?.ArtisticPaintBrush);
      SetArtisticPastelsSmooth(openXmlElement, value?.ArtisticPastelsSmooth);
      SetArtisticPencilGrayscale(openXmlElement, value?.ArtisticPencilGrayscale);
      SetArtisticPencilSketch(openXmlElement, value?.ArtisticPencilSketch);
      SetArtisticPhotocopy(openXmlElement, value?.ArtisticPhotocopy);
      SetArtisticPlasticWrap(openXmlElement, value?.ArtisticPlasticWrap);
      SetArtisticTexturizer(openXmlElement, value?.ArtisticTexturizer);
      SetArtisticWatercolorSponge(openXmlElement, value?.ArtisticWatercolorSponge);
      SetBackgroundRemoval(openXmlElement, value?.BackgroundRemoval);
      SetBrightnessContrast(openXmlElement, value?.BrightnessContrast);
      SetColorTemperature(openXmlElement, value?.ColorTemperature);
      SetSaturation(openXmlElement, value?.Saturation);
      SetSharpenSoften(openXmlElement, value?.SharpenSoften);
      return openXmlElement;
    }
    return default;
  }
}
