namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ImageEffect Class.
/// </summary>
public static class ImageEffectConverter
{
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// ArtisticBlur.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticBlur? GetArtisticBlur(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticBlurConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticBlur(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticBlur? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticCement.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticCement? GetArtisticCement(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticCementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticCement(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticCement? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticChalkSketch.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticChalkSketch? GetArtisticChalkSketch(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticChalkSketchConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticChalkSketch(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticChalkSketch? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticCrisscrossEtching.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticCrisscrossEtching? GetArtisticCrisscrossEtching(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticCrisscrossEtchingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticCrisscrossEtching(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticCrisscrossEtching? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticCutout.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticCutout? GetArtisticCutout(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticCutoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticCutout(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticCutout? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticFilmGrain.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticFilmGrain? GetArtisticFilmGrain(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticFilmGrainConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticFilmGrain(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticFilmGrain? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticGlass.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticGlass? GetArtisticGlass(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticGlassConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticGlass(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticGlass? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticGlowDiffused.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticGlowDiffused? GetArtisticGlowDiffused(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticGlowDiffusedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticGlowDiffused(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticGlowDiffused? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticGlowEdges.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticGlowEdges? GetArtisticGlowEdges(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticGlowEdgesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticGlowEdges(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticGlowEdges? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticLightScreen.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticLightScreen? GetArtisticLightScreen(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticLightScreenConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticLightScreen(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticLightScreen? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticLineDrawing.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticLineDrawing? GetArtisticLineDrawing(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticLineDrawingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticLineDrawing(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticLineDrawing? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticMarker.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticMarker? GetArtisticMarker(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticMarkerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticMarker(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticMarker? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticMosaicBubbles.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticMosaicBubbles? GetArtisticMosaicBubbles(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticMosaicBubblesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticMosaicBubbles(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticMosaicBubbles? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticPaintStrokes.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticPaintStrokes? GetArtisticPaintStrokes(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPaintStrokesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticPaintStrokes(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticPaintStrokes? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticPaintBrush.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticPaintBrush? GetArtisticPaintBrush(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPaintBrushConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticPaintBrush(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticPaintBrush? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticPastelsSmooth.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticPastelsSmooth? GetArtisticPastelsSmooth(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPastelsSmoothConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticPastelsSmooth(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticPastelsSmooth? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticPencilGrayscale.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticPencilGrayscale? GetArtisticPencilGrayscale(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPencilGrayscaleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticPencilGrayscale(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticPencilGrayscale? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticPencilSketch.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticPencilSketch? GetArtisticPencilSketch(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPencilSketchConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticPencilSketch(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticPencilSketch? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticPhotocopy.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticPhotocopy? GetArtisticPhotocopy(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPhotocopyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticPhotocopy(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticPhotocopy? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticPlasticWrap.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticPlasticWrap? GetArtisticPlasticWrap(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticPlasticWrapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticPlasticWrap(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticPlasticWrap? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticTexturizer.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticTexturizer? GetArtisticTexturizer(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticTexturizerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticTexturizer(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticTexturizer? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ArtisticWatercolorSponge.
  /// </summary>
  public static DocumentModel.Drawings.ArtisticWatercolorSponge? GetArtisticWatercolorSponge(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ArtisticWatercolorSpongeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArtisticWatercolorSponge(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ArtisticWatercolorSponge? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// BackgroundRemoval.
  /// </summary>
  public static DocumentModel.Drawings.BackgroundRemoval? GetBackgroundRemoval(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackgroundRemovalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackgroundRemoval(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.BackgroundRemoval? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// BrightnessContrast.
  /// </summary>
  public static DocumentModel.Drawings.BrightnessContrast? GetBrightnessContrast(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BrightnessContrastConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBrightnessContrast(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.BrightnessContrast? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ColorTemperature.
  /// </summary>
  public static DocumentModel.Drawings.ColorTemperature? GetColorTemperature(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorTemperatureConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorTemperature(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.ColorTemperature? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Saturation.
  /// </summary>
  public static DocumentModel.Drawings.Saturation2? GetSaturation(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Saturation>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Saturation2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSaturation(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.Saturation2? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// SharpenSoften.
  /// </summary>
  public static DocumentModel.Drawings.SharpenSoften? GetSharpenSoften(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SharpenSoftenConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSharpenSoften(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect? openXmlElement, DocumentModel.Drawings.SharpenSoften? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
