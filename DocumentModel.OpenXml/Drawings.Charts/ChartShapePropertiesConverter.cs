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
  
  private static bool CmpBlackWhiteMode(DXDC.ChartShapeProperties openXmlElement, DMD.BlackWhiteMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName, propName);
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
  
  private static bool CmpTransform2D(DXDC.ChartShapeProperties openXmlElement, DMD.Transform2D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Transform2D>(), value, diffs, objName, propName);
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
  
  private static bool CmpCustomGeometry(DXDC.ChartShapeProperties openXmlElement, DMD.CustomGeometry? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.CustomGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomGeometry>(), value, diffs, objName, propName);
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
  
  private static bool CmpPresetGeometry(DXDC.ChartShapeProperties openXmlElement, DMD.PresetGeometry? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PresetGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetGeometry>(), value, diffs, objName, propName);
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
  
  private static DMD.LineProperties? GetOutline(DXDC.ChartShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.LinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXDC.ChartShapeProperties openXmlElement, DMD.LineProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), value, diffs, objName, propName);
  }
  
  private static void SetOutline(DXDC.ChartShapeProperties openXmlElement, DMD.LineProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LinePropertiesConverter.CreateOpenXmlElement<DXD.Outline>(value);
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
  
  private static bool CmpEffectList(DXDC.ChartShapeProperties openXmlElement, DMD.EffectList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), value, diffs, objName, propName);
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
  
  private static bool CmpEffectDag(DXDC.ChartShapeProperties openXmlElement, DMD.EffectDag? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), value, diffs, objName, propName);
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
  
  private static bool CmpScene3DType(DXDC.ChartShapeProperties openXmlElement, DMD.Scene3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Scene3DType>(), value, diffs, objName, propName);
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
  
  private static bool CmpShape3DType(DXDC.ChartShapeProperties openXmlElement, DMD.Shape3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Shape3DType>(), value, diffs, objName, propName);
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
  
  private static bool CmpExtensionList(DXDC.ChartShapeProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.ChartShapeProperties openXmlElement, DMD.ExtensionList? value)
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
  
  public static DMDC.ChartShapeProperties? CreateModelElement(DXDC.ChartShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMDC.ChartShapeProperties();
      model.BlackWhiteMode = GetBlackWhiteMode(openXmlElement);
      model.Transform2D = GetTransform2D(openXmlElement);
      model.CustomGeometry = GetCustomGeometry(openXmlElement);
      model.PresetGeometry = GetPresetGeometry(openXmlElement);
      model.Fill = FillConverter.CreateFillModel(openXmlElement);
      model.Outline = GetOutline(openXmlElement);
      model.EffectList = GetEffectList(openXmlElement);
      model.EffectDag = GetEffectDag(openXmlElement);
      model.Scene3DType = GetScene3DType(openXmlElement);
      model.Shape3DType = GetShape3DType(openXmlElement);
      model.ExtensionList = GetExtensionList(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ChartShapeProperties? openXmlElement, DMDC.ChartShapeProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpBlackWhiteMode(openXmlElement, model.BlackWhiteMode, diffs, objName, propName))
        ok = false;
      if (!CmpTransform2D(openXmlElement, model.Transform2D, diffs, objName, propName))
        ok = false;
      if (!CmpCustomGeometry(openXmlElement, model.CustomGeometry, diffs, objName, propName))
        ok = false;
      if (!CmpPresetGeometry(openXmlElement, model.PresetGeometry, diffs, objName, propName))
        ok = false;
      if (!FillConverter.CompareFill(openXmlElement, model.Fill, diffs, objName, propName))
        ok = false;
      if (!CmpOutline(openXmlElement, model.Outline, diffs, objName, propName))
        ok = false;
      if (!CmpEffectList(openXmlElement, model.EffectList, diffs, objName, propName))
        ok = false;
      if (!CmpEffectDag(openXmlElement, model.EffectDag, diffs, objName, propName))
        ok = false;
      if (!CmpScene3DType(openXmlElement, model.Scene3DType, diffs, objName, propName))
        ok = false;
      if (!CmpShape3DType(openXmlElement, model.Shape3DType, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, model.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ChartShapeProperties model)
    where OpenXmlElementType: DXDC.ChartShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ChartShapeProperties openXmlElement, DMDC.ChartShapeProperties model)
  {
    SetBlackWhiteMode(openXmlElement, model.BlackWhiteMode);
    SetTransform2D(openXmlElement, model.Transform2D);
    SetCustomGeometry(openXmlElement, model.CustomGeometry);
    SetPresetGeometry(openXmlElement, model.PresetGeometry);
    FillConverter.UpdateOpenXmlElement(openXmlElement, model.Fill);
    SetOutline(openXmlElement, model.Outline);
    SetEffectList(openXmlElement, model.EffectList);
    SetEffectDag(openXmlElement, model.EffectDag);
    SetScene3DType(openXmlElement, model.Scene3DType);
    SetShape3DType(openXmlElement, model.Shape3DType);
    SetExtensionList(openXmlElement, model.ExtensionList);
  }
}
