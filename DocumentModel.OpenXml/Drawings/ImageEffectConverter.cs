using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentModel.Drawings;
using ArtisticBlur = DocumentModel.Drawings.ArtisticBlur;
using ArtisticCement = DocumentModel.Drawings.ArtisticCement;
using ArtisticChalkSketch = DocumentModel.Drawings.ArtisticChalkSketch;
using ArtisticCrisscrossEtching = DocumentModel.Drawings.ArtisticCrisscrossEtching;
using ArtisticCutout = DocumentModel.Drawings.ArtisticCutout;
using ArtisticFilmGrain = DocumentModel.Drawings.ArtisticFilmGrain;
using ArtisticGlass = DocumentModel.Drawings.ArtisticGlass;
using ArtisticGlowDiffused = DocumentModel.Drawings.ArtisticGlowDiffused;
using ArtisticGlowEdges = DocumentModel.Drawings.ArtisticGlowEdges;
using ArtisticLightScreen = DocumentModel.Drawings.ArtisticLightScreen;
using ArtisticLineDrawing = DocumentModel.Drawings.ArtisticLineDrawing;
using ArtisticMarker = DocumentModel.Drawings.ArtisticMarker;
using ArtisticMosaicBubbles = DocumentModel.Drawings.ArtisticMosaicBubbles;
using ArtisticPaintBrush = DocumentModel.Drawings.ArtisticPaintBrush;
using ArtisticPaintStrokes = DocumentModel.Drawings.ArtisticPaintStrokes;
using ArtisticPastelsSmooth = DocumentModel.Drawings.ArtisticPastelsSmooth;
using ArtisticPencilGrayscale = DocumentModel.Drawings.ArtisticPencilGrayscale;
using ArtisticPencilSketch = DocumentModel.Drawings.ArtisticPencilSketch;
using ArtisticPhotocopy = DocumentModel.Drawings.ArtisticPhotocopy;
using ArtisticPlasticWrap = DocumentModel.Drawings.ArtisticPlasticWrap;
using ArtisticTexturizer = DocumentModel.Drawings.ArtisticTexturizer;
using ArtisticWatercolorSponge = DocumentModel.Drawings.ArtisticWatercolorSponge;
using BackgroundRemoval = DocumentModel.Drawings.BackgroundRemoval;
using BrightnessContrast = DocumentModel.Drawings.BrightnessContrast;
using ColorTemperature = DocumentModel.Drawings.ColorTemperature;
using ImageEffect = DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect;
using SharpenSoften = DocumentModel.Drawings.SharpenSoften;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ImageEffect Class.
/// </summary>
public static class ImageEffectConverter
{
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(ImageEffect? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }

  public static void SetVisible(ImageEffect? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }

  /// <summary>
  ///   ArtisticBlur.
  /// </summary>
  public static ArtisticBlur? GetArtisticBlur(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>();
    if (itemElement != null)
      return ArtisticBlurConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticBlur(ImageEffect? openXmlElement, ArtisticBlur? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticBlurConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticCement.
  /// </summary>
  public static ArtisticCement? GetArtisticCement(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>();
    if (itemElement != null)
      return ArtisticCementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticCement(ImageEffect? openXmlElement, ArtisticCement? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticCementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticChalkSketch.
  /// </summary>
  public static ArtisticChalkSketch? GetArtisticChalkSketch(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>();
    if (itemElement != null)
      return ArtisticChalkSketchConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticChalkSketch(ImageEffect? openXmlElement, ArtisticChalkSketch? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticChalkSketchConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticCrisscrossEtching.
  /// </summary>
  public static ArtisticCrisscrossEtching? GetArtisticCrisscrossEtching(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>();
    if (itemElement != null)
      return ArtisticCrisscrossEtchingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticCrisscrossEtching(ImageEffect? openXmlElement, ArtisticCrisscrossEtching? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticCrisscrossEtchingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticCutout.
  /// </summary>
  public static ArtisticCutout? GetArtisticCutout(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>();
    if (itemElement != null)
      return ArtisticCutoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticCutout(ImageEffect? openXmlElement, ArtisticCutout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticCutoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticFilmGrain.
  /// </summary>
  public static ArtisticFilmGrain? GetArtisticFilmGrain(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>();
    if (itemElement != null)
      return ArtisticFilmGrainConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticFilmGrain(ImageEffect? openXmlElement, ArtisticFilmGrain? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticFilmGrainConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticGlass.
  /// </summary>
  public static ArtisticGlass? GetArtisticGlass(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>();
    if (itemElement != null)
      return ArtisticGlassConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticGlass(ImageEffect? openXmlElement, ArtisticGlass? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticGlassConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticGlowDiffused.
  /// </summary>
  public static ArtisticGlowDiffused? GetArtisticGlowDiffused(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>();
    if (itemElement != null)
      return ArtisticGlowDiffusedConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticGlowDiffused(ImageEffect? openXmlElement, ArtisticGlowDiffused? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticGlowDiffusedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticGlowEdges.
  /// </summary>
  public static ArtisticGlowEdges? GetArtisticGlowEdges(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>();
    if (itemElement != null)
      return ArtisticGlowEdgesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticGlowEdges(ImageEffect? openXmlElement, ArtisticGlowEdges? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticGlowEdgesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticLightScreen.
  /// </summary>
  public static ArtisticLightScreen? GetArtisticLightScreen(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>();
    if (itemElement != null)
      return ArtisticLightScreenConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticLightScreen(ImageEffect? openXmlElement, ArtisticLightScreen? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticLightScreenConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticLineDrawing.
  /// </summary>
  public static ArtisticLineDrawing? GetArtisticLineDrawing(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>();
    if (itemElement != null)
      return ArtisticLineDrawingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticLineDrawing(ImageEffect? openXmlElement, ArtisticLineDrawing? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticLineDrawingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticMarker.
  /// </summary>
  public static ArtisticMarker? GetArtisticMarker(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>();
    if (itemElement != null)
      return ArtisticMarkerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticMarker(ImageEffect? openXmlElement, ArtisticMarker? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticMarkerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticMosaicBubbles.
  /// </summary>
  public static ArtisticMosaicBubbles? GetArtisticMosaicBubbles(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>();
    if (itemElement != null)
      return ArtisticMosaicBubblesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticMosaicBubbles(ImageEffect? openXmlElement, ArtisticMosaicBubbles? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticMosaicBubblesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticPaintStrokes.
  /// </summary>
  public static ArtisticPaintStrokes? GetArtisticPaintStrokes(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>();
    if (itemElement != null)
      return ArtisticPaintStrokesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticPaintStrokes(ImageEffect? openXmlElement, ArtisticPaintStrokes? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPaintStrokesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticPaintBrush.
  /// </summary>
  public static ArtisticPaintBrush? GetArtisticPaintBrush(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>();
    if (itemElement != null)
      return ArtisticPaintBrushConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticPaintBrush(ImageEffect? openXmlElement, ArtisticPaintBrush? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPaintBrushConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticPastelsSmooth.
  /// </summary>
  public static ArtisticPastelsSmooth? GetArtisticPastelsSmooth(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>();
    if (itemElement != null)
      return ArtisticPastelsSmoothConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticPastelsSmooth(ImageEffect? openXmlElement, ArtisticPastelsSmooth? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPastelsSmoothConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticPencilGrayscale.
  /// </summary>
  public static ArtisticPencilGrayscale? GetArtisticPencilGrayscale(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>();
    if (itemElement != null)
      return ArtisticPencilGrayscaleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticPencilGrayscale(ImageEffect? openXmlElement, ArtisticPencilGrayscale? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPencilGrayscaleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticPencilSketch.
  /// </summary>
  public static ArtisticPencilSketch? GetArtisticPencilSketch(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>();
    if (itemElement != null)
      return ArtisticPencilSketchConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticPencilSketch(ImageEffect? openXmlElement, ArtisticPencilSketch? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPencilSketchConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticPhotocopy.
  /// </summary>
  public static ArtisticPhotocopy? GetArtisticPhotocopy(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>();
    if (itemElement != null)
      return ArtisticPhotocopyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticPhotocopy(ImageEffect? openXmlElement, ArtisticPhotocopy? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPhotocopyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticPlasticWrap.
  /// </summary>
  public static ArtisticPlasticWrap? GetArtisticPlasticWrap(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>();
    if (itemElement != null)
      return ArtisticPlasticWrapConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticPlasticWrap(ImageEffect? openXmlElement, ArtisticPlasticWrap? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticPlasticWrapConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticTexturizer.
  /// </summary>
  public static ArtisticTexturizer? GetArtisticTexturizer(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>();
    if (itemElement != null)
      return ArtisticTexturizerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticTexturizer(ImageEffect? openXmlElement, ArtisticTexturizer? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticTexturizerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ArtisticWatercolorSponge.
  /// </summary>
  public static ArtisticWatercolorSponge? GetArtisticWatercolorSponge(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>();
    if (itemElement != null)
      return ArtisticWatercolorSpongeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArtisticWatercolorSponge(ImageEffect? openXmlElement, ArtisticWatercolorSponge? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArtisticWatercolorSpongeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   BackgroundRemoval.
  /// </summary>
  public static BackgroundRemoval? GetBackgroundRemoval(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>();
    if (itemElement != null)
      return BackgroundRemovalConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackgroundRemoval(ImageEffect? openXmlElement, BackgroundRemoval? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundRemovalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   BrightnessContrast.
  /// </summary>
  public static BrightnessContrast? GetBrightnessContrast(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>();
    if (itemElement != null)
      return BrightnessContrastConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBrightnessContrast(ImageEffect? openXmlElement, BrightnessContrast? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BrightnessContrastConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ColorTemperature.
  /// </summary>
  public static ColorTemperature? GetColorTemperature(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>();
    if (itemElement != null)
      return ColorTemperatureConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorTemperature(ImageEffect? openXmlElement, ColorTemperature? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorTemperatureConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Saturation.
  /// </summary>
  public static Saturation2? GetSaturation(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Saturation>();
    if (itemElement != null)
      return Saturation2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSaturation(ImageEffect? openXmlElement, Saturation2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Saturation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Saturation2Converter.CreateOpenXmlElement<Saturation>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SharpenSoften.
  /// </summary>
  public static SharpenSoften? GetSharpenSoften(ImageEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>();
    if (itemElement != null)
      return SharpenSoftenConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSharpenSoften(ImageEffect? openXmlElement, SharpenSoften? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SharpenSoftenConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ImageEffect? CreateModelElement(ImageEffect? openXmlElement)
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
    where OpenXmlElementType : ImageEffect, new()
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