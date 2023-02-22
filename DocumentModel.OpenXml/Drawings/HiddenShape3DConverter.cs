namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenShape3D Class.
/// </summary>
public static class HiddenShape3DConverter
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  private static Int64? GetZ(DXO2010Draw.HiddenShape3D openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }
  
  private static bool CmpZ(DXO2010Draw.HiddenShape3D openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Z?.Value == value) return true;
    diffs?.Add(objName, "Z", openXmlElement?.Z?.Value, value);
    return false;
  }
  
  private static void SetZ(DXO2010Draw.HiddenShape3D openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  private static Int64? GetExtrusionHeight(DXO2010Draw.HiddenShape3D openXmlElement)
  {
    return openXmlElement?.ExtrusionHeight?.Value;
  }
  
  private static bool CmpExtrusionHeight(DXO2010Draw.HiddenShape3D openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ExtrusionHeight?.Value == value) return true;
    diffs?.Add(objName, "ExtrusionHeight", openXmlElement?.ExtrusionHeight?.Value, value);
    return false;
  }
  
  private static void SetExtrusionHeight(DXO2010Draw.HiddenShape3D openXmlElement, Int64? value)
  {
    openXmlElement.ExtrusionHeight = value;
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  private static Int64? GetContourWidth(DXO2010Draw.HiddenShape3D openXmlElement)
  {
    return openXmlElement?.ContourWidth?.Value;
  }
  
  private static bool CmpContourWidth(DXO2010Draw.HiddenShape3D openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContourWidth?.Value == value) return true;
    diffs?.Add(objName, "ContourWidth", openXmlElement?.ContourWidth?.Value, value);
    return false;
  }
  
  private static void SetContourWidth(DXO2010Draw.HiddenShape3D openXmlElement, Int64? value)
  {
    openXmlElement.ContourWidth = value;
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  private static DMDraws.PresetMaterialKind? GetPresetMaterial(DXO2010Draw.HiddenShape3D openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }
  
  private static bool CmpPresetMaterial(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.PresetMaterialKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetMaterial(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.PresetMaterialKind? value)
  {
    openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  private static DMDraws.BevelType? GetBevelTop(DXO2010Draw.HiddenShape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BevelTop>();
    if (element != null)
      return DMXDraws.BevelTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBevelTop(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.BevelType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BevelTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BevelTop>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBevelTop(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.BevelType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BevelTop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BevelTypeConverter.CreateOpenXmlElement<DXDraw.BevelTop>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  private static DMDraws.BevelType? GetBevelBottom(DXO2010Draw.HiddenShape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BevelBottom>();
    if (element != null)
      return DMXDraws.BevelTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBevelBottom(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.BevelType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BevelTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BevelBottom>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBevelBottom(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.BevelType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BevelBottom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BevelTypeConverter.CreateOpenXmlElement<DXDraw.BevelBottom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  private static DMDraws.ExtrusionColor? GetExtrusionColor(DXO2010Draw.HiddenShape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtrusionColor>();
    if (element != null)
      return DMXDraws.ExtrusionColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtrusionColor(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.ExtrusionColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtrusionColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtrusionColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtrusionColor(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.ExtrusionColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtrusionColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtrusionColorConverter.CreateOpenXmlElement<DXDraw.ExtrusionColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  private static DMDraws.ContourColor? GetContourColor(DXO2010Draw.HiddenShape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ContourColor>();
    if (element != null)
      return DMXDraws.ContourColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContourColor(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.ContourColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ContourColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ContourColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetContourColor(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.ContourColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ContourColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ContourColorConverter.CreateOpenXmlElement<DXDraw.ContourColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXO2010Draw.HiddenShape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.HiddenShape3D? CreateModelElement(DXO2010Draw.HiddenShape3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HiddenShape3D();
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
  
  public static bool CompareModelElement(DXO2010Draw.HiddenShape3D? openXmlElement, DMDraws.HiddenShape3D? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpZ(openXmlElement, value.Z, diffs, objName))
        ok = false;
      if (!CmpExtrusionHeight(openXmlElement, value.ExtrusionHeight, diffs, objName))
        ok = false;
      if (!CmpContourWidth(openXmlElement, value.ContourWidth, diffs, objName))
        ok = false;
      if (!CmpPresetMaterial(openXmlElement, value.PresetMaterial, diffs, objName))
        ok = false;
      if (!CmpBevelTop(openXmlElement, value.BevelTop, diffs, objName))
        ok = false;
      if (!CmpBevelBottom(openXmlElement, value.BevelBottom, diffs, objName))
        ok = false;
      if (!CmpExtrusionColor(openXmlElement, value.ExtrusionColor, diffs, objName))
        ok = false;
      if (!CmpContourColor(openXmlElement, value.ContourColor, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.HiddenShape3D value)
    where OpenXmlElementType: DXO2010Draw.HiddenShape3D, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.HiddenShape3D openXmlElement, DMDraws.HiddenShape3D value)
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
