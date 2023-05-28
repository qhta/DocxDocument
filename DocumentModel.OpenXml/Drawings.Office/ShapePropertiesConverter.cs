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
  
  private static bool CmpBlackWhiteMode(DXOD.ShapeProperties openXmlElement, DMD.BlackWhiteMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, value, diffs, objName, propName);
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
  
  private static bool CmpTransform2D(DXOD.ShapeProperties openXmlElement, DMD.Transform2D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Transform2D>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.CustomGeometry? GetCustomGeometry(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomGeometry>();
    if (element != null)
      return DMXD.CustomGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomGeometry(DXOD.ShapeProperties openXmlElement, DMD.CustomGeometry? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.CustomGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomGeometry>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PresetGeometry? GetPresetGeometry(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetGeometry>();
    if (element != null)
      return DMXD.PresetGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetGeometry(DXOD.ShapeProperties openXmlElement, DMD.PresetGeometry? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PresetGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetGeometry>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LineProperties? GetOutline(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.LinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXOD.ShapeProperties openXmlElement, DMD.LineProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), value, diffs, objName, propName);
  }
  
  private static void SetOutline(DXOD.ShapeProperties openXmlElement, DMD.LineProperties? value)
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
  
  private static DMD.EffectList? GetEffectList(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectList>();
    if (element != null)
      return DMXD.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXOD.ShapeProperties openXmlElement, DMD.EffectList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EffectDag? GetEffectDag(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectDag>();
    if (element != null)
      return DMXD.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXOD.ShapeProperties openXmlElement, DMD.EffectDag? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Scene3DType? GetScene3DType(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Scene3DType>();
    if (element != null)
      return DMXD.Scene3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3DType(DXOD.ShapeProperties openXmlElement, DMD.Scene3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Scene3DType>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Shape3DType? GetShape3DType(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Shape3DType>();
    if (element != null)
      return DMXD.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXOD.ShapeProperties openXmlElement, DMD.Shape3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Shape3DType>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ShapePropertiesExtensionList? GetShapePropertiesExtensionList(DXOD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapePropertiesExtensionList>();
    if (element != null)
      return DMXD.ShapePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapePropertiesExtensionList(DXOD.ShapeProperties openXmlElement, DMD.ShapePropertiesExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ShapePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapePropertiesExtensionList>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDO.ShapeProperties? CreateModelElement(DXOD.ShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMDO.ShapeProperties();
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
      model.ShapePropertiesExtensionList = GetShapePropertiesExtensionList(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOD.ShapeProperties? openXmlElement, DMDO.ShapeProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
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
      if (!FillConverter.CompareFillModel(openXmlElement, model.Fill, diffs, objName, propName))
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
      if (!CmpShapePropertiesExtensionList(openXmlElement, model.ShapePropertiesExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.ShapeProperties model)
    where OpenXmlElementType: DXOD.ShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.ShapeProperties openXmlElement, DMDO.ShapeProperties model)
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
    SetShapePropertiesExtensionList(openXmlElement, model.ShapePropertiesExtensionList);
  }
}
