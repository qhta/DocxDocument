namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the ShapeProperties Class.
/// </summary>
public static class ShapePropertiesConverter
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  private static DMDraws.BlackWhiteMode? GetBlackWhiteMode(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.BlackWhiteMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlackWhiteMode(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.BlackWhiteMode? value)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMDraws.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  private static DMDraws.Transform2D? GetTransform2D(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.Transform2DConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Transform2D>());
  }
  
  private static bool CmpTransform2D(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.Transform2D? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Transform2DConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Transform2D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTransform2D(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.Transform2D? value)
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
  
  private static DMDraws.CustomGeometry? GetCustomGeometry(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.CustomGeometryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.CustomGeometry>());
  }
  
  private static bool CmpCustomGeometry(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.CustomGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CustomGeometryConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.CustomGeometry>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomGeometry(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.CustomGeometry? value)
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
  
  private static DMDraws.PresetGeometry? GetPresetGeometry(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.PresetGeometryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetGeometry>());
  }
  
  private static bool CmpPresetGeometry(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.PresetGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetGeometryConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetGeometry>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetGeometry(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.PresetGeometry? value)
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
  
  private static Boolean? GetNoFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoFill>() != null;
  }
  
  private static bool CmpNoFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.NoFill>() != null == value;
  }
  
  private static void SetNoFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, Boolean? value)
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
  
  private static DMDraws.SolidFill? GetSolidFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.SolidFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SolidFill>());
  }
  
  private static bool CmpSolidFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.SolidFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SolidFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SolidFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSolidFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.SolidFill? value)
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
  
  private static DMDraws.GradientFill? GetGradientFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.GradientFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.GradientFill>());
  }
  
  private static bool CmpGradientFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.GradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GradientFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.GradientFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGradientFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.GradientFill? value)
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
  
  private static DMDraws.BlipFill? GetBlipFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.BlipFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.BlipFill>());
  }
  
  private static bool CmpBlipFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlipFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.BlipFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlipFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.BlipFill? value)
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
  
  private static DMDraws.PatternFill? GetPatternFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.PatternFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PatternFill>());
  }
  
  private static bool CmpPatternFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.PatternFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PatternFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.PatternFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPatternFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.PatternFill? value)
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
  
  private static Boolean? GetGroupFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.GroupFill>() != null;
  }
  
  private static bool CmpGroupFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.GroupFill>() != null == value;
  }
  
  private static void SetGroupFill(DXO2013DrawChartStyle.ShapeProperties openXmlElement, Boolean? value)
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
  
  private static DMDraws.Outline? GetOutline(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.OutlineConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Outline>());
  }
  
  private static bool CmpOutline(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.Outline? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OutlineConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Outline>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOutline(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.Outline? value)
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
  
  private static DMDraws.EffectList? GetEffectList(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.EffectListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectList>());
  }
  
  private static bool CmpEffectList(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.EffectList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectList(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.EffectList? value)
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
  
  private static DMDraws.EffectDag? GetEffectDag(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.EffectDagConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectDag>());
  }
  
  private static bool CmpEffectDag(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.EffectDag? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectDagConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectDag>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectDag(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.EffectDag? value)
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
  
  private static DMDraws.Scene3DType? GetScene3DType(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.Scene3DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Scene3DType>());
  }
  
  private static bool CmpScene3DType(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.Scene3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Scene3DTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Scene3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScene3DType(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.Scene3DType? value)
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
  
  private static DMDraws.Shape3DType? GetShape3DType(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.Shape3DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Shape3DType>());
  }
  
  private static bool CmpShape3DType(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.Shape3DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Shape3DTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Shape3DType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape3DType(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.Shape3DType? value)
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
  
  private static DMDraws.ShapePropertiesExtensionList? GetShapePropertiesExtensionList(DXO2013DrawChartStyle.ShapeProperties openXmlElement)
  {
    return DMXDraws.ShapePropertiesExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ShapePropertiesExtensionList>());
  }
  
  private static bool CmpShapePropertiesExtensionList(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.ShapePropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapePropertiesExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ShapePropertiesExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapePropertiesExtensionList(DXO2013DrawChartStyle.ShapeProperties openXmlElement, DMDraws.ShapePropertiesExtensionList? value)
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
  
  public static DMDrawsChartsStyle.ShapeProperties? CreateModelElement(DXO2013DrawChartStyle.ShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartsStyle.ShapeProperties();
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
  
  public static bool CompareModelElement(DXO2013DrawChartStyle.ShapeProperties? openXmlElement, DMDrawsChartsStyle.ShapeProperties? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.ShapeProperties? value)
    where OpenXmlElementType: DXO2013DrawChartStyle.ShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
