namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Lock Class converter from/to OpenXml.
///</summary>
public static class LockConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.Lock openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVmlO.Lock openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName);
  }
  
  private static void SetExtension(DXVmlO.Lock openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Position Lock
  /// </summary>
  private static Boolean? GetPosition(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  private static bool CmpPosition(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Position?.Value == value) return true;
    diffs?.Add(objName, "Position", openXmlElement?.Position?.Value, value);
    return false;
  }
  
  private static void SetPosition(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Position = value;
    else
      openXmlElement.Position = null;
  }
  
  /// <summary>
  /// Selection Lock
  /// </summary>
  private static Boolean? GetSelection(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.Selection?.Value;
  }
  
  private static bool CmpSelection(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Selection?.Value == value) return true;
    diffs?.Add(objName, "Selection", openXmlElement?.Selection?.Value, value);
    return false;
  }
  
  private static void SetSelection(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Selection = value;
    else
      openXmlElement.Selection = null;
  }
  
  /// <summary>
  /// Grouping Lock
  /// </summary>
  private static Boolean? GetGrouping(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.Grouping?.Value;
  }
  
  private static bool CmpGrouping(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Grouping?.Value == value) return true;
    diffs?.Add(objName, "Grouping", openXmlElement?.Grouping?.Value, value);
    return false;
  }
  
  private static void SetGrouping(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Grouping = value;
    else
      openXmlElement.Grouping = null;
  }
  
  /// <summary>
  /// Ungrouping Lock
  /// </summary>
  private static Boolean? GetUngrouping(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.Ungrouping?.Value;
  }
  
  private static bool CmpUngrouping(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Ungrouping?.Value == value) return true;
    diffs?.Add(objName, "Ungrouping", openXmlElement?.Ungrouping?.Value, value);
    return false;
  }
  
  private static void SetUngrouping(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Ungrouping = value;
    else
      openXmlElement.Ungrouping = null;
  }
  
  /// <summary>
  /// Rotation Lock
  /// </summary>
  private static Boolean? GetRotation(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Rotation = value;
    else
      openXmlElement.Rotation = null;
  }
  
  /// <summary>
  /// Cropping Lock
  /// </summary>
  private static Boolean? GetCropping(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.Cropping?.Value;
  }
  
  private static bool CmpCropping(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Cropping?.Value == value) return true;
    diffs?.Add(objName, "Cropping", openXmlElement?.Cropping?.Value, value);
    return false;
  }
  
  private static void SetCropping(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Cropping = value;
    else
      openXmlElement.Cropping = null;
  }
  
  /// <summary>
  /// Vertices Lock
  /// </summary>
  private static Boolean? GetVerticies(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.Verticies?.Value;
  }
  
  private static bool CmpVerticies(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Verticies?.Value == value) return true;
    diffs?.Add(objName, "Verticies", openXmlElement?.Verticies?.Value, value);
    return false;
  }
  
  private static void SetVerticies(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Verticies = value;
    else
      openXmlElement.Verticies = null;
  }
  
  /// <summary>
  /// Handles Lock
  /// </summary>
  private static Boolean? GetAdjustHandles(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.AdjustHandles?.Value;
  }
  
  private static bool CmpAdjustHandles(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AdjustHandles?.Value == value) return true;
    diffs?.Add(objName, "AdjustHandles", openXmlElement?.AdjustHandles?.Value, value);
    return false;
  }
  
  private static void SetAdjustHandles(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AdjustHandles = value;
    else
      openXmlElement.AdjustHandles = null;
  }
  
  /// <summary>
  /// Text Lock
  /// </summary>
  private static Boolean? GetTextLock(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.TextLock?.Value;
  }
  
  private static bool CmpTextLock(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TextLock?.Value == value) return true;
    diffs?.Add(objName, "TextLock", openXmlElement?.TextLock?.Value, value);
    return false;
  }
  
  private static void SetTextLock(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextLock = value;
    else
      openXmlElement.TextLock = null;
  }
  
  /// <summary>
  /// Aspect Ratio Lock
  /// </summary>
  private static Boolean? GetAspectRatio(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.AspectRatio?.Value;
  }
  
  private static bool CmpAspectRatio(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AspectRatio?.Value == value) return true;
    diffs?.Add(objName, "AspectRatio", openXmlElement?.AspectRatio?.Value, value);
    return false;
  }
  
  private static void SetAspectRatio(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AspectRatio = value;
    else
      openXmlElement.AspectRatio = null;
  }
  
  /// <summary>
  /// AutoShape Type Lock
  /// </summary>
  private static Boolean? GetShapeType(DXVmlO.Lock openXmlElement)
  {
    return openXmlElement?.ShapeType?.Value;
  }
  
  private static bool CmpShapeType(DXVmlO.Lock openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShapeType?.Value == value) return true;
    diffs?.Add(objName, "ShapeType", openXmlElement?.ShapeType?.Value, value);
    return false;
  }
  
  private static void SetShapeType(DXVmlO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShapeType = value;
    else
      openXmlElement.ShapeType = null;
  }
  
  public static DocumentModel.Vml.Lock? CreateModelElement(DXVmlO.Lock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Lock();
      value.Extension = GetExtension(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.Selection = GetSelection(openXmlElement);
      value.Grouping = GetGrouping(openXmlElement);
      value.Ungrouping = GetUngrouping(openXmlElement);
      value.Rotation = GetRotation(openXmlElement);
      value.Cropping = GetCropping(openXmlElement);
      value.Verticies = GetVerticies(openXmlElement);
      value.AdjustHandles = GetAdjustHandles(openXmlElement);
      value.TextLock = GetTextLock(openXmlElement);
      value.AspectRatio = GetAspectRatio(openXmlElement);
      value.ShapeType = GetShapeType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.Lock? openXmlElement, DMVml.Lock? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      if (!CmpSelection(openXmlElement, value.Selection, diffs, objName))
        ok = false;
      if (!CmpGrouping(openXmlElement, value.Grouping, diffs, objName))
        ok = false;
      if (!CmpUngrouping(openXmlElement, value.Ungrouping, diffs, objName))
        ok = false;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName))
        ok = false;
      if (!CmpCropping(openXmlElement, value.Cropping, diffs, objName))
        ok = false;
      if (!CmpVerticies(openXmlElement, value.Verticies, diffs, objName))
        ok = false;
      if (!CmpAdjustHandles(openXmlElement, value.AdjustHandles, diffs, objName))
        ok = false;
      if (!CmpTextLock(openXmlElement, value.TextLock, diffs, objName))
        ok = false;
      if (!CmpAspectRatio(openXmlElement, value.AspectRatio, diffs, objName))
        ok = false;
      if (!CmpShapeType(openXmlElement, value.ShapeType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Lock value)
    where OpenXmlElementType: DXVmlO.Lock, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.Lock openXmlElement, DMVml.Lock value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetPosition(openXmlElement, value?.Position);
    SetSelection(openXmlElement, value?.Selection);
    SetGrouping(openXmlElement, value?.Grouping);
    SetUngrouping(openXmlElement, value?.Ungrouping);
    SetRotation(openXmlElement, value?.Rotation);
    SetCropping(openXmlElement, value?.Cropping);
    SetVerticies(openXmlElement, value?.Verticies);
    SetAdjustHandles(openXmlElement, value?.AdjustHandles);
    SetTextLock(openXmlElement, value?.TextLock);
    SetAspectRatio(openXmlElement, value?.AspectRatio);
    SetShapeType(openXmlElement, value?.ShapeType);
  }
}
