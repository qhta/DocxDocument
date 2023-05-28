namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BlipExtension Class.
/// </summary>
public static class BlipExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.BlipExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.BlipExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.BlipExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMD.ImageProperties? GetImageProperties(DXD.BlipExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.ImageProperties>();
    if (element != null)
      return DMXD.ImagePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageProperties(DXD.BlipExtension openXmlElement, DMD.ImageProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ImagePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.ImageProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetImageProperties(DXD.BlipExtension openXmlElement, DMD.ImageProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.ImageProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ImagePropertiesConverter.CreateOpenXmlElement<DXO10D.ImageProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetUseLocalDpi(DXD.BlipExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10D.UseLocalDpi>() != null;
  }
  
  private static bool CmpUseLocalDpi(DXD.BlipExtension openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO10D.UseLocalDpi>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10D.UseLocalDpi", val, value);
    return false;
  }
  
  private static void SetUseLocalDpi(DXD.BlipExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10D.UseLocalDpi>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10D.UseLocalDpi();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDW.WebVideoProperty? GetWebVideoProperty(DXD.BlipExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13WD.WebVideoProperty>();
    if (element != null)
      return DMXDW.WebVideoPropertyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebVideoProperty(DXD.BlipExtension openXmlElement, DMDW.WebVideoProperty? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.WebVideoPropertyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13WD.WebVideoProperty>(), value, diffs, objName, propName);
  }
  
  private static void SetWebVideoProperty(DXD.BlipExtension openXmlElement, DMDW.WebVideoProperty? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13WD.WebVideoProperty>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.WebVideoPropertyConverter.CreateOpenXmlElement<DXO13WD.WebVideoProperty>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDSVG.SVGBlip? GetSVGBlip(DXD.BlipExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO19DSVG.SVGBlip>();
    if (element != null)
      return DMXDSVG.SVGBlipConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSVGBlip(DXD.BlipExtension openXmlElement, DMDSVG.SVGBlip? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDSVG.SVGBlipConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO19DSVG.SVGBlip>(), value, diffs, objName, propName);
  }
  
  private static void SetSVGBlip(DXD.BlipExtension openXmlElement, DMDSVG.SVGBlip? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO19DSVG.SVGBlip>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDSVG.SVGBlipConverter.CreateOpenXmlElement<DXO19DSVG.SVGBlip>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PictureAttributionSourceURL? GetPictureAttributionSourceURL(DXD.BlipExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO19D.PictureAttributionSourceURL>();
    if (element != null)
      return DMXD.PictureAttributionSourceURLConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureAttributionSourceURL(DXD.BlipExtension openXmlElement, DMD.PictureAttributionSourceURL? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PictureAttributionSourceURLConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO19D.PictureAttributionSourceURL>(), value, diffs, objName, propName);
  }
  
  private static void SetPictureAttributionSourceURL(DXD.BlipExtension openXmlElement, DMD.PictureAttributionSourceURL? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO19D.PictureAttributionSourceURL>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PictureAttributionSourceURLConverter.CreateOpenXmlElement<DXO19D.PictureAttributionSourceURL>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMWOE.OEmbed? GetOEmbed(DXD.BlipExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOSWY20OE.OEmbed>();
    if (element != null)
      return DMXWOE.OEmbedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOEmbed(DXD.BlipExtension openXmlElement, DMWOE.OEmbed? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXWOE.OEmbedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOSWY20OE.OEmbed>(), value, diffs, objName, propName);
  }
  
  private static void SetOEmbed(DXD.BlipExtension openXmlElement, DMWOE.OEmbed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOSWY20OE.OEmbed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWOE.OEmbedConverter.CreateOpenXmlElement<DXOSWY20OE.OEmbed>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDOOE.OEmbedShared? GetOEmbedShared(DXD.BlipExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODY21OE.OEmbedShared>();
    if (element != null)
      return DMXDOOEmb.OEmbedSharedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOEmbedShared(DXD.BlipExtension openXmlElement, DMDOOE.OEmbedShared? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDOOEmb.OEmbedSharedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODY21OE.OEmbedShared>(), value, diffs, objName, propName);
  }
  
  private static void SetOEmbedShared(DXD.BlipExtension openXmlElement, DMDOOE.OEmbedShared? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODY21OE.OEmbedShared>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDOOEmb.OEmbedSharedConverter.CreateOpenXmlElement<DXODY21OE.OEmbedShared>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.BlipExtension? CreateModelElement(DXD.BlipExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.BlipExtension();
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
  
  public static bool CompareModelElement(DXD.BlipExtension? openXmlElement, DMD.BlipExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpImageProperties(openXmlElement, value.ImageProperties, diffs, objName, propName))
        ok = false;
      if (!CmpUseLocalDpi(openXmlElement, value.UseLocalDpi, diffs, objName, propName))
        ok = false;
      if (!CmpWebVideoProperty(openXmlElement, value.WebVideoProperty, diffs, objName, propName))
        ok = false;
      if (!CmpSVGBlip(openXmlElement, value.SVGBlip, diffs, objName, propName))
        ok = false;
      if (!CmpPictureAttributionSourceURL(openXmlElement, value.PictureAttributionSourceURL, diffs, objName, propName))
        ok = false;
      if (!CmpOEmbed(openXmlElement, value.OEmbed, diffs, objName, propName))
        ok = false;
      if (!CmpOEmbedShared(openXmlElement, value.OEmbedShared, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BlipExtension value)
    where OpenXmlElementType: DXD.BlipExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.BlipExtension openXmlElement, DMD.BlipExtension value)
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
