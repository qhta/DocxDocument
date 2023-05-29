namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// 3-D Shape Properties.
/// </summary>
public static class Shape3DConverter
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  private static Int64? GetZ(DXDrawDgms.Shape3D openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }
  
  private static bool CmpZ(DXDrawDgms.Shape3D openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Z?.Value == value) return true;
    diffs?.Add(objName, "Z", openXmlElement?.Z?.Value, value);
    return false;
  }
  
  private static void SetZ(DXDrawDgms.Shape3D openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  private static Int64? GetExtrusionHeight(DXDrawDgms.Shape3D openXmlElement)
  {
    return openXmlElement?.ExtrusionHeight?.Value;
  }
  
  private static bool CmpExtrusionHeight(DXDrawDgms.Shape3D openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ExtrusionHeight?.Value == value) return true;
    diffs?.Add(objName, "ExtrusionHeight", openXmlElement?.ExtrusionHeight?.Value, value);
    return false;
  }
  
  private static void SetExtrusionHeight(DXDrawDgms.Shape3D openXmlElement, Int64? value)
  {
    openXmlElement.ExtrusionHeight = value;
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  private static Int64? GetContourWidth(DXDrawDgms.Shape3D openXmlElement)
  {
    return openXmlElement?.ContourWidth?.Value;
  }
  
  private static bool CmpContourWidth(DXDrawDgms.Shape3D openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContourWidth?.Value == value) return true;
    diffs?.Add(objName, "ContourWidth", openXmlElement?.ContourWidth?.Value, value);
    return false;
  }
  
  private static void SetContourWidth(DXDrawDgms.Shape3D openXmlElement, Int64? value)
  {
    openXmlElement.ContourWidth = value;
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  private static DMDraws.PresetMaterialKind? GetPresetMaterial(DXDrawDgms.Shape3D openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }
  
  private static bool CmpPresetMaterial(DXDrawDgms.Shape3D openXmlElement, DMDraws.PresetMaterialKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetMaterial(DXDrawDgms.Shape3D openXmlElement, DMDraws.PresetMaterialKind? value)
  {
    openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  private static DMDraws.BevelType? GetBevelTop(DXDrawDgms.Shape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BevelTop>();
    if (element != null)
      return DMXDraws.BevelTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBevelTop(DXDrawDgms.Shape3D openXmlElement, DMDraws.BevelType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BevelTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BevelTop>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBevelTop(DXDrawDgms.Shape3D openXmlElement, DMDraws.BevelType? value)
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
  private static DMDraws.BevelType? GetBevelBottom(DXDrawDgms.Shape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BevelBottom>();
    if (element != null)
      return DMXDraws.BevelTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBevelBottom(DXDrawDgms.Shape3D openXmlElement, DMDraws.BevelType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BevelTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BevelBottom>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBevelBottom(DXDrawDgms.Shape3D openXmlElement, DMDraws.BevelType? value)
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
  private static DMDraws.ExtrusionColor? GetExtrusionColor(DXDrawDgms.Shape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtrusionColor>();
    if (element != null)
      return DMXDraws.ExtrusionColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtrusionColor(DXDrawDgms.Shape3D openXmlElement, DMDraws.ExtrusionColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtrusionColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtrusionColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtrusionColor(DXDrawDgms.Shape3D openXmlElement, DMDraws.ExtrusionColor? value)
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
  private static DMDraws.ContourColor? GetContourColor(DXDrawDgms.Shape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ContourColor>();
    if (element != null)
      return DMXDraws.ContourColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContourColor(DXDrawDgms.Shape3D openXmlElement, DMDraws.ContourColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ContourColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ContourColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetContourColor(DXDrawDgms.Shape3D openXmlElement, DMDraws.ContourColor? value)
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
  private static DMDraws.ExtensionList? GetExtensionList(DXDrawDgms.Shape3D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawDgms.Shape3D openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.Shape3D openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.Shape3D? CreateModelElement(DXDrawDgms.Shape3D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Shape3D();
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
  
  public static bool CompareModelElement(DXDrawDgms.Shape3D? openXmlElement, DMDrawsDgms.Shape3D? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Shape3D value)
    where OpenXmlElementType: DXDrawDgms.Shape3D, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Shape3D openXmlElement, DMDrawsDgms.Shape3D value)
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
