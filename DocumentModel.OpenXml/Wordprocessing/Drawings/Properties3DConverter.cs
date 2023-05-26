namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Properties3D Class.
/// </summary>
public static class Properties3DConverter
{
  /// <summary>
  /// extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetExtrusionHeight(DXO10W.Properties3D openXmlElement)
  {
    return openXmlElement?.ExtrusionHeight?.Value;
  }
  
  private static bool CmpExtrusionHeight(DXO10W.Properties3D openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ExtrusionHeight?.Value == value) return true;
    diffs?.Add(objName, "ExtrusionHeight", openXmlElement?.ExtrusionHeight?.Value, value);
    return false;
  }
  
  private static void SetExtrusionHeight(DXO10W.Properties3D openXmlElement, Int64? value)
  {
    openXmlElement.ExtrusionHeight = value;
  }
  
  /// <summary>
  /// contourW, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetContourWidth(DXO10W.Properties3D openXmlElement)
  {
    return openXmlElement?.ContourWidth?.Value;
  }
  
  private static bool CmpContourWidth(DXO10W.Properties3D openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContourWidth?.Value == value) return true;
    diffs?.Add(objName, "ContourWidth", openXmlElement?.ContourWidth?.Value, value);
    return false;
  }
  
  private static void SetContourWidth(DXO10W.Properties3D openXmlElement, Int64? value)
  {
    openXmlElement.ContourWidth = value;
  }
  
  /// <summary>
  /// prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.PresetMaterialKind? GetPresetMaterialType(DXO10W.Properties3D openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues, DMW.PresetMaterialKind>(openXmlElement?.PresetMaterialType?.Value);
  }
  
  private static bool CmpPresetMaterialType(DXO10W.Properties3D openXmlElement, DMW.PresetMaterialKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues, DMW.PresetMaterialKind>(openXmlElement?.PresetMaterialType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPresetMaterialType(DXO10W.Properties3D openXmlElement, DMW.PresetMaterialKind? value)
  {
    openXmlElement.PresetMaterialType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues, DMW.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  private static DMW.BevelType? GetBevelTop(DXO10W.Properties3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.BevelTop>();
    if (element != null)
      return DMXW.BevelTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBevelTop(DXO10W.Properties3D openXmlElement, DMW.BevelType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BevelTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.BevelTop>(), value, diffs, objName, propName);
  }
  
  private static void SetBevelTop(DXO10W.Properties3D openXmlElement, DMW.BevelType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.BevelTop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BevelTypeConverter.CreateOpenXmlElement<DXO10W.BevelTop>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  private static DMW.BevelType? GetBevelBottom(DXO10W.Properties3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.BevelBottom>();
    if (element != null)
      return DMXW.BevelTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBevelBottom(DXO10W.Properties3D openXmlElement, DMW.BevelType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BevelTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.BevelBottom>(), value, diffs, objName, propName);
  }
  
  private static void SetBevelBottom(DXO10W.Properties3D openXmlElement, DMW.BevelType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.BevelBottom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BevelTypeConverter.CreateOpenXmlElement<DXO10W.BevelBottom>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  private static DMW.ExtrusionColor? GetExtrusionColor(DXO10W.Properties3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.ExtrusionColor>();
    if (element != null)
      return DMXW.ExtrusionColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtrusionColor(DXO10W.Properties3D openXmlElement, DMW.ExtrusionColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.ExtrusionColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.ExtrusionColor>(), value, diffs, objName, propName);
  }
  
  private static void SetExtrusionColor(DXO10W.Properties3D openXmlElement, DMW.ExtrusionColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.ExtrusionColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ExtrusionColorConverter.CreateOpenXmlElement<DXO10W.ExtrusionColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  private static DMW.ContourColor? GetContourColor(DXO10W.Properties3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10W.ContourColor>();
    if (element != null)
      return DMXW.ContourColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContourColor(DXO10W.Properties3D openXmlElement, DMW.ContourColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.ContourColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10W.ContourColor>(), value, diffs, objName, propName);
  }
  
  private static void SetContourColor(DXO10W.Properties3D openXmlElement, DMW.ContourColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10W.ContourColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ContourColorConverter.CreateOpenXmlElement<DXO10W.ContourColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.Properties3D? CreateModelElement(DXO10W.Properties3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Properties3D();
      value.ExtrusionHeight = GetExtrusionHeight(openXmlElement);
      value.ContourWidth = GetContourWidth(openXmlElement);
      value.PresetMaterialType = GetPresetMaterialType(openXmlElement);
      value.BevelTop = GetBevelTop(openXmlElement);
      value.BevelBottom = GetBevelBottom(openXmlElement);
      value.ExtrusionColor = GetExtrusionColor(openXmlElement);
      value.ContourColor = GetContourColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.Properties3D? openXmlElement, DMW.Properties3D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtrusionHeight(openXmlElement, value.ExtrusionHeight, diffs, objName, propName))
        ok = false;
      if (!CmpContourWidth(openXmlElement, value.ContourWidth, diffs, objName, propName))
        ok = false;
      if (!CmpPresetMaterialType(openXmlElement, value.PresetMaterialType, diffs, objName, propName))
        ok = false;
      if (!CmpBevelTop(openXmlElement, value.BevelTop, diffs, objName, propName))
        ok = false;
      if (!CmpBevelBottom(openXmlElement, value.BevelBottom, diffs, objName, propName))
        ok = false;
      if (!CmpExtrusionColor(openXmlElement, value.ExtrusionColor, diffs, objName, propName))
        ok = false;
      if (!CmpContourColor(openXmlElement, value.ContourColor, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Properties3D value)
    where OpenXmlElementType: DXO10W.Properties3D, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.Properties3D openXmlElement, DMW.Properties3D value)
  {
    SetExtrusionHeight(openXmlElement, value?.ExtrusionHeight);
    SetContourWidth(openXmlElement, value?.ContourWidth);
    SetPresetMaterialType(openXmlElement, value?.PresetMaterialType);
    SetBevelTop(openXmlElement, value?.BevelTop);
    SetBevelBottom(openXmlElement, value?.BevelBottom);
    SetExtrusionColor(openXmlElement, value?.ExtrusionColor);
    SetContourColor(openXmlElement, value?.ContourColor);
  }
}
