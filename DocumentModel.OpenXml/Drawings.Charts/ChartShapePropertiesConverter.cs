namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartShapeProperties Class.
/// </summary>
public static class ChartShapePropertiesConverter
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  private static DMD.BlackWhiteMode? GetBlackWhiteMode(DXDC.ChartShapeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXDC.ChartShapeProperties openXmlElement, DMD.BlackWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName);
  }
  
  private static void SetBlackWhiteMode(DXDC.ChartShapeProperties openXmlElement, DMD.BlackWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  private static DMD.Transform2D? GetTransform2D(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Transform2D>();
    if (element != null)
      return DMXD.Transform2DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform2D(DXDC.ChartShapeProperties openXmlElement, DMD.Transform2D? value, DiffList? diffs, string? objName)
  {
    return DMXD.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Transform2D>(), value, diffs, objName);
  }
  
  private static void SetTransform2D(DXDC.ChartShapeProperties openXmlElement, DMD.Transform2D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Transform2D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Transform2DConverter.CreateOpenXmlElement<DXD.Transform2D>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.CustomGeometry? GetCustomGeometry(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomGeometry>();
    if (element != null)
      return DMXD.CustomGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomGeometry(DXDC.ChartShapeProperties openXmlElement, DMD.CustomGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXD.CustomGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomGeometry>(), value, diffs, objName);
  }
  
  private static void SetCustomGeometry(DXDC.ChartShapeProperties openXmlElement, DMD.CustomGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CustomGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CustomGeometryConverter.CreateOpenXmlElement<DXD.CustomGeometry>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PresetGeometry? GetPresetGeometry(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetGeometry>();
    if (element != null)
      return DMXD.PresetGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetGeometry(DXDC.ChartShapeProperties openXmlElement, DMD.PresetGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXD.PresetGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetGeometry>(), value, diffs, objName);
  }
  
  private static void SetPresetGeometry(DXDC.ChartShapeProperties openXmlElement, DMD.PresetGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PresetGeometryConverter.CreateOpenXmlElement<DXD.PresetGeometry>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetNoFill(DXDC.ChartShapeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXDC.ChartShapeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXDC.ChartShapeProperties openXmlElement, Boolean? value)
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
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.SolidFill? GetSolidFill(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SolidFill>();
    if (element != null)
      return DMXD.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXDC.ChartShapeProperties openXmlElement, DMD.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SolidFill>(), value, diffs, objName);
  }
  
  private static void SetSolidFill(DXDC.ChartShapeProperties openXmlElement, DMD.SolidFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SolidFillConverter.CreateOpenXmlElement<DXD.SolidFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.GradientFill? GetGradientFill(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GradientFill>();
    if (element != null)
      return DMXD.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXDC.ChartShapeProperties openXmlElement, DMD.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GradientFill>(), value, diffs, objName);
  }
  
  private static void SetGradientFill(DXDC.ChartShapeProperties openXmlElement, DMD.GradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GradientFillConverter.CreateOpenXmlElement<DXD.GradientFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.BlipFill? GetBlipFill(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BlipFill>();
    if (element != null)
      return DMXD.BlipFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipFill(DXDC.ChartShapeProperties openXmlElement, DMD.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BlipFill>(), value, diffs, objName);
  }
  
  private static void SetBlipFill(DXDC.ChartShapeProperties openXmlElement, DMD.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlipFillConverter.CreateOpenXmlElement<DXD.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PatternFill? GetPatternFill(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PatternFill>();
    if (element != null)
      return DMXD.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXDC.ChartShapeProperties openXmlElement, DMD.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXD.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PatternFill>(), value, diffs, objName);
  }
  
  private static void SetPatternFill(DXDC.ChartShapeProperties openXmlElement, DMD.PatternFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PatternFillConverter.CreateOpenXmlElement<DXD.PatternFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Outline? GetOutline(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.OutlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXDC.ChartShapeProperties openXmlElement, DMD.Outline? value, DiffList? diffs, string? objName)
  {
    return DMXD.OutlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), value, diffs, objName);
  }
  
  private static void SetOutline(DXDC.ChartShapeProperties openXmlElement, DMD.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OutlineConverter.CreateOpenXmlElement<DXD.Outline>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EffectList? GetEffectList(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectList>();
    if (element != null)
      return DMXD.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXDC.ChartShapeProperties openXmlElement, DMD.EffectList? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), value, diffs, objName);
  }
  
  private static void SetEffectList(DXDC.ChartShapeProperties openXmlElement, DMD.EffectList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectListConverter.CreateOpenXmlElement<DXD.EffectList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EffectDag? GetEffectDag(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectDag>();
    if (element != null)
      return DMXD.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXDC.ChartShapeProperties openXmlElement, DMD.EffectDag? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), value, diffs, objName);
  }
  
  private static void SetEffectDag(DXDC.ChartShapeProperties openXmlElement, DMD.EffectDag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectDagConverter.CreateOpenXmlElement<DXD.EffectDag>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Scene3DType? GetScene3DType(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Scene3DType>();
    if (element != null)
      return DMXD.Scene3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3DType(DXDC.ChartShapeProperties openXmlElement, DMD.Scene3DType? value, DiffList? diffs, string? objName)
  {
    return DMXD.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Scene3DType>(), value, diffs, objName);
  }
  
  private static void SetScene3DType(DXDC.ChartShapeProperties openXmlElement, DMD.Scene3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Scene3DTypeConverter.CreateOpenXmlElement<DXD.Scene3DType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Shape3DType? GetShape3DType(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Shape3DType>();
    if (element != null)
      return DMXD.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXDC.ChartShapeProperties openXmlElement, DMD.Shape3DType? value, DiffList? diffs, string? objName)
  {
    return DMXD.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Shape3DType>(), value, diffs, objName);
  }
  
  private static void SetShape3DType(DXDC.ChartShapeProperties openXmlElement, DMD.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Shape3DTypeConverter.CreateOpenXmlElement<DXD.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ExtensionList? GetExtensionList(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.ChartShapeProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDC.ChartShapeProperties openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? CreateModelElement(DXDC.ChartShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartShapeProperties();
      value.BlackWhiteMode = GetBlackWhiteMode(openXmlElement);
      value.Transform2D = GetTransform2D(openXmlElement);
      value.CustomGeometry = GetCustomGeometry(openXmlElement);
      value.PresetGeometry = GetPresetGeometry(openXmlElement);
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.Outline = GetOutline(openXmlElement);
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      value.Scene3DType = GetScene3DType(openXmlElement);
      value.Shape3DType = GetShape3DType(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ChartShapeProperties? openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs, string? objName)
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
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ChartShapeProperties value)
    where OpenXmlElementType: DXDC.ChartShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ChartShapeProperties openXmlElement, DMDC.ChartShapeProperties value)
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
    SetOutline(openXmlElement, value?.Outline);
    SetEffectList(openXmlElement, value?.EffectList);
    SetEffectDag(openXmlElement, value?.EffectDag);
    SetScene3DType(openXmlElement, value?.Scene3DType);
    SetShape3DType(openXmlElement, value?.Shape3DType);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
