namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ImageEffect Class.
/// </summary>
public static class ImageEffectConverter
{
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO10D.ImageEffect openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO10D.ImageEffect openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO10D.ImageEffect openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// ArtisticBlur.
  /// </summary>
  private static DMD.ArtisticBlur? GetArtisticBlur(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticBlur>();
    if (element != null)
      return DMXD.ArtisticBlurConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticBlur(DXO10D.ImageEffect openXmlElement, DMD.ArtisticBlur? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticBlurConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticBlur>(), value, diffs, objName);
  }
  
  private static void SetArtisticBlur(DXO10D.ImageEffect openXmlElement, DMD.ArtisticBlur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticBlur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticBlurConverter.CreateOpenXmlElement<DXO10D.ArtisticBlur>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticCement.
  /// </summary>
  private static DMD.ArtisticCement? GetArtisticCement(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticCement>();
    if (element != null)
      return DMXD.ArtisticCementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticCement(DXO10D.ImageEffect openXmlElement, DMD.ArtisticCement? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticCementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticCement>(), value, diffs, objName);
  }
  
  private static void SetArtisticCement(DXO10D.ImageEffect openXmlElement, DMD.ArtisticCement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticCement>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticCementConverter.CreateOpenXmlElement<DXO10D.ArtisticCement>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticChalkSketch.
  /// </summary>
  private static DMD.ArtisticChalkSketch? GetArtisticChalkSketch(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticChalkSketch>();
    if (element != null)
      return DMXD.ArtisticChalkSketchConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticChalkSketch(DXO10D.ImageEffect openXmlElement, DMD.ArtisticChalkSketch? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticChalkSketchConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticChalkSketch>(), value, diffs, objName);
  }
  
  private static void SetArtisticChalkSketch(DXO10D.ImageEffect openXmlElement, DMD.ArtisticChalkSketch? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticChalkSketch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticChalkSketchConverter.CreateOpenXmlElement<DXO10D.ArtisticChalkSketch>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticCrisscrossEtching.
  /// </summary>
  private static DMD.ArtisticCrisscrossEtching? GetArtisticCrisscrossEtching(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticCrisscrossEtching>();
    if (element != null)
      return DMXD.ArtisticCrisscrossEtchingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticCrisscrossEtching(DXO10D.ImageEffect openXmlElement, DMD.ArtisticCrisscrossEtching? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticCrisscrossEtchingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticCrisscrossEtching>(), value, diffs, objName);
  }
  
  private static void SetArtisticCrisscrossEtching(DXO10D.ImageEffect openXmlElement, DMD.ArtisticCrisscrossEtching? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticCrisscrossEtching>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticCrisscrossEtchingConverter.CreateOpenXmlElement<DXO10D.ArtisticCrisscrossEtching>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticCutout.
  /// </summary>
  private static DMD.ArtisticCutout? GetArtisticCutout(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticCutout>();
    if (element != null)
      return DMXD.ArtisticCutoutConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticCutout(DXO10D.ImageEffect openXmlElement, DMD.ArtisticCutout? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticCutoutConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticCutout>(), value, diffs, objName);
  }
  
  private static void SetArtisticCutout(DXO10D.ImageEffect openXmlElement, DMD.ArtisticCutout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticCutout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticCutoutConverter.CreateOpenXmlElement<DXO10D.ArtisticCutout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticFilmGrain.
  /// </summary>
  private static DMD.ArtisticFilmGrain? GetArtisticFilmGrain(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticFilmGrain>();
    if (element != null)
      return DMXD.ArtisticFilmGrainConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticFilmGrain(DXO10D.ImageEffect openXmlElement, DMD.ArtisticFilmGrain? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticFilmGrainConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticFilmGrain>(), value, diffs, objName);
  }
  
  private static void SetArtisticFilmGrain(DXO10D.ImageEffect openXmlElement, DMD.ArtisticFilmGrain? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticFilmGrain>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticFilmGrainConverter.CreateOpenXmlElement<DXO10D.ArtisticFilmGrain>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticGlass.
  /// </summary>
  private static DMD.ArtisticGlass? GetArtisticGlass(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticGlass>();
    if (element != null)
      return DMXD.ArtisticGlassConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticGlass(DXO10D.ImageEffect openXmlElement, DMD.ArtisticGlass? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticGlassConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticGlass>(), value, diffs, objName);
  }
  
  private static void SetArtisticGlass(DXO10D.ImageEffect openXmlElement, DMD.ArtisticGlass? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticGlass>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticGlassConverter.CreateOpenXmlElement<DXO10D.ArtisticGlass>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticGlowDiffused.
  /// </summary>
  private static DMD.ArtisticGlowDiffused? GetArtisticGlowDiffused(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticGlowDiffused>();
    if (element != null)
      return DMXD.ArtisticGlowDiffusedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticGlowDiffused(DXO10D.ImageEffect openXmlElement, DMD.ArtisticGlowDiffused? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticGlowDiffusedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticGlowDiffused>(), value, diffs, objName);
  }
  
  private static void SetArtisticGlowDiffused(DXO10D.ImageEffect openXmlElement, DMD.ArtisticGlowDiffused? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticGlowDiffused>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticGlowDiffusedConverter.CreateOpenXmlElement<DXO10D.ArtisticGlowDiffused>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticGlowEdges.
  /// </summary>
  private static DMD.ArtisticGlowEdges? GetArtisticGlowEdges(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticGlowEdges>();
    if (element != null)
      return DMXD.ArtisticGlowEdgesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticGlowEdges(DXO10D.ImageEffect openXmlElement, DMD.ArtisticGlowEdges? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticGlowEdgesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticGlowEdges>(), value, diffs, objName);
  }
  
  private static void SetArtisticGlowEdges(DXO10D.ImageEffect openXmlElement, DMD.ArtisticGlowEdges? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticGlowEdges>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticGlowEdgesConverter.CreateOpenXmlElement<DXO10D.ArtisticGlowEdges>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticLightScreen.
  /// </summary>
  private static DMD.ArtisticLightScreen? GetArtisticLightScreen(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticLightScreen>();
    if (element != null)
      return DMXD.ArtisticLightScreenConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticLightScreen(DXO10D.ImageEffect openXmlElement, DMD.ArtisticLightScreen? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticLightScreenConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticLightScreen>(), value, diffs, objName);
  }
  
  private static void SetArtisticLightScreen(DXO10D.ImageEffect openXmlElement, DMD.ArtisticLightScreen? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticLightScreen>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticLightScreenConverter.CreateOpenXmlElement<DXO10D.ArtisticLightScreen>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticLineDrawing.
  /// </summary>
  private static DMD.ArtisticLineDrawing? GetArtisticLineDrawing(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticLineDrawing>();
    if (element != null)
      return DMXD.ArtisticLineDrawingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticLineDrawing(DXO10D.ImageEffect openXmlElement, DMD.ArtisticLineDrawing? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticLineDrawingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticLineDrawing>(), value, diffs, objName);
  }
  
  private static void SetArtisticLineDrawing(DXO10D.ImageEffect openXmlElement, DMD.ArtisticLineDrawing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticLineDrawing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticLineDrawingConverter.CreateOpenXmlElement<DXO10D.ArtisticLineDrawing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticMarker.
  /// </summary>
  private static DMD.ArtisticMarker? GetArtisticMarker(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticMarker>();
    if (element != null)
      return DMXD.ArtisticMarkerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticMarker(DXO10D.ImageEffect openXmlElement, DMD.ArtisticMarker? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticMarkerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticMarker>(), value, diffs, objName);
  }
  
  private static void SetArtisticMarker(DXO10D.ImageEffect openXmlElement, DMD.ArtisticMarker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticMarker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticMarkerConverter.CreateOpenXmlElement<DXO10D.ArtisticMarker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticMosaicBubbles.
  /// </summary>
  private static DMD.ArtisticMosaicBubbles? GetArtisticMosaicBubbles(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticMosaicBubbles>();
    if (element != null)
      return DMXD.ArtisticMosaicBubblesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticMosaicBubbles(DXO10D.ImageEffect openXmlElement, DMD.ArtisticMosaicBubbles? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticMosaicBubblesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticMosaicBubbles>(), value, diffs, objName);
  }
  
  private static void SetArtisticMosaicBubbles(DXO10D.ImageEffect openXmlElement, DMD.ArtisticMosaicBubbles? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticMosaicBubbles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticMosaicBubblesConverter.CreateOpenXmlElement<DXO10D.ArtisticMosaicBubbles>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPaintStrokes.
  /// </summary>
  private static DMD.ArtisticPaintStrokes? GetArtisticPaintStrokes(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticPaintStrokes>();
    if (element != null)
      return DMXD.ArtisticPaintStrokesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticPaintStrokes(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPaintStrokes? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticPaintStrokesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticPaintStrokes>(), value, diffs, objName);
  }
  
  private static void SetArtisticPaintStrokes(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPaintStrokes? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticPaintStrokes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticPaintStrokesConverter.CreateOpenXmlElement<DXO10D.ArtisticPaintStrokes>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPaintBrush.
  /// </summary>
  private static DMD.ArtisticPaintBrush? GetArtisticPaintBrush(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticPaintBrush>();
    if (element != null)
      return DMXD.ArtisticPaintBrushConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticPaintBrush(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPaintBrush? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticPaintBrushConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticPaintBrush>(), value, diffs, objName);
  }
  
  private static void SetArtisticPaintBrush(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPaintBrush? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticPaintBrush>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticPaintBrushConverter.CreateOpenXmlElement<DXO10D.ArtisticPaintBrush>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPastelsSmooth.
  /// </summary>
  private static DMD.ArtisticPastelsSmooth? GetArtisticPastelsSmooth(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticPastelsSmooth>();
    if (element != null)
      return DMXD.ArtisticPastelsSmoothConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticPastelsSmooth(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPastelsSmooth? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticPastelsSmoothConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticPastelsSmooth>(), value, diffs, objName);
  }
  
  private static void SetArtisticPastelsSmooth(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPastelsSmooth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticPastelsSmooth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticPastelsSmoothConverter.CreateOpenXmlElement<DXO10D.ArtisticPastelsSmooth>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPencilGrayscale.
  /// </summary>
  private static DMD.ArtisticPencilGrayscale? GetArtisticPencilGrayscale(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticPencilGrayscale>();
    if (element != null)
      return DMXD.ArtisticPencilGrayscaleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticPencilGrayscale(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPencilGrayscale? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticPencilGrayscaleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticPencilGrayscale>(), value, diffs, objName);
  }
  
  private static void SetArtisticPencilGrayscale(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPencilGrayscale? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticPencilGrayscale>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticPencilGrayscaleConverter.CreateOpenXmlElement<DXO10D.ArtisticPencilGrayscale>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPencilSketch.
  /// </summary>
  private static DMD.ArtisticPencilSketch? GetArtisticPencilSketch(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticPencilSketch>();
    if (element != null)
      return DMXD.ArtisticPencilSketchConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticPencilSketch(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPencilSketch? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticPencilSketchConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticPencilSketch>(), value, diffs, objName);
  }
  
  private static void SetArtisticPencilSketch(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPencilSketch? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticPencilSketch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticPencilSketchConverter.CreateOpenXmlElement<DXO10D.ArtisticPencilSketch>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPhotocopy.
  /// </summary>
  private static DMD.ArtisticPhotocopy? GetArtisticPhotocopy(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticPhotocopy>();
    if (element != null)
      return DMXD.ArtisticPhotocopyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticPhotocopy(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPhotocopy? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticPhotocopyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticPhotocopy>(), value, diffs, objName);
  }
  
  private static void SetArtisticPhotocopy(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPhotocopy? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticPhotocopy>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticPhotocopyConverter.CreateOpenXmlElement<DXO10D.ArtisticPhotocopy>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPlasticWrap.
  /// </summary>
  private static DMD.ArtisticPlasticWrap? GetArtisticPlasticWrap(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticPlasticWrap>();
    if (element != null)
      return DMXD.ArtisticPlasticWrapConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticPlasticWrap(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPlasticWrap? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticPlasticWrapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticPlasticWrap>(), value, diffs, objName);
  }
  
  private static void SetArtisticPlasticWrap(DXO10D.ImageEffect openXmlElement, DMD.ArtisticPlasticWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticPlasticWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticPlasticWrapConverter.CreateOpenXmlElement<DXO10D.ArtisticPlasticWrap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticTexturizer.
  /// </summary>
  private static DMD.ArtisticTexturizer? GetArtisticTexturizer(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticTexturizer>();
    if (element != null)
      return DMXD.ArtisticTexturizerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticTexturizer(DXO10D.ImageEffect openXmlElement, DMD.ArtisticTexturizer? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticTexturizerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticTexturizer>(), value, diffs, objName);
  }
  
  private static void SetArtisticTexturizer(DXO10D.ImageEffect openXmlElement, DMD.ArtisticTexturizer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticTexturizer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticTexturizerConverter.CreateOpenXmlElement<DXO10D.ArtisticTexturizer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticWatercolorSponge.
  /// </summary>
  private static DMD.ArtisticWatercolorSponge? GetArtisticWatercolorSponge(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ArtisticWatercolorSponge>();
    if (element != null)
      return DMXD.ArtisticWatercolorSpongeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArtisticWatercolorSponge(DXO10D.ImageEffect openXmlElement, DMD.ArtisticWatercolorSponge? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArtisticWatercolorSpongeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ArtisticWatercolorSponge>(), value, diffs, objName);
  }
  
  private static void SetArtisticWatercolorSponge(DXO10D.ImageEffect openXmlElement, DMD.ArtisticWatercolorSponge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ArtisticWatercolorSponge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArtisticWatercolorSpongeConverter.CreateOpenXmlElement<DXO10D.ArtisticWatercolorSponge>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BackgroundRemoval.
  /// </summary>
  private static DMD.BackgroundRemoval? GetBackgroundRemoval(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.BackgroundRemoval>();
    if (element != null)
      return DMXD.BackgroundRemovalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundRemoval(DXO10D.ImageEffect openXmlElement, DMD.BackgroundRemoval? value, DiffList? diffs, string? objName)
  {
    return DMXD.BackgroundRemovalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.BackgroundRemoval>(), value, diffs, objName);
  }
  
  private static void SetBackgroundRemoval(DXO10D.ImageEffect openXmlElement, DMD.BackgroundRemoval? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.BackgroundRemoval>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BackgroundRemovalConverter.CreateOpenXmlElement<DXO10D.BackgroundRemoval>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BrightnessContrast.
  /// </summary>
  private static DMD.BrightnessContrast? GetBrightnessContrast(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.BrightnessContrast>();
    if (element != null)
      return DMXD.BrightnessContrastConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBrightnessContrast(DXO10D.ImageEffect openXmlElement, DMD.BrightnessContrast? value, DiffList? diffs, string? objName)
  {
    return DMXD.BrightnessContrastConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.BrightnessContrast>(), value, diffs, objName);
  }
  
  private static void SetBrightnessContrast(DXO10D.ImageEffect openXmlElement, DMD.BrightnessContrast? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.BrightnessContrast>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BrightnessContrastConverter.CreateOpenXmlElement<DXO10D.BrightnessContrast>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ColorTemperature.
  /// </summary>
  private static DMD.ColorTemperature? GetColorTemperature(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ColorTemperature>();
    if (element != null)
      return DMXD.ColorTemperatureConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorTemperature(DXO10D.ImageEffect openXmlElement, DMD.ColorTemperature? value, DiffList? diffs, string? objName)
  {
    return DMXD.ColorTemperatureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ColorTemperature>(), value, diffs, objName);
  }
  
  private static void SetColorTemperature(DXO10D.ImageEffect openXmlElement, DMD.ColorTemperature? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ColorTemperature>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorTemperatureConverter.CreateOpenXmlElement<DXO10D.ColorTemperature>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Saturation.
  /// </summary>
  private static DMD.Saturation2? GetSaturation(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.Saturation>();
    if (element != null)
      return DMXD.Saturation2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSaturation(DXO10D.ImageEffect openXmlElement, DMD.Saturation2? value, DiffList? diffs, string? objName)
  {
    return DMXD.Saturation2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.Saturation>(), value, diffs, objName);
  }
  
  private static void SetSaturation(DXO10D.ImageEffect openXmlElement, DMD.Saturation2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.Saturation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Saturation2Converter.CreateOpenXmlElement<DXO10D.Saturation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SharpenSoften.
  /// </summary>
  private static DMD.SharpenSoften? GetSharpenSoften(DXO10D.ImageEffect openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.SharpenSoften>();
    if (element != null)
      return DMXD.SharpenSoftenConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSharpenSoften(DXO10D.ImageEffect openXmlElement, DMD.SharpenSoften? value, DiffList? diffs, string? objName)
  {
    return DMXD.SharpenSoftenConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.SharpenSoften>(), value, diffs, objName);
  }
  
  private static void SetSharpenSoften(DXO10D.ImageEffect openXmlElement, DMD.SharpenSoften? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.SharpenSoften>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SharpenSoftenConverter.CreateOpenXmlElement<DXO10D.SharpenSoften>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ImageEffect? CreateModelElement(DXO10D.ImageEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ImageEffect();
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
  
  public static bool CompareModelElement(DXO10D.ImageEffect? openXmlElement, DMD.ImageEffect? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpArtisticBlur(openXmlElement, value.ArtisticBlur, diffs, objName))
        ok = false;
      if (!CmpArtisticCement(openXmlElement, value.ArtisticCement, diffs, objName))
        ok = false;
      if (!CmpArtisticChalkSketch(openXmlElement, value.ArtisticChalkSketch, diffs, objName))
        ok = false;
      if (!CmpArtisticCrisscrossEtching(openXmlElement, value.ArtisticCrisscrossEtching, diffs, objName))
        ok = false;
      if (!CmpArtisticCutout(openXmlElement, value.ArtisticCutout, diffs, objName))
        ok = false;
      if (!CmpArtisticFilmGrain(openXmlElement, value.ArtisticFilmGrain, diffs, objName))
        ok = false;
      if (!CmpArtisticGlass(openXmlElement, value.ArtisticGlass, diffs, objName))
        ok = false;
      if (!CmpArtisticGlowDiffused(openXmlElement, value.ArtisticGlowDiffused, diffs, objName))
        ok = false;
      if (!CmpArtisticGlowEdges(openXmlElement, value.ArtisticGlowEdges, diffs, objName))
        ok = false;
      if (!CmpArtisticLightScreen(openXmlElement, value.ArtisticLightScreen, diffs, objName))
        ok = false;
      if (!CmpArtisticLineDrawing(openXmlElement, value.ArtisticLineDrawing, diffs, objName))
        ok = false;
      if (!CmpArtisticMarker(openXmlElement, value.ArtisticMarker, diffs, objName))
        ok = false;
      if (!CmpArtisticMosaicBubbles(openXmlElement, value.ArtisticMosaicBubbles, diffs, objName))
        ok = false;
      if (!CmpArtisticPaintStrokes(openXmlElement, value.ArtisticPaintStrokes, diffs, objName))
        ok = false;
      if (!CmpArtisticPaintBrush(openXmlElement, value.ArtisticPaintBrush, diffs, objName))
        ok = false;
      if (!CmpArtisticPastelsSmooth(openXmlElement, value.ArtisticPastelsSmooth, diffs, objName))
        ok = false;
      if (!CmpArtisticPencilGrayscale(openXmlElement, value.ArtisticPencilGrayscale, diffs, objName))
        ok = false;
      if (!CmpArtisticPencilSketch(openXmlElement, value.ArtisticPencilSketch, diffs, objName))
        ok = false;
      if (!CmpArtisticPhotocopy(openXmlElement, value.ArtisticPhotocopy, diffs, objName))
        ok = false;
      if (!CmpArtisticPlasticWrap(openXmlElement, value.ArtisticPlasticWrap, diffs, objName))
        ok = false;
      if (!CmpArtisticTexturizer(openXmlElement, value.ArtisticTexturizer, diffs, objName))
        ok = false;
      if (!CmpArtisticWatercolorSponge(openXmlElement, value.ArtisticWatercolorSponge, diffs, objName))
        ok = false;
      if (!CmpBackgroundRemoval(openXmlElement, value.BackgroundRemoval, diffs, objName))
        ok = false;
      if (!CmpBrightnessContrast(openXmlElement, value.BrightnessContrast, diffs, objName))
        ok = false;
      if (!CmpColorTemperature(openXmlElement, value.ColorTemperature, diffs, objName))
        ok = false;
      if (!CmpSaturation(openXmlElement, value.Saturation, diffs, objName))
        ok = false;
      if (!CmpSharpenSoften(openXmlElement, value.SharpenSoften, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ImageEffect value)
    where OpenXmlElementType: DXO10D.ImageEffect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ImageEffect openXmlElement, DMD.ImageEffect value)
  {
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
  }
}
