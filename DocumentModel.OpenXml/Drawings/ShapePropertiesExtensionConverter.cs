namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
public static class ShapePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDraw.ShapePropertiesExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDraw.ShapePropertiesExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDraws.HiddenFillProperties? GetHiddenFillProperties(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.HiddenFillProperties>();
    if (element != null)
      return DMXDraws.HiddenFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiddenFillProperties(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenFillProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HiddenFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.HiddenFillProperties>(), value, diffs, objName);
  }
  
  private static void SetHiddenFillProperties(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.HiddenFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HiddenFillPropertiesConverter.CreateOpenXmlElement<DXO2010Draw.HiddenFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HiddenLineProperties? GetHiddenLineProperties(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.HiddenLineProperties>();
    if (element != null)
      return DMXDraws.HiddenLinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiddenLineProperties(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenLineProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HiddenLinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.HiddenLineProperties>(), value, diffs, objName);
  }
  
  private static void SetHiddenLineProperties(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenLineProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.HiddenLineProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HiddenLinePropertiesConverter.CreateOpenXmlElement<DXO2010Draw.HiddenLineProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HiddenEffectsProperties? GetHiddenEffectsProperties(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.HiddenEffectsProperties>();
    if (element != null)
      return DMXDraws.HiddenEffectsPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiddenEffectsProperties(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenEffectsProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HiddenEffectsPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.HiddenEffectsProperties>(), value, diffs, objName);
  }
  
  private static void SetHiddenEffectsProperties(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenEffectsProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.HiddenEffectsProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HiddenEffectsPropertiesConverter.CreateOpenXmlElement<DXO2010Draw.HiddenEffectsProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HiddenScene3D? GetHiddenScene3D(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.HiddenScene3D>();
    if (element != null)
      return DMXDraws.HiddenScene3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiddenScene3D(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenScene3D? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HiddenScene3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.HiddenScene3D>(), value, diffs, objName);
  }
  
  private static void SetHiddenScene3D(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenScene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.HiddenScene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HiddenScene3DConverter.CreateOpenXmlElement<DXO2010Draw.HiddenScene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HiddenShape3D? GetHiddenShape3D(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.HiddenShape3D>();
    if (element != null)
      return DMXDraws.HiddenShape3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiddenShape3D(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenShape3D? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HiddenShape3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.HiddenShape3D>(), value, diffs, objName);
  }
  
  private static void SetHiddenShape3D(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenShape3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.HiddenShape3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HiddenShape3DConverter.CreateOpenXmlElement<DXO2010Draw.HiddenShape3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShadowObscured(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010Draw.ShadowObscured>() != null;
  }
  
  private static bool CmpShadowObscured(DXDraw.ShapePropertiesExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2010Draw.ShadowObscured>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2010Draw.ShadowObscured", val, value);
    return false;
  }
  
  private static void SetShadowObscured(DXDraw.ShapePropertiesExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ShadowObscured>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010Draw.ShadowObscured();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ShapePropertiesExtension? CreateModelElement(DXDraw.ShapePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapePropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.HiddenFillProperties = GetHiddenFillProperties(openXmlElement);
      value.HiddenLineProperties = GetHiddenLineProperties(openXmlElement);
      value.HiddenEffectsProperties = GetHiddenEffectsProperties(openXmlElement);
      value.HiddenScene3D = GetHiddenScene3D(openXmlElement);
      value.HiddenShape3D = GetHiddenShape3D(openXmlElement);
      value.ShadowObscured = GetShadowObscured(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ShapePropertiesExtension? openXmlElement, DMDraws.ShapePropertiesExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpHiddenFillProperties(openXmlElement, value.HiddenFillProperties, diffs, objName))
        ok = false;
      if (!CmpHiddenLineProperties(openXmlElement, value.HiddenLineProperties, diffs, objName))
        ok = false;
      if (!CmpHiddenEffectsProperties(openXmlElement, value.HiddenEffectsProperties, diffs, objName))
        ok = false;
      if (!CmpHiddenScene3D(openXmlElement, value.HiddenScene3D, diffs, objName))
        ok = false;
      if (!CmpHiddenShape3D(openXmlElement, value.HiddenShape3D, diffs, objName))
        ok = false;
      if (!CmpShadowObscured(openXmlElement, value.ShadowObscured, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ShapePropertiesExtension value)
    where OpenXmlElementType: DXDraw.ShapePropertiesExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.ShapePropertiesExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetHiddenFillProperties(openXmlElement, value?.HiddenFillProperties);
    SetHiddenLineProperties(openXmlElement, value?.HiddenLineProperties);
    SetHiddenEffectsProperties(openXmlElement, value?.HiddenEffectsProperties);
    SetHiddenScene3D(openXmlElement, value?.HiddenScene3D);
    SetHiddenShape3D(openXmlElement, value?.HiddenShape3D);
    SetShadowObscured(openXmlElement, value?.ShadowObscured);
  }
}
