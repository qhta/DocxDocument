using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentModel.Drawings;
using DocumentModel.Drawings.Office.OEmbed;
using DocumentModel.Drawings.SVG;
using DocumentModel.Drawings.Wordprocessing;
using DocumentModel.OpenXml.Drawings.Office.OEmbed;
using DocumentModel.OpenXml.Drawings.SVG;
using DocumentModel.OpenXml.Drawings.Wordprocessing;
using DocumentModel.OpenXml.Wordprocessing.OEmbed;
using DocumentModel.Wordprocessing.OEmbed;
using BlipExtension = DocumentFormat.OpenXml.Drawing.BlipExtension;
using ImageProperties = DocumentModel.Drawings.ImageProperties;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the BlipExtension Class.
/// </summary>
public static class BlipExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(BlipExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(BlipExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static ImageProperties? GetImageProperties(BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties>();
    if (itemElement != null)
      return ImagePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageProperties(BlipExtension? openXmlElement, ImageProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImagePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetUseLocalDpi(BlipExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UseLocalDpi>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUseLocalDpi(BlipExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UseLocalDpi>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UseLocalDpi();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static WebVideoProperty? GetWebVideoProperty(BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty>();
    if (itemElement != null)
      return WebVideoPropertyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWebVideoProperty(BlipExtension? openXmlElement, WebVideoProperty? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebVideoPropertyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.Drawing.WebVideoProperty>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SVGBlip? GetSVGBlip(BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip>();
    if (itemElement != null)
      return SVGBlipConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSVGBlip(BlipExtension? openXmlElement, SVGBlip? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SVGBlipConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PictureAttributionSourceURL? GetPictureAttributionSourceURL(BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL>();
    if (itemElement != null)
      return PictureAttributionSourceURLConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPictureAttributionSourceURL(BlipExtension? openXmlElement, PictureAttributionSourceURL? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureAttributionSourceURLConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OEmbed? GetOEmbed(BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed>();
    if (itemElement != null)
      return OEmbedConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOEmbed(BlipExtension? openXmlElement, OEmbed? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OEmbedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed.OEmbed>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OEmbedShared? GetOEmbedShared(BlipExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared>();
    if (itemElement != null)
      return OEmbedSharedConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOEmbedShared(BlipExtension? openXmlElement, OEmbedShared? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OEmbedSharedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.BlipExtension? CreateModelElement(BlipExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BlipExtension();
      value.Uri = GetUri(openXmlElement);
      value.ImageProperties = GetImageProperties(openXmlElement);
      value.UseLocalDpi = GetUseLocalDpi(openXmlElement);
      value.WebVideoProperty = GetWebVideoProperty(openXmlElement);
      value.SVGBlip = GetSVGBlip(openXmlElement);
      value.PictureAttributionSourceURL = GetPictureAttributionSourceURL(openXmlElement);
      value.OEmbed = GetOEmbed(openXmlElement);
      value.OEmbedShared = GetOEmbedShared(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BlipExtension? value)
    where OpenXmlElementType : BlipExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetImageProperties(openXmlElement, value?.ImageProperties);
      SetUseLocalDpi(openXmlElement, value?.UseLocalDpi);
      SetWebVideoProperty(openXmlElement, value?.WebVideoProperty);
      SetSVGBlip(openXmlElement, value?.SVGBlip);
      SetPictureAttributionSourceURL(openXmlElement, value?.PictureAttributionSourceURL);
      SetOEmbed(openXmlElement, value?.OEmbed);
      SetOEmbedShared(openXmlElement, value?.OEmbedShared);
      return openXmlElement;
    }
    return default;
  }
}