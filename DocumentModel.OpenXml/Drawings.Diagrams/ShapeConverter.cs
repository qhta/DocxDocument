namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Double? GetRotation(DXDD.Shape openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXDD.Shape openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXDD.Shape openXmlElement, Double? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Shape Type
  /// </summary>
  private static String? GetType(DXDD.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Type);
  }
  
  private static bool CmpType(DXDD.Shape openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Type, value, diffs, objName, "Type");
  }
  
  private static void SetType(DXDD.Shape openXmlElement, String? value)
  {
    openXmlElement.Type = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Relationship to Image Part
  /// </summary>
  private static String? GetBlip(DXDD.Shape openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Blip);
  }
  
  private static bool CmpBlip(DXDD.Shape openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Blip, value, diffs, objName, "Blip");
  }
  
  private static void SetBlip(DXDD.Shape openXmlElement, String? value)
  {
    openXmlElement.Blip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Z-Order Offset
  /// </summary>
  private static Int32? GetZOrderOffset(DXDD.Shape openXmlElement)
  {
    return openXmlElement?.ZOrderOffset?.Value;
  }
  
  private static bool CmpZOrderOffset(DXDD.Shape openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ZOrderOffset?.Value == value) return true;
    diffs?.Add(objName, "ZOrderOffset", openXmlElement?.ZOrderOffset?.Value, value);
    return false;
  }
  
  private static void SetZOrderOffset(DXDD.Shape openXmlElement, Int32? value)
  {
    openXmlElement.ZOrderOffset = value;
  }
  
  /// <summary>
  /// Hide Geometry
  /// </summary>
  private static Boolean? GetHideGeometry(DXDD.Shape openXmlElement)
  {
    return openXmlElement?.HideGeometry?.Value;
  }
  
  private static bool CmpHideGeometry(DXDD.Shape openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HideGeometry?.Value == value) return true;
    diffs?.Add(objName, "HideGeometry", openXmlElement?.HideGeometry?.Value, value);
    return false;
  }
  
  private static void SetHideGeometry(DXDD.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HideGeometry = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HideGeometry = null;
  }
  
  /// <summary>
  /// Prevent Text Editing
  /// </summary>
  private static Boolean? GetLockedText(DXDD.Shape openXmlElement)
  {
    return openXmlElement?.LockedText?.Value;
  }
  
  private static bool CmpLockedText(DXDD.Shape openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LockedText?.Value == value) return true;
    diffs?.Add(objName, "LockedText", openXmlElement?.LockedText?.Value, value);
    return false;
  }
  
  private static void SetLockedText(DXDD.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockedText = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LockedText = null;
  }
  
  /// <summary>
  /// Image Placeholder
  /// </summary>
  private static Boolean? GetBlipPlaceholder(DXDD.Shape openXmlElement)
  {
    return openXmlElement?.BlipPlaceholder?.Value;
  }
  
  private static bool CmpBlipPlaceholder(DXDD.Shape openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BlipPlaceholder?.Value == value) return true;
    diffs?.Add(objName, "BlipPlaceholder", openXmlElement?.BlipPlaceholder?.Value, value);
    return false;
  }
  
  private static void SetBlipPlaceholder(DXDD.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BlipPlaceholder = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.BlipPlaceholder = null;
  }
  
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  private static DMDD.AdjustList? GetAdjustList(DXDD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.AdjustList>();
    if (element != null)
      return DMXDD.AdjustListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAdjustList(DXDD.Shape openXmlElement, DMDD.AdjustList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.AdjustListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.AdjustList>(), value, diffs, objName);
  }
  
  private static void SetAdjustList(DXDD.Shape openXmlElement, DMDD.AdjustList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.AdjustList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.AdjustListConverter.CreateOpenXmlElement<DXDD.AdjustList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDD.ExtensionList? GetExtensionList(DXDD.Shape openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.Shape openXmlElement, DMDD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDD.Shape openXmlElement, DMDD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ExtensionListConverter.CreateOpenXmlElement<DXDD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Shape? CreateModelElement(DXDD.Shape? openXmlElement)
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
  
  public static bool CompareModelElement(DXDD.Shape? openXmlElement, DMDD.Shape? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Shape value)
    where OpenXmlElementType: DXDD.Shape, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Shape openXmlElement, DMDD.Shape value)
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
