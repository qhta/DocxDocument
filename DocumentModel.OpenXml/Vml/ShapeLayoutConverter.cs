namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Layout Properties.
/// </summary>
public static class ShapeLayoutConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.ShapeLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.ShapeLayout openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName, propName);
  }
  
  private static void SetExtension(DXVO.ShapeLayout openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Shape ID Map.
  /// </summary>
  private static DMV.ShapeIdMap? GetShapeIdMap(DXVO.ShapeLayout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ShapeIdMap>();
    if (element != null)
      return DMXV.ShapeIdMapConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeIdMap(DXVO.ShapeLayout openXmlElement, DMV.ShapeIdMap? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.ShapeIdMapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ShapeIdMap>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeIdMap(DXVO.ShapeLayout openXmlElement, DMV.ShapeIdMap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.ShapeIdMap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.ShapeIdMapConverter.CreateOpenXmlElement<DXVO.ShapeIdMap>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  private static DMV.RegroupTable? GetRegroupTable(DXVO.ShapeLayout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.RegroupTable>();
    if (element != null)
      return DMXV.RegroupTableConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRegroupTable(DXVO.ShapeLayout openXmlElement, DMV.RegroupTable? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.RegroupTableConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.RegroupTable>(), value, diffs, objName, propName);
  }
  
  private static void SetRegroupTable(DXVO.ShapeLayout openXmlElement, DMV.RegroupTable? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.RegroupTable>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.RegroupTableConverter.CreateOpenXmlElement<DXVO.RegroupTable>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  private static DMV.Rules? GetRules(DXVO.ShapeLayout openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.Rules>();
    if (element != null)
      return DMXV.RulesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRules(DXVO.ShapeLayout openXmlElement, DMV.Rules? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXV.RulesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.Rules>(), value, diffs, objName, propName);
  }
  
  private static void SetRules(DXVO.ShapeLayout openXmlElement, DMV.Rules? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.Rules>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.RulesConverter.CreateOpenXmlElement<DXVO.Rules>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.ShapeLayout? CreateModelElement(DXVO.ShapeLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeLayout();
      value.Extension = GetExtension(openXmlElement);
      value.ShapeIdMap = GetShapeIdMap(openXmlElement);
      value.RegroupTable = GetRegroupTable(openXmlElement);
      value.Rules = GetRules(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVO.ShapeLayout? openXmlElement, DMV.ShapeLayout? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName, propName))
        ok = false;
      if (!CmpShapeIdMap(openXmlElement, value.ShapeIdMap, diffs, objName, propName))
        ok = false;
      if (!CmpRegroupTable(openXmlElement, value.RegroupTable, diffs, objName, propName))
        ok = false;
      if (!CmpRules(openXmlElement, value.Rules, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.ShapeLayout value)
    where OpenXmlElementType: DXVO.ShapeLayout, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.ShapeLayout openXmlElement, DMV.ShapeLayout value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetShapeIdMap(openXmlElement, value?.ShapeIdMap);
    SetRegroupTable(openXmlElement, value?.RegroupTable);
    SetRules(openXmlElement, value?.Rules);
  }
}
