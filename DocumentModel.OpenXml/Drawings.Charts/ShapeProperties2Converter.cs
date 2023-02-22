namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ShapeProperties Class.
/// </summary>
public static class ShapeProperties2Converter
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  private static DMDraws.BlackWhiteMode? GetBlackWhiteMode(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.BlackWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlackWhiteMode(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.BlackWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  private static DMDraws.Transform2D? GetTransform2D(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Transform2D>();
    if (element != null)
      return DMXDraws.Transform2DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform2D(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.Transform2D? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Transform2D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTransform2D(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.Transform2D? value)
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
  
  private static DMDraws.CustomGeometry? GetCustomGeometry(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.CustomGeometry>();
    if (element != null)
      return DMXDraws.CustomGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomGeometry(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.CustomGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CustomGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.CustomGeometry>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomGeometry(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.CustomGeometry? value)
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
  
  private static DMDraws.PresetGeometry? GetPresetGeometry(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PresetGeometry>();
    if (element != null)
      return DMXDraws.PresetGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetGeometry(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.PresetGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PresetGeometry>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetGeometry(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.PresetGeometry? value)
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
  
  private static Boolean? GetNoFill(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXO2010DrawCharts.ShapeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.NoFill", val, value);
    return false;
  }
  
  private static void SetNoFill(DXO2010DrawCharts.ShapeProperties openXmlElement, Boolean? value)
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
  
  private static DMDraws.SolidFill? GetSolidFill(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SolidFill>();
    if (element != null)
      return DMXDraws.SolidFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSolidFill(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SolidFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SolidFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSolidFill(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.SolidFill? value)
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
  
  private static DMDraws.GradientFill? GetGradientFill(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.GradientFill>();
    if (element != null)
      return DMXDraws.GradientFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGradientFill(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.GradientFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGradientFill(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.GradientFill? value)
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
  
  private static DMDraws.BlipFill? GetBlipFill(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BlipFill>();
    if (element != null)
      return DMXDraws.BlipFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipFill(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BlipFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlipFill(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.BlipFill? value)
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
  
  private static DMDraws.PatternFill? GetPatternFill(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.PatternFill>();
    if (element != null)
      return DMXDraws.PatternFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPatternFill(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PatternFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.PatternFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPatternFill(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.PatternFill? value)
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
  
  private static Boolean? GetGroupFill(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.GroupFill>() != null;
  }
  
  private static bool CmpGroupFill(DXO2010DrawCharts.ShapeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.GroupFill>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.GroupFill", val, value);
    return false;
  }
  
  private static void SetGroupFill(DXO2010DrawCharts.ShapeProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.GroupFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Outline? GetOutline(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Outline>();
    if (element != null)
      return DMXDraws.OutlineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.Outline? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OutlineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Outline>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOutline(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.Outline? value)
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
  
  private static DMDraws.EffectList? GetEffectList(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectList>();
    if (element != null)
      return DMXDraws.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.EffectList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectList(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.EffectList? value)
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
  
  private static DMDraws.EffectDag? GetEffectDag(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.EffectDag>();
    if (element != null)
      return DMXDraws.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.EffectDag? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectDag>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectDag(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.EffectDag? value)
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
  
  private static DMDraws.Scene3DType? GetScene3DType(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Scene3DType>();
    if (element != null)
      return DMXDraws.Scene3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3DType(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.Scene3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Scene3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScene3DType(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.Scene3DType? value)
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
  
  private static DMDraws.Shape3DType? GetShape3DType(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Shape3DType>();
    if (element != null)
      return DMXDraws.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.Shape3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Shape3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape3DType(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.Shape3DType? value)
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
  
  private static DMDraws.ShapePropertiesExtensionList? GetShapePropertiesExtensionList(DXO2010DrawCharts.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ShapePropertiesExtensionList>();
    if (element != null)
      return DMXDraws.ShapePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapePropertiesExtensionList(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.ShapePropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ShapePropertiesExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapePropertiesExtensionList(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDraws.ShapePropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ShapePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ShapePropertiesExtensionListConverter.CreateOpenXmlElement<DXDraw.ShapePropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ShapeProperties2? CreateModelElement(DXO2010DrawCharts.ShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ShapeProperties2();
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
  
  public static bool CompareModelElement(DXO2010DrawCharts.ShapeProperties? openXmlElement, DMDrawsCharts.ShapeProperties2? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ShapeProperties2 value)
    where OpenXmlElementType: DXO2010DrawCharts.ShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010DrawCharts.ShapeProperties openXmlElement, DMDrawsCharts.ShapeProperties2 value)
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
