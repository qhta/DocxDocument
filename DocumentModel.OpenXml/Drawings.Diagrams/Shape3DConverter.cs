namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// 3-D Shape Properties.
/// </summary>
public static class Shape3DConverter
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  private static Int64? GetZ(DXDD.Shape3D openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }
  
  private static bool CmpZ(DXDD.Shape3D openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Z?.Value == value) return true;
    diffs?.Add(objName, "Z", openXmlElement?.Z?.Value, value);
    return false;
  }
  
  private static void SetZ(DXDD.Shape3D openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  private static Int64? GetExtrusionHeight(DXDD.Shape3D openXmlElement)
  {
    return openXmlElement?.ExtrusionHeight?.Value;
  }
  
  private static bool CmpExtrusionHeight(DXDD.Shape3D openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ExtrusionHeight?.Value == value) return true;
    diffs?.Add(objName, "ExtrusionHeight", openXmlElement?.ExtrusionHeight?.Value, value);
    return false;
  }
  
  private static void SetExtrusionHeight(DXDD.Shape3D openXmlElement, Int64? value)
  {
    openXmlElement.ExtrusionHeight = value;
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  private static Int64? GetContourWidth(DXDD.Shape3D openXmlElement)
  {
    return openXmlElement?.ContourWidth?.Value;
  }
  
  private static bool CmpContourWidth(DXDD.Shape3D openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContourWidth?.Value == value) return true;
    diffs?.Add(objName, "ContourWidth", openXmlElement?.ContourWidth?.Value, value);
    return false;
  }
  
  private static void SetContourWidth(DXDD.Shape3D openXmlElement, Int64? value)
  {
    openXmlElement.ContourWidth = value;
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  private static DMD.PresetMaterialKind? GetPresetMaterial(DXDD.Shape3D openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMD.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }
  
  private static bool CmpPresetMaterial(DXDD.Shape3D openXmlElement, DMD.PresetMaterialKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMD.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPresetMaterial(DXDD.Shape3D openXmlElement, DMD.PresetMaterialKind? value)
  {
    openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMD.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  private static DMD.BevelType? GetBevelTop(DXDD.Shape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BevelTop>();
    if (element != null)
      return DMXD.BevelTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBevelTop(DXDD.Shape3D openXmlElement, DMD.BevelType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BevelTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BevelTop>(), value, diffs, objName, propName);
  }
  
  private static void SetBevelTop(DXDD.Shape3D openXmlElement, DMD.BevelType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BevelTop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BevelTypeConverter.CreateOpenXmlElement<DXD.BevelTop>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  private static DMD.BevelType? GetBevelBottom(DXDD.Shape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BevelBottom>();
    if (element != null)
      return DMXD.BevelTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBevelBottom(DXDD.Shape3D openXmlElement, DMD.BevelType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BevelTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BevelBottom>(), value, diffs, objName, propName);
  }
  
  private static void SetBevelBottom(DXDD.Shape3D openXmlElement, DMD.BevelType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BevelBottom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BevelTypeConverter.CreateOpenXmlElement<DXD.BevelBottom>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  private static DMD.ExtrusionColor? GetExtrusionColor(DXDD.Shape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtrusionColor>();
    if (element != null)
      return DMXD.ExtrusionColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtrusionColor(DXDD.Shape3D openXmlElement, DMD.ExtrusionColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtrusionColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtrusionColor>(), value, diffs, objName, propName);
  }
  
  private static void SetExtrusionColor(DXDD.Shape3D openXmlElement, DMD.ExtrusionColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtrusionColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtrusionColorConverter.CreateOpenXmlElement<DXD.ExtrusionColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  private static DMD.ContourColor? GetContourColor(DXDD.Shape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ContourColor>();
    if (element != null)
      return DMXD.ContourColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContourColor(DXDD.Shape3D openXmlElement, DMD.ContourColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ContourColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ContourColor>(), value, diffs, objName, propName);
  }
  
  private static void SetContourColor(DXDD.Shape3D openXmlElement, DMD.ContourColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ContourColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ContourColorConverter.CreateOpenXmlElement<DXD.ContourColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXDD.Shape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.Shape3D openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDD.Shape3D openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.Shape3D? CreateModelElement(DXDD.Shape3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.Shape3D();
      value.Z = GetZ(openXmlElement);
      value.ExtrusionHeight = GetExtrusionHeight(openXmlElement);
      value.ContourWidth = GetContourWidth(openXmlElement);
      value.PresetMaterial = GetPresetMaterial(openXmlElement);
      value.BevelTop = GetBevelTop(openXmlElement);
      value.BevelBottom = GetBevelBottom(openXmlElement);
      value.ExtrusionColor = GetExtrusionColor(openXmlElement);
      value.ContourColor = GetContourColor(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.Shape3D? openXmlElement, DMDD.Shape3D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpZ(openXmlElement, value.Z, diffs, objName, propName))
        ok = false;
      if (!CmpExtrusionHeight(openXmlElement, value.ExtrusionHeight, diffs, objName, propName))
        ok = false;
      if (!CmpContourWidth(openXmlElement, value.ContourWidth, diffs, objName, propName))
        ok = false;
      if (!CmpPresetMaterial(openXmlElement, value.PresetMaterial, diffs, objName, propName))
        ok = false;
      if (!CmpBevelTop(openXmlElement, value.BevelTop, diffs, objName, propName))
        ok = false;
      if (!CmpBevelBottom(openXmlElement, value.BevelBottom, diffs, objName, propName))
        ok = false;
      if (!CmpExtrusionColor(openXmlElement, value.ExtrusionColor, diffs, objName, propName))
        ok = false;
      if (!CmpContourColor(openXmlElement, value.ContourColor, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Shape3D value)
    where OpenXmlElementType: DXDD.Shape3D, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Shape3D openXmlElement, DMDD.Shape3D value)
  {
    SetZ(openXmlElement, value?.Z);
    SetExtrusionHeight(openXmlElement, value?.ExtrusionHeight);
    SetContourWidth(openXmlElement, value?.ContourWidth);
    SetPresetMaterial(openXmlElement, value?.PresetMaterial);
    SetBevelTop(openXmlElement, value?.BevelTop);
    SetBevelBottom(openXmlElement, value?.BevelBottom);
    SetExtrusionColor(openXmlElement, value?.ExtrusionColor);
    SetContourColor(openXmlElement, value?.ContourColor);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
