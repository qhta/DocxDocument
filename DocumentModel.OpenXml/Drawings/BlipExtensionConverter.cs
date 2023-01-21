namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BlipExtension Class.
/// </summary>
public static class BlipExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.BlipExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.BlipExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDraws.ImageProperties? GetImageProperties(DXDraw.BlipExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ImageProperties>();
    if (itemElement != null)
      return DMXDraws.ImagePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageProperties(DXDraw.BlipExtension openXmlElement, DMDraws.ImageProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ImageProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ImagePropertiesConverter.CreateOpenXmlElement<DXO2010Draw.ImageProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetUseLocalDpi(DXDraw.BlipExtension openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.UseLocalDpi>();
    return itemElement != null;
  }
  
  private static void SetUseLocalDpi(DXDraw.BlipExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.UseLocalDpi>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010Draw.UseLocalDpi();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsW.WebVideoProperty? GetWebVideoProperty(DXDraw.BlipExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013WDraw.WebVideoProperty>();
    if (itemElement != null)
      return DMXDrawsW.WebVideoPropertyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWebVideoProperty(DXDraw.BlipExtension openXmlElement, DMDrawsW.WebVideoProperty? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WDraw.WebVideoProperty>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.WebVideoPropertyConverter.CreateOpenXmlElement<DXO2013WDraw.WebVideoProperty>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsSVG.SVGBlip? GetSVGBlip(DXDraw.BlipExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2019DrawSVG.SVGBlip>();
    if (itemElement != null)
      return DMXDrawsSVG.SVGBlipConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSVGBlip(DXDraw.BlipExtension openXmlElement, DMDrawsSVG.SVGBlip? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2019DrawSVG.SVGBlip>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsSVG.SVGBlipConverter.CreateOpenXmlElement<DXO2019DrawSVG.SVGBlip>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PictureAttributionSourceURL? GetPictureAttributionSourceURL(DXDraw.BlipExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2019Draw.PictureAttributionSourceURL>();
    if (itemElement != null)
      return DMXDraws.PictureAttributionSourceURLConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureAttributionSourceURL(DXDraw.BlipExtension openXmlElement, DMDraws.PictureAttributionSourceURL? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2019Draw.PictureAttributionSourceURL>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PictureAttributionSourceURLConverter.CreateOpenXmlElement<DXO2019Draw.PictureAttributionSourceURL>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMWOEmb.OEmbed? GetOEmbed(DXDraw.BlipExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOWY2020OEmb.OEmbed>();
    if (itemElement != null)
      return DMXWOEmb.OEmbedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOEmbed(DXDraw.BlipExtension openXmlElement, DMWOEmb.OEmbed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOWY2020OEmb.OEmbed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWOEmb.OEmbedConverter.CreateOpenXmlElement<DXOWY2020OEmb.OEmbed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsOOEmb.OEmbedShared? GetOEmbedShared(DXDraw.BlipExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODrawY2021OEmb.OEmbedShared>();
    if (itemElement != null)
      return DMXDrawsOOEmb.OEmbedSharedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOEmbedShared(DXDraw.BlipExtension openXmlElement, DMDrawsOOEmb.OEmbedShared? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODrawY2021OEmb.OEmbedShared>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsOOEmb.OEmbedSharedConverter.CreateOpenXmlElement<DXODrawY2021OEmb.OEmbedShared>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.BlipExtension? CreateModelElement(DXDraw.BlipExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BlipExtension();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BlipExtension? value)
    where OpenXmlElementType: DXDraw.BlipExtension, new()
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
