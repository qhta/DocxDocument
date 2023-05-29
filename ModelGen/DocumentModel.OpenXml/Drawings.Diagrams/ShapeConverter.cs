namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Double? GetRotation(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXDrawDgms.Shape openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXDrawDgms.Shape openXmlElement, Double? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Shape Type
  /// </summary>
  private static String? GetType(DXDrawDgms.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Type);
  }
  
  private static bool CmpType(DXDrawDgms.Shape openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Type, value, diffs, objName, "Type");
  }
  
  private static void SetType(DXDrawDgms.Shape openXmlElement, String? value)
  {
    openXmlElement.Type = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Relationship to Image Part
  /// </summary>
  private static String? GetBlip(DXDrawDgms.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Blip);
  }
  
  private static bool CmpBlip(DXDrawDgms.Shape openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Blip, value, diffs, objName, "Blip");
  }
  
  private static void SetBlip(DXDrawDgms.Shape openXmlElement, String? value)
  {
    openXmlElement.Blip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Z-Order Offset
  /// </summary>
  private static Int32? GetZOrderOffset(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement?.ZOrderOffset?.Value;
  }
  
  private static bool CmpZOrderOffset(DXDrawDgms.Shape openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ZOrderOffset?.Value == value) return true;
    diffs?.Add(objName, "ZOrderOffset", openXmlElement?.ZOrderOffset?.Value, value);
    return false;
  }
  
  private static void SetZOrderOffset(DXDrawDgms.Shape openXmlElement, Int32? value)
  {
    openXmlElement.ZOrderOffset = value;
  }
  
  /// <summary>
  /// Hide Geometry
  /// </summary>
  private static Boolean? GetHideGeometry(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement?.HideGeometry?.Value;
  }
  
  private static bool CmpHideGeometry(DXDrawDgms.Shape openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HideGeometry?.Value == value) return true;
    diffs?.Add(objName, "HideGeometry", openXmlElement?.HideGeometry?.Value, value);
    return false;
  }
  
  private static void SetHideGeometry(DXDrawDgms.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HideGeometry = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HideGeometry = null;
  }
  
  /// <summary>
  /// Prevent Text Editing
  /// </summary>
  private static Boolean? GetLockedText(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement?.LockedText?.Value;
  }
  
  private static bool CmpLockedText(DXDrawDgms.Shape openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LockedText?.Value == value) return true;
    diffs?.Add(objName, "LockedText", openXmlElement?.LockedText?.Value, value);
    return false;
  }
  
  private static void SetLockedText(DXDrawDgms.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockedText = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LockedText = null;
  }
  
  /// <summary>
  /// Image Placeholder
  /// </summary>
  private static Boolean? GetBlipPlaceholder(DXDrawDgms.Shape openXmlElement)
  {
    return openXmlElement?.BlipPlaceholder?.Value;
  }
  
  private static bool CmpBlipPlaceholder(DXDrawDgms.Shape openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BlipPlaceholder?.Value == value) return true;
    diffs?.Add(objName, "BlipPlaceholder", openXmlElement?.BlipPlaceholder?.Value, value);
    return false;
  }
  
  private static void SetBlipPlaceholder(DXDrawDgms.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BlipPlaceholder = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BlipPlaceholder = null;
  }
  
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  private static DMDrawsDgms.AdjustList? GetAdjustList(DXDrawDgms.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.AdjustList>();
    if (element != null)
      return DMXDrawsDgms.AdjustListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAdjustList(DXDrawDgms.Shape openXmlElement, DMDrawsDgms.AdjustList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.AdjustListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.AdjustList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAdjustList(DXDrawDgms.Shape openXmlElement, DMDrawsDgms.AdjustList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.AdjustList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.AdjustListConverter.CreateOpenXmlElement<DXDrawDgms.AdjustList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (element != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawDgms.Shape openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.Shape openXmlElement, DMDrawsDgms.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Shape? CreateModelElement(DXDrawDgms.Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Shape();
      value.Rotation = GetRotation(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.Blip = GetBlip(openXmlElement);
      value.ZOrderOffset = GetZOrderOffset(openXmlElement);
      value.HideGeometry = GetHideGeometry(openXmlElement);
      value.LockedText = GetLockedText(openXmlElement);
      value.BlipPlaceholder = GetBlipPlaceholder(openXmlElement);
      value.AdjustList = GetAdjustList(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.Shape? openXmlElement, DMDrawsDgms.Shape? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpBlip(openXmlElement, value.Blip, diffs, objName))
        ok = false;
      if (!CmpZOrderOffset(openXmlElement, value.ZOrderOffset, diffs, objName))
        ok = false;
      if (!CmpHideGeometry(openXmlElement, value.HideGeometry, diffs, objName))
        ok = false;
      if (!CmpLockedText(openXmlElement, value.LockedText, diffs, objName))
        ok = false;
      if (!CmpBlipPlaceholder(openXmlElement, value.BlipPlaceholder, diffs, objName))
        ok = false;
      if (!CmpAdjustList(openXmlElement, value.AdjustList, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Shape value)
    where OpenXmlElementType: DXDrawDgms.Shape, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Shape openXmlElement, DMDrawsDgms.Shape value)
  {
    SetRotation(openXmlElement, value?.Rotation);
    SetType(openXmlElement, value?.Type);
    SetBlip(openXmlElement, value?.Blip);
    SetZOrderOffset(openXmlElement, value?.ZOrderOffset);
    SetHideGeometry(openXmlElement, value?.HideGeometry);
    SetLockedText(openXmlElement, value?.LockedText);
    SetBlipPlaceholder(openXmlElement, value?.BlipPlaceholder);
    SetAdjustList(openXmlElement, value?.AdjustList);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
