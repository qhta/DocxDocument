namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartShapeProperties Class.
/// </summary>
public static class ChartShapePropertiesConverter
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  private static DMDraws.BlackWhiteMode? GetBlackWhiteMode(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.BlackWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlackWhiteMode(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.BlackWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  private static DMDraws.Transform2D? GetTransform2D(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Transform2D>();
    if (element != null)
      return DMXDraws.Transform2DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform2D(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.Transform2D? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Transform2D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTransform2D(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.Transform2D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Transform2D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Transform2DConverter.CreateOpenXmlElement<DXDraw.Transform2D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.CustomGeometry? GetCustomGeometry(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.CustomGeometry>();
    if (element != null)
      return DMXDraws.CustomGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomGeometry(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.CustomGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CustomGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.CustomGeometry>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomGeometry(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.CustomGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.CustomGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CustomGeometryConverter.CreateOpenXmlElement<DXDraw.CustomGeometry>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PresetGeometry? GetPresetGeometry(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PresetGeometry>();
    if (element != null)
      return DMXDraws.PresetGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetGeometry(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.PresetGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PresetGeometry>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetGeometry(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.PresetGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PresetGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PresetGeometryConverter.CreateOpenXmlElement<DXDraw.PresetGeometry>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetNoFill(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXDrawCharts.ChartShapeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXDrawCharts.ChartShapeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.NoFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.SolidFill? GetSolidFill(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SolidFill>();
    if (element != null)
      return DMXDraws.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SolidFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSolidFill(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.SolidFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SolidFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SolidFillConverter.CreateOpenXmlElement<DXDraw.SolidFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.GradientFill? GetGradientFill(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.GradientFill>();
    if (element != null)
      return DMXDraws.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.GradientFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGradientFill(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.GradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GradientFillConverter.CreateOpenXmlElement<DXDraw.GradientFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BlipFill? GetBlipFill(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BlipFill>();
    if (element != null)
      return DMXDraws.BlipFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipFill(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BlipFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlipFill(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlipFillConverter.CreateOpenXmlElement<DXDraw.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PatternFill? GetPatternFill(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PatternFill>();
    if (element != null)
      return DMXDraws.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PatternFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPatternFill(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.PatternFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PatternFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PatternFillConverter.CreateOpenXmlElement<DXDraw.PatternFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Outline? GetOutline(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Outline>();
    if (element != null)
      return DMXDraws.OutlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.Outline? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OutlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Outline>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOutline(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.Outline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OutlineConverter.CreateOpenXmlElement<DXDraw.Outline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.EffectList? GetEffectList(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectList>();
    if (element != null)
      return DMXDraws.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.EffectList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectList(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.EffectList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectListConverter.CreateOpenXmlElement<DXDraw.EffectList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.EffectDag? GetEffectDag(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectDag>();
    if (element != null)
      return DMXDraws.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.EffectDag? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectDag>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectDag(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.EffectDag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectDagConverter.CreateOpenXmlElement<DXDraw.EffectDag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Scene3DType? GetScene3DType(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Scene3DType>();
    if (element != null)
      return DMXDraws.Scene3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3DType(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.Scene3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Scene3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScene3DType(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.Scene3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Scene3DTypeConverter.CreateOpenXmlElement<DXDraw.Scene3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Shape3DType? GetShape3DType(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Shape3DType>();
    if (element != null)
      return DMXDraws.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.Shape3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Shape3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape3DType(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Shape3DTypeConverter.CreateOpenXmlElement<DXDraw.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ExtensionList? GetExtensionList(DXDrawCharts.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.ChartShapeProperties openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? CreateModelElement(DXDrawCharts.ChartShapeProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawCharts.ChartShapeProperties? openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartShapeProperties value)
    where OpenXmlElementType: DXDrawCharts.ChartShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ChartShapeProperties openXmlElement, DMDrawsCharts.ChartShapeProperties value)
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
