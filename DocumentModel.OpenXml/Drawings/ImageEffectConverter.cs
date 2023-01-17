namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ImageEffect Class.
/// </summary>
public static class ImageEffectConverter
{
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// ArtisticBlur.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticBlur? GetArtisticBlur(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticBlurConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticBlur(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticBlur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticBlurConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticCement.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticCement? GetArtisticCement(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticCementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticCement(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticCement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticCementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticChalkSketch.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticChalkSketch? GetArtisticChalkSketch(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticChalkSketchConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticChalkSketch(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticChalkSketch? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticChalkSketchConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticCrisscrossEtching.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticCrisscrossEtching? GetArtisticCrisscrossEtching(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticCrisscrossEtchingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticCrisscrossEtching(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticCrisscrossEtching? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticCrisscrossEtchingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticCutout.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticCutout? GetArtisticCutout(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticCutoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticCutout(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticCutout? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticCutoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticFilmGrain.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticFilmGrain? GetArtisticFilmGrain(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticFilmGrainConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticFilmGrain(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticFilmGrain? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticFilmGrainConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticGlass.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticGlass? GetArtisticGlass(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticGlassConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticGlass(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticGlass? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticGlassConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticGlowDiffused.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticGlowDiffused? GetArtisticGlowDiffused(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticGlowDiffusedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticGlowDiffused(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticGlowDiffused? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticGlowDiffusedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticGlowEdges.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticGlowEdges? GetArtisticGlowEdges(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticGlowEdgesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticGlowEdges(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticGlowEdges? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticGlowEdgesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticLightScreen.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticLightScreen? GetArtisticLightScreen(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticLightScreenConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticLightScreen(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticLightScreen? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticLightScreenConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticLineDrawing.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticLineDrawing? GetArtisticLineDrawing(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticLineDrawingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticLineDrawing(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticLineDrawing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticLineDrawingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticMarker.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticMarker? GetArtisticMarker(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticMarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticMarker(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticMarker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticMarkerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticMosaicBubbles.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticMosaicBubbles? GetArtisticMosaicBubbles(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticMosaicBubblesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticMosaicBubbles(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticMosaicBubbles? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticMosaicBubblesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPaintStrokes.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticPaintStrokes? GetArtisticPaintStrokes(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPaintStrokesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPaintStrokes(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticPaintStrokes? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticPaintStrokesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPaintBrush.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticPaintBrush? GetArtisticPaintBrush(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPaintBrushConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPaintBrush(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticPaintBrush? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticPaintBrushConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPastelsSmooth.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticPastelsSmooth? GetArtisticPastelsSmooth(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPastelsSmoothConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPastelsSmooth(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticPastelsSmooth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticPastelsSmoothConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPencilGrayscale.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticPencilGrayscale? GetArtisticPencilGrayscale(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPencilGrayscaleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPencilGrayscale(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticPencilGrayscale? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticPencilGrayscaleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPencilSketch.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticPencilSketch? GetArtisticPencilSketch(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPencilSketchConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPencilSketch(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticPencilSketch? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticPencilSketchConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPhotocopy.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticPhotocopy? GetArtisticPhotocopy(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPhotocopyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPhotocopy(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticPhotocopy? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticPhotocopyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticPlasticWrap.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticPlasticWrap? GetArtisticPlasticWrap(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPlasticWrapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticPlasticWrap(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticPlasticWrap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticPlasticWrapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticTexturizer.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticTexturizer? GetArtisticTexturizer(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticTexturizerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticTexturizer(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticTexturizer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticTexturizerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ArtisticWatercolorSponge.
  /// </summary>
  private static DocumentModel.Drawings.ArtisticWatercolorSponge? GetArtisticWatercolorSponge(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticWatercolorSpongeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArtisticWatercolorSponge(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ArtisticWatercolorSponge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ArtisticWatercolorSpongeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BackgroundRemoval.
  /// </summary>
  private static DocumentModel.Drawings.BackgroundRemoval? GetBackgroundRemoval(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackgroundRemovalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackgroundRemoval(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.BackgroundRemoval? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BackgroundRemovalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BrightnessContrast.
  /// </summary>
  private static DocumentModel.Drawings.BrightnessContrast? GetBrightnessContrast(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BrightnessContrastConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBrightnessContrast(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.BrightnessContrast? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BrightnessContrastConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ColorTemperature.
  /// </summary>
  private static DocumentModel.Drawings.ColorTemperature? GetColorTemperature(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorTemperatureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorTemperature(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.ColorTemperature? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ColorTemperatureConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Saturation.
  /// </summary>
  private static DocumentModel.Drawings.Saturation2? GetSaturation(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Saturation>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Saturation2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSaturation(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.Saturation2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Saturation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Saturation2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.Saturation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SharpenSoften.
  /// </summary>
  private static DocumentModel.Drawings.SharpenSoften? GetSharpenSoften(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SharpenSoftenConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSharpenSoften(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect openXmlElement, DocumentModel.Drawings.SharpenSoften? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.SharpenSoftenConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ImageEffect? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ImageEffect? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect, new()
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
