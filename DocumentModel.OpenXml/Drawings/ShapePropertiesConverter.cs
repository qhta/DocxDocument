namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Visual Properties.
/// </summary>
public static class ShapePropertiesConverter
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  private static DMD.BlackWhiteMode? GetBlackWhiteMode(DXD.ShapeProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXD.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value);
  }
  
  private static bool CmpBlackWhiteMode(DXD.ShapeProperties openXmlElement, DMD.BlackWhiteMode? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXD.BlackWhiteModeValues, DMD.BlackWhiteMode>(openXmlElement?.BlackWhiteMode?.Value, model, diffs, objName, propName);
  }
  
  private static void SetBlackWhiteMode(DXD.ShapeProperties openXmlElement, DMD.BlackWhiteMode? model)
  {
    openXmlElement.BlackWhiteMode = EnumValueConverter.CreateEnumValue<DXD.BlackWhiteModeValues, DMD.BlackWhiteMode>(model);
  }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  private static DMD.Transform2D? GetTransform2D(DXD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Transform2D>();
    if (element != null)
      return DMXD.Transform2DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform2D(DXD.ShapeProperties openXmlElement, DMD.Transform2D? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Transform2DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Transform2D>(), model, diffs, objName, propName);
  }
  
  private static void SetTransform2D(DXD.ShapeProperties openXmlElement, DMD.Transform2D? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Transform2D>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.Transform2DConverter.CreateOpenXmlElement<DXD.Transform2D>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.CustomGeometry? GetCustomGeometry(DXD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomGeometry>();
    if (element != null)
      return DMXD.CustomGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomGeometry(DXD.ShapeProperties openXmlElement, DMD.CustomGeometry? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.CustomGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomGeometry>(), model, diffs, objName, propName);
  }
  
  private static void SetCustomGeometry(DXD.ShapeProperties openXmlElement, DMD.CustomGeometry? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CustomGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.CustomGeometryConverter.CreateOpenXmlElement<DXD.CustomGeometry>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PresetGeometry? GetPresetGeometry(DXD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetGeometry>();
    if (element != null)
      return DMXD.PresetGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetGeometry(DXD.ShapeProperties openXmlElement, DMD.PresetGeometry? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PresetGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetGeometry>(), model, diffs, objName, propName);
  }
  
  private static void SetPresetGeometry(DXD.ShapeProperties openXmlElement, DMD.PresetGeometry? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.PresetGeometryConverter.CreateOpenXmlElement<DXD.PresetGeometry>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LineProperties? GetOutline(DXD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Outline>();
    if (element != null)
      return DMXD.LinePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOutline(DXD.ShapeProperties openXmlElement, DMD.LineProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Outline>(), model, diffs, objName, propName);
  }
  
  private static void SetOutline(DXD.ShapeProperties openXmlElement, DMD.LineProperties? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Outline>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.LinePropertiesConverter.CreateOpenXmlElement<DXD.Outline>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EffectList? GetEffectList(DXD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectList>();
    if (element != null)
      return DMXD.EffectListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectList(DXD.ShapeProperties openXmlElement, DMD.EffectList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectList>(), model, diffs, objName, propName);
  }
  
  private static void SetEffectList(DXD.ShapeProperties openXmlElement, DMD.EffectList? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectList>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.EffectListConverter.CreateOpenXmlElement<DXD.EffectList>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EffectDag? GetEffectDag(DXD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectDag>();
    if (element != null)
      return DMXD.EffectDagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectDag(DXD.ShapeProperties openXmlElement, DMD.EffectDag? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectDagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectDag>(), model, diffs, objName, propName);
  }
  
  private static void SetEffectDag(DXD.ShapeProperties openXmlElement, DMD.EffectDag? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectDag>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.EffectDagConverter.CreateOpenXmlElement<DXD.EffectDag>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Scene3DType? GetScene3DType(DXD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Scene3DType>();
    if (element != null)
      return DMXD.Scene3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3DType(DXD.ShapeProperties openXmlElement, DMD.Scene3DType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Scene3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Scene3DType>(), model, diffs, objName, propName);
  }
  
  private static void SetScene3DType(DXD.ShapeProperties openXmlElement, DMD.Scene3DType? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Scene3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.Scene3DTypeConverter.CreateOpenXmlElement<DXD.Scene3DType>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Shape3DType? GetShape3DType(DXD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Shape3DType>();
    if (element != null)
      return DMXD.Shape3DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape3DType(DXD.ShapeProperties openXmlElement, DMD.Shape3DType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Shape3DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Shape3DType>(), model, diffs, objName, propName);
  }
  
  private static void SetShape3DType(DXD.ShapeProperties openXmlElement, DMD.Shape3DType? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.Shape3DTypeConverter.CreateOpenXmlElement<DXD.Shape3DType>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ShapePropertiesExtensionList? GetShapePropertiesExtensionList(DXD.ShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapePropertiesExtensionList>();
    if (element != null)
      return DMXD.ShapePropertiesExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapePropertiesExtensionList(DXD.ShapeProperties openXmlElement, DMD.ShapePropertiesExtensionList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ShapePropertiesExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapePropertiesExtensionList>(), model, diffs, objName, propName);
  }
  
  private static void SetShapePropertiesExtensionList(DXD.ShapeProperties openXmlElement, DMD.ShapePropertiesExtensionList? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ShapePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.ShapePropertiesExtensionListConverter.CreateOpenXmlElement<DXD.ShapePropertiesExtensionList>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ShapeProperties? CreateModelElement(DXD.ShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.ShapeProperties();
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
  
  public static bool CompareModelElement(DXD.ShapeProperties? openXmlElement, DMD.ShapeProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ShapeProperties model)
    where OpenXmlElementType: DXD.ShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ShapeProperties openXmlElement, DMD.ShapeProperties model)
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
