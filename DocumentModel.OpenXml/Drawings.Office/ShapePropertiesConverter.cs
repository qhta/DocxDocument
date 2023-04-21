namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the ShapeProperties Class.
/// </summary>
public static class ShapePropertiesConverter
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  private static DMD.BlackWhiteMode? GetBlackWhiteMode(DXOD.ShapeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXOD.ShapeProperties openXmlElement, DMD.BlackWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetBlackWhiteMode(DXOD.ShapeProperties openXmlElement, DMD.BlackWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  private static DMD.Transform2D? GetTransform2D(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Transform2D>();
    if (element != null)
      return DMXD.Transform2DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform2D(DXOD.ShapeProperties openXmlElement, DMD.Transform2D? value, DiffList? diffs, string? objName)
  {
    return DMXD.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Transform2D>(), value, diffs, objName);
  }
  
  private static void SetTransform2D(DXOD.ShapeProperties openXmlElement, DMD.Transform2D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Transform2D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Transform2DConverter.CreateOpenXmlElement<DXD.Transform2D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.CustomGeometry? GetCustomGeometry(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomGeometry>();
    if (element != null)
      return DMXD.CustomGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomGeometry(DXOD.ShapeProperties openXmlElement, DMD.CustomGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXD.CustomGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomGeometry>(), value, diffs, objName);
  }
  
  private static void SetCustomGeometry(DXOD.ShapeProperties openXmlElement, DMD.CustomGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CustomGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CustomGeometryConverter.CreateOpenXmlElement<DXD.CustomGeometry>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.PresetGeometry? GetPresetGeometry(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetGeometry>();
    if (element != null)
      return DMXD.PresetGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetGeometry(DXOD.ShapeProperties openXmlElement, DMD.PresetGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXD.PresetGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetGeometry>(), value, diffs, objName);
  }
  
  private static void SetPresetGeometry(DXOD.ShapeProperties openXmlElement, DMD.PresetGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PresetGeometryConverter.CreateOpenXmlElement<DXD.PresetGeometry>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoFill(DXOD.ShapeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXOD.ShapeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXOD.ShapeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.NoFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.SolidFill? GetSolidFill(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SolidFill>();
    if (element != null)
      return DMXD.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXOD.ShapeProperties openXmlElement, DMD.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SolidFill>(), value, diffs, objName);
  }
  
  private static void SetSolidFill(DXOD.ShapeProperties openXmlElement, DMD.SolidFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SolidFillConverter.CreateOpenXmlElement<DXD.SolidFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.GradientFill? GetGradientFill(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GradientFill>();
    if (element != null)
      return DMXD.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXOD.ShapeProperties openXmlElement, DMD.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GradientFill>(), value, diffs, objName);
  }
  
  private static void SetGradientFill(DXOD.ShapeProperties openXmlElement, DMD.GradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GradientFillConverter.CreateOpenXmlElement<DXD.GradientFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.BlipFill? GetBlipFill(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BlipFill>();
    if (element != null)
      return DMXD.BlipFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipFill(DXOD.ShapeProperties openXmlElement, DMD.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BlipFill>(), value, diffs, objName);
  }
  
  private static void SetBlipFill(DXOD.ShapeProperties openXmlElement, DMD.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlipFillConverter.CreateOpenXmlElement<DXD.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.PatternFill? GetPatternFill(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PatternFill>();
    if (element != null)
      return DMXD.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXOD.ShapeProperties openXmlElement, DMD.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PatternFill>(), value, diffs, objName);
  }
  
  private static void SetPatternFill(DXOD.ShapeProperties openXmlElement, DMD.PatternFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PatternFillConverter.CreateOpenXmlElement<DXD.PatternFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetGroupFill(DXOD.ShapeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.GroupFill>() != null;
  }
  
  private static bool CmpGroupFill(DXOD.ShapeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.GroupFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.GroupFill", val, value);
    return false;
  }
  
  private static void SetGroupFill(DXOD.ShapeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.GroupFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Outline? GetOutline(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.OutlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXOD.ShapeProperties openXmlElement, DMD.Outline? value, DiffList? diffs, string? objName)
  {
    return DMXD.OutlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), value, diffs, objName);
  }
  
  private static void SetOutline(DXOD.ShapeProperties openXmlElement, DMD.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OutlineConverter.CreateOpenXmlElement<DXD.Outline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.EffectList? GetEffectList(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectList>();
    if (element != null)
      return DMXD.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXOD.ShapeProperties openXmlElement, DMD.EffectList? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), value, diffs, objName);
  }
  
  private static void SetEffectList(DXOD.ShapeProperties openXmlElement, DMD.EffectList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectListConverter.CreateOpenXmlElement<DXD.EffectList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.EffectDag? GetEffectDag(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectDag>();
    if (element != null)
      return DMXD.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXOD.ShapeProperties openXmlElement, DMD.EffectDag? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), value, diffs, objName);
  }
  
  private static void SetEffectDag(DXOD.ShapeProperties openXmlElement, DMD.EffectDag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectDagConverter.CreateOpenXmlElement<DXD.EffectDag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Scene3DType? GetScene3DType(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Scene3DType>();
    if (element != null)
      return DMXD.Scene3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3DType(DXOD.ShapeProperties openXmlElement, DMD.Scene3DType? value, DiffList? diffs, string? objName)
  {
    return DMXD.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Scene3DType>(), value, diffs, objName);
  }
  
  private static void SetScene3DType(DXOD.ShapeProperties openXmlElement, DMD.Scene3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Scene3DTypeConverter.CreateOpenXmlElement<DXD.Scene3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Shape3DType? GetShape3DType(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Shape3DType>();
    if (element != null)
      return DMXD.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXOD.ShapeProperties openXmlElement, DMD.Shape3DType? value, DiffList? diffs, string? objName)
  {
    return DMXD.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Shape3DType>(), value, diffs, objName);
  }
  
  private static void SetShape3DType(DXOD.ShapeProperties openXmlElement, DMD.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Shape3DTypeConverter.CreateOpenXmlElement<DXD.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.ShapePropertiesExtensionList? GetShapePropertiesExtensionList(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapePropertiesExtensionList>();
    if (element != null)
      return DMXD.ShapePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapePropertiesExtensionList(DXOD.ShapeProperties openXmlElement, DMD.ShapePropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ShapePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapePropertiesExtensionList>(), value, diffs, objName);
  }
  
  private static void SetShapePropertiesExtensionList(DXOD.ShapeProperties openXmlElement, DMD.ShapePropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ShapePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ShapePropertiesExtensionListConverter.CreateOpenXmlElement<DXD.ShapePropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.ShapeProperties? CreateModelElement(DXOD.ShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.ShapeProperties();
      value.BlackWhiteMode = GetBlackWhiteMode(openXmlElement);
      value.Transform2D = GetTransform2D(openXmlElement);
      value.CustomGeometry = GetCustomGeometry(openXmlElement);
      value.PresetGeometry = GetPresetGeometry(openXmlElement);
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.GroupFill = GetGroupFill(openXmlElement);
      value.Outline = GetOutline(openXmlElement);
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      value.Scene3DType = GetScene3DType(openXmlElement);
      value.Shape3DType = GetShape3DType(openXmlElement);
      value.ShapePropertiesExtensionList = GetShapePropertiesExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOD.ShapeProperties? openXmlElement, DMDO.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlackWhiteMode(openXmlElement, value.BlackWhiteMode, diffs, objName))
        ok = false;
      if (!CmpTransform2D(openXmlElement, value.Transform2D, diffs, objName))
        ok = false;
      if (!CmpCustomGeometry(openXmlElement, value.CustomGeometry, diffs, objName))
        ok = false;
      if (!CmpPresetGeometry(openXmlElement, value.PresetGeometry, diffs, objName))
        ok = false;
      if (!CmpNoFill(openXmlElement, value.NoFill, diffs, objName))
        ok = false;
      if (!CmpSolidFill(openXmlElement, value.SolidFill, diffs, objName))
        ok = false;
      if (!CmpGradientFill(openXmlElement, value.GradientFill, diffs, objName))
        ok = false;
      if (!CmpBlipFill(openXmlElement, value.BlipFill, diffs, objName))
        ok = false;
      if (!CmpPatternFill(openXmlElement, value.PatternFill, diffs, objName))
        ok = false;
      if (!CmpGroupFill(openXmlElement, value.GroupFill, diffs, objName))
        ok = false;
      if (!CmpOutline(openXmlElement, value.Outline, diffs, objName))
        ok = false;
      if (!CmpEffectList(openXmlElement, value.EffectList, diffs, objName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, value.EffectDag, diffs, objName))
        ok = false;
      if (!CmpScene3DType(openXmlElement, value.Scene3DType, diffs, objName))
        ok = false;
      if (!CmpShape3DType(openXmlElement, value.Shape3DType, diffs, objName))
        ok = false;
      if (!CmpShapePropertiesExtensionList(openXmlElement, value.ShapePropertiesExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.ShapeProperties value)
    where OpenXmlElementType: DXOD.ShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.ShapeProperties openXmlElement, DMDO.ShapeProperties value)
  {
    SetBlackWhiteMode(openXmlElement, value?.BlackWhiteMode);
    SetTransform2D(openXmlElement, value?.Transform2D);
    SetCustomGeometry(openXmlElement, value?.CustomGeometry);
    SetPresetGeometry(openXmlElement, value?.PresetGeometry);
    SetNoFill(openXmlElement, value?.NoFill);
    SetSolidFill(openXmlElement, value?.SolidFill);
    SetGradientFill(openXmlElement, value?.GradientFill);
    SetBlipFill(openXmlElement, value?.BlipFill);
    SetPatternFill(openXmlElement, value?.PatternFill);
    SetGroupFill(openXmlElement, value?.GroupFill);
    SetOutline(openXmlElement, value?.Outline);
    SetEffectList(openXmlElement, value?.EffectList);
    SetEffectDag(openXmlElement, value?.EffectDag);
    SetScene3DType(openXmlElement, value?.Scene3DType);
    SetShape3DType(openXmlElement, value?.Shape3DType);
    SetShapePropertiesExtensionList(openXmlElement, value?.ShapePropertiesExtensionList);
  }
}
