namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Layout Properties.
/// </summary>
public static class ShapeLayoutConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.ShapeLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVmlO.ShapeLayout openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtension(DXVmlO.ShapeLayout openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Shape ID Map.
  /// </summary>
  private static DMVml.ShapeIdMap? GetShapeIdMap(DXVmlO.ShapeLayout openXmlElement)
  {
    return DMXVml.ShapeIdMapConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.ShapeIdMap>());
  }
  
  private static bool CmpShapeIdMap(DXVmlO.ShapeLayout openXmlElement, DMVml.ShapeIdMap? value, DiffList? diffs, string? objName)
  {
    return DMXVml.ShapeIdMapConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVmlO.ShapeIdMap>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeIdMap(DXVmlO.ShapeLayout openXmlElement, DMVml.ShapeIdMap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.ShapeIdMap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.ShapeIdMapConverter.CreateOpenXmlElement<DXVmlO.ShapeIdMap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  private static DMVml.RegroupTable? GetRegroupTable(DXVmlO.ShapeLayout openXmlElement)
  {
    return DMXVml.RegroupTableConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.RegroupTable>());
  }
  
  private static bool CmpRegroupTable(DXVmlO.ShapeLayout openXmlElement, DMVml.RegroupTable? value, DiffList? diffs, string? objName)
  {
    return DMXVml.RegroupTableConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVmlO.RegroupTable>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRegroupTable(DXVmlO.ShapeLayout openXmlElement, DMVml.RegroupTable? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.RegroupTable>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.RegroupTableConverter.CreateOpenXmlElement<DXVmlO.RegroupTable>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  private static DMVml.Rules? GetRules(DXVmlO.ShapeLayout openXmlElement)
  {
    return DMXVml.RulesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVmlO.Rules>());
  }
  
  private static bool CmpRules(DXVmlO.ShapeLayout openXmlElement, DMVml.Rules? value, DiffList? diffs, string? objName)
  {
    return DMXVml.RulesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXVmlO.Rules>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRules(DXVmlO.ShapeLayout openXmlElement, DMVml.Rules? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.Rules>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.RulesConverter.CreateOpenXmlElement<DXVmlO.Rules>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMVml.ShapeLayout? CreateModelElement(DXVmlO.ShapeLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.ShapeLayout();
      value.Extension = GetExtension(openXmlElement);
      value.ShapeIdMap = GetShapeIdMap(openXmlElement);
      value.RegroupTable = GetRegroupTable(openXmlElement);
      value.Rules = GetRules(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.ShapeLayout? openXmlElement, DMVml.ShapeLayout? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpShapeIdMap(openXmlElement, value.ShapeIdMap, diffs, objName))
        ok = false;
      if (!CmpRegroupTable(openXmlElement, value.RegroupTable, diffs, objName))
        ok = false;
      if (!CmpRules(openXmlElement, value.Rules, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.ShapeLayout? value)
    where OpenXmlElementType: DXVmlO.ShapeLayout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetShapeIdMap(openXmlElement, value?.ShapeIdMap);
      SetRegroupTable(openXmlElement, value?.RegroupTable);
      SetRules(openXmlElement, value?.Rules);
      return openXmlElement;
    }
    return default;
  }
}
