namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
public static class ShapePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.ShapePropertiesExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.ShapePropertiesExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.ShapePropertiesExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMD.Fill? GetHiddenFillProperties(DXD.ShapePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.HiddenFillProperties>();
    if (element != null)
      return FillConverter  .CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiddenFillProperties(DXD.ShapePropertiesExtension openXmlElement, DMD.Fill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return FillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.HiddenFillProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetHiddenFillProperties(DXD.ShapePropertiesExtension openXmlElement, DMD.Fill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.HiddenFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = FillConverter.CreateOpenXmlElement<DXO10D.HiddenFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.HiddenLineProperties? GetHiddenLineProperties(DXD.ShapePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.HiddenLineProperties>();
    if (element != null)
      return DMXD.HiddenLinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiddenLineProperties(DXD.ShapePropertiesExtension openXmlElement, DMD.HiddenLineProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HiddenLinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.HiddenLineProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetHiddenLineProperties(DXD.ShapePropertiesExtension openXmlElement, DMD.HiddenLineProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.HiddenLineProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HiddenLinePropertiesConverter.CreateOpenXmlElement<DXO10D.HiddenLineProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.HiddenEffectsProperties? GetHiddenEffectsProperties(DXD.ShapePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.HiddenEffectsProperties>();
    if (element != null)
      return DMXD.HiddenEffectsPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiddenEffectsProperties(DXD.ShapePropertiesExtension openXmlElement, DMD.HiddenEffectsProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HiddenEffectsPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.HiddenEffectsProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetHiddenEffectsProperties(DXD.ShapePropertiesExtension openXmlElement, DMD.HiddenEffectsProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.HiddenEffectsProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HiddenEffectsPropertiesConverter.CreateOpenXmlElement<DXO10D.HiddenEffectsProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.HiddenScene3D? GetHiddenScene3D(DXD.ShapePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.HiddenScene3D>();
    if (element != null)
      return DMXD.HiddenScene3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiddenScene3D(DXD.ShapePropertiesExtension openXmlElement, DMD.HiddenScene3D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HiddenScene3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.HiddenScene3D>(), value, diffs, objName, propName);
  }
  
  private static void SetHiddenScene3D(DXD.ShapePropertiesExtension openXmlElement, DMD.HiddenScene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.HiddenScene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HiddenScene3DConverter.CreateOpenXmlElement<DXO10D.HiddenScene3D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.HiddenShape3D? GetHiddenShape3D(DXD.ShapePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.HiddenShape3D>();
    if (element != null)
      return DMXD.HiddenShape3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHiddenShape3D(DXD.ShapePropertiesExtension openXmlElement, DMD.HiddenShape3D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HiddenShape3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.HiddenShape3D>(), value, diffs, objName, propName);
  }
  
  private static void SetHiddenShape3D(DXD.ShapePropertiesExtension openXmlElement, DMD.HiddenShape3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.HiddenShape3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HiddenShape3DConverter.CreateOpenXmlElement<DXO10D.HiddenShape3D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShadowObscured(DXD.ShapePropertiesExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10D.ShadowObscured>() != null;
  }
  
  private static bool CmpShadowObscured(DXD.ShapePropertiesExtension openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO10D.ShadowObscured>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10D.ShadowObscured", val, value);
    return false;
  }
  
  private static void SetShadowObscured(DXD.ShapePropertiesExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10D.ShadowObscured>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10D.ShadowObscured();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ShapePropertiesExtension? CreateModelElement(DXD.ShapePropertiesExtension? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.ShapePropertiesExtension? openXmlElement, DMD.ShapePropertiesExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpHiddenFillProperties(openXmlElement, value.HiddenFillProperties, diffs, objName, propName))
        ok = false;
      if (!CmpHiddenLineProperties(openXmlElement, value.HiddenLineProperties, diffs, objName, propName))
        ok = false;
      if (!CmpHiddenEffectsProperties(openXmlElement, value.HiddenEffectsProperties, diffs, objName, propName))
        ok = false;
      if (!CmpHiddenScene3D(openXmlElement, value.HiddenScene3D, diffs, objName, propName))
        ok = false;
      if (!CmpHiddenShape3D(openXmlElement, value.HiddenShape3D, diffs, objName, propName))
        ok = false;
      if (!CmpShadowObscured(openXmlElement, value.ShadowObscured, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ShapePropertiesExtension value)
    where OpenXmlElementType: DXD.ShapePropertiesExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ShapePropertiesExtension openXmlElement, DMD.ShapePropertiesExtension value)
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
