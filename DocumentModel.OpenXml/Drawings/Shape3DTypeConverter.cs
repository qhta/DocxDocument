namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Apply 3D shape properties.
/// </summary>
public static class Shape3DTypeConverter
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  private static Int64? GetZ(DXDraw.Shape3DType openXmlElement)
  {
    return openXmlElement.Z?.Value;
  }
  
  private static bool CmpZ(DXDraw.Shape3DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Z?.Value == value;
  }
  
  private static void SetZ(DXDraw.Shape3DType openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  private static Int64? GetExtrusionHeight(DXDraw.Shape3DType openXmlElement)
  {
    return openXmlElement.ExtrusionHeight?.Value;
  }
  
  private static bool CmpExtrusionHeight(DXDraw.Shape3DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.ExtrusionHeight?.Value == value;
  }
  
  private static void SetExtrusionHeight(DXDraw.Shape3DType openXmlElement, Int64? value)
  {
    openXmlElement.ExtrusionHeight = value;
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  private static Int64? GetContourWidth(DXDraw.Shape3DType openXmlElement)
  {
    return openXmlElement.ContourWidth?.Value;
  }
  
  private static bool CmpContourWidth(DXDraw.Shape3DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.ContourWidth?.Value == value;
  }
  
  private static void SetContourWidth(DXDraw.Shape3DType openXmlElement, Int64? value)
  {
    openXmlElement.ContourWidth = value;
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  private static DMDraws.PresetMaterialKind? GetPresetMaterial(DXDraw.Shape3DType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value);
  }
  
  private static bool CmpPresetMaterial(DXDraw.Shape3DType openXmlElement, DMDraws.PresetMaterialKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(openXmlElement?.PresetMaterial?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetMaterial(DXDraw.Shape3DType openXmlElement, DMDraws.PresetMaterialKind? value)
  {
    openXmlElement.PresetMaterial = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues, DMDraws.PresetMaterialKind>(value);
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  private static DMDraws.BevelType? GetBevelTop(DXDraw.Shape3DType openXmlElement)
  {
    return DMXDraws.BevelTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.BevelTop>());
  }
  
  private static bool CmpBevelTop(DXDraw.Shape3DType openXmlElement, DMDraws.BevelType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BevelTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.BevelTop>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBevelTop(DXDraw.Shape3DType openXmlElement, DMDraws.BevelType? value)
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
  private static DMDraws.BevelType? GetBevelBottom(DXDraw.Shape3DType openXmlElement)
  {
    return DMXDraws.BevelTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.BevelBottom>());
  }
  
  private static bool CmpBevelBottom(DXDraw.Shape3DType openXmlElement, DMDraws.BevelType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BevelTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.BevelBottom>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBevelBottom(DXDraw.Shape3DType openXmlElement, DMDraws.BevelType? value)
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
  private static DMDraws.ExtrusionColor? GetExtrusionColor(DXDraw.Shape3DType openXmlElement)
  {
    return DMXDraws.ExtrusionColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtrusionColor>());
  }
  
  private static bool CmpExtrusionColor(DXDraw.Shape3DType openXmlElement, DMDraws.ExtrusionColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtrusionColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtrusionColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtrusionColor(DXDraw.Shape3DType openXmlElement, DMDraws.ExtrusionColor? value)
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
  private static DMDraws.ContourColor? GetContourColor(DXDraw.Shape3DType openXmlElement)
  {
    return DMXDraws.ContourColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ContourColor>());
  }
  
  private static bool CmpContourColor(DXDraw.Shape3DType openXmlElement, DMDraws.ContourColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ContourColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ContourColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetContourColor(DXDraw.Shape3DType openXmlElement, DMDraws.ContourColor? value)
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
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.Shape3DType openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.Shape3DType openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDraw.Shape3DType openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.Shape3DType? CreateModelElement(DXDraw.Shape3DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Shape3DType();
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
  
  public static bool CompareModelElement(DXDraw.Shape3DType? openXmlElement, DMDraws.Shape3DType? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Shape3DType? value)
    where OpenXmlElementType: DXDraw.Shape3DType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetZ(openXmlElement, value?.Z);
      SetExtrusionHeight(openXmlElement, value?.ExtrusionHeight);
      SetContourWidth(openXmlElement, value?.ContourWidth);
      SetPresetMaterial(openXmlElement, value?.PresetMaterial);
      SetBevelTop(openXmlElement, value?.BevelTop);
      SetBevelBottom(openXmlElement, value?.BevelBottom);
      SetExtrusionColor(openXmlElement, value?.ExtrusionColor);
      SetContourColor(openXmlElement, value?.ContourColor);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
