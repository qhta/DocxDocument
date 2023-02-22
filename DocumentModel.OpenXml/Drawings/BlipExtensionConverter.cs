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
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDraw.BlipExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDraw.BlipExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDraws.ImageProperties? GetImageProperties(DXDraw.BlipExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.ImageProperties>();
    if (element != null)
      return DMXDraws.ImagePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageProperties(DXDraw.BlipExtension openXmlElement, DMDraws.ImageProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ImagePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.ImageProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXO2010Draw.UseLocalDpi>() != null;
  }
  
  private static bool CmpUseLocalDpi(DXDraw.BlipExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2010Draw.UseLocalDpi>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2010Draw.UseLocalDpi", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXO2013WDraw.WebVideoProperty>();
    if (element != null)
      return DMXDrawsW.WebVideoPropertyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebVideoProperty(DXDraw.BlipExtension openXmlElement, DMDrawsW.WebVideoProperty? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.WebVideoPropertyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013WDraw.WebVideoProperty>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2019DrawSVG.SVGBlip>();
    if (element != null)
      return DMXDrawsSVG.SVGBlipConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSVGBlip(DXDraw.BlipExtension openXmlElement, DMDrawsSVG.SVGBlip? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsSVG.SVGBlipConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2019DrawSVG.SVGBlip>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2019Draw.PictureAttributionSourceURL>();
    if (element != null)
      return DMXDraws.PictureAttributionSourceURLConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureAttributionSourceURL(DXDraw.BlipExtension openXmlElement, DMDraws.PictureAttributionSourceURL? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PictureAttributionSourceURLConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2019Draw.PictureAttributionSourceURL>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXOWY2020OEmb.OEmbed>();
    if (element != null)
      return DMXWOEmb.OEmbedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOEmbed(DXDraw.BlipExtension openXmlElement, DMWOEmb.OEmbed? value, DiffList? diffs, string? objName)
  {
    return DMXWOEmb.OEmbedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOWY2020OEmb.OEmbed>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXODrawY2021OEmb.OEmbedShared>();
    if (element != null)
      return DMXDrawsOOEmb.OEmbedSharedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOEmbedShared(DXDraw.BlipExtension openXmlElement, DMDrawsOOEmb.OEmbedShared? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsOOEmb.OEmbedSharedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODrawY2021OEmb.OEmbedShared>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.BlipExtension? CreateModelElement(DXDraw.BlipExtension? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.BlipExtension? openXmlElement, DMDraws.BlipExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpImageProperties(openXmlElement, value.ImageProperties, diffs, objName))
        ok = false;
      if (!CmpUseLocalDpi(openXmlElement, value.UseLocalDpi, diffs, objName))
        ok = false;
      if (!CmpWebVideoProperty(openXmlElement, value.WebVideoProperty, diffs, objName))
        ok = false;
      if (!CmpSVGBlip(openXmlElement, value.SVGBlip, diffs, objName))
        ok = false;
      if (!CmpPictureAttributionSourceURL(openXmlElement, value.PictureAttributionSourceURL, diffs, objName))
        ok = false;
      if (!CmpOEmbed(openXmlElement, value.OEmbed, diffs, objName))
        ok = false;
      if (!CmpOEmbedShared(openXmlElement, value.OEmbedShared, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BlipExtension value)
    where OpenXmlElementType: DXDraw.BlipExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.BlipExtension openXmlElement, DMDraws.BlipExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetImageProperties(openXmlElement, value?.ImageProperties);
    SetUseLocalDpi(openXmlElement, value?.UseLocalDpi);
    SetWebVideoProperty(openXmlElement, value?.WebVideoProperty);
    SetSVGBlip(openXmlElement, value?.SVGBlip);
    SetPictureAttributionSourceURL(openXmlElement, value?.PictureAttributionSourceURL);
    SetOEmbed(openXmlElement, value?.OEmbed);
    SetOEmbedShared(openXmlElement, value?.OEmbedShared);
    }
  }
