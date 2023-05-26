namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Lock Class.
/// </summary>
public static class LockConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.Lock openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.Lock openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName, propName);
  }
  
  private static void SetExtension(DXVO.Lock openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Position Lock
  /// </summary>
  private static Boolean? GetPosition(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  private static bool CmpPosition(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Position?.Value == value) return true;
    diffs?.Add(objName, "Position", openXmlElement?.Position?.Value, value);
    return false;
  }
  
  private static void SetPosition(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Position = value;
    else
      openXmlElement.Position = null;
  }
  
  /// <summary>
  /// Selection Lock
  /// </summary>
  private static Boolean? GetSelection(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.Selection?.Value;
  }
  
  private static bool CmpSelection(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Selection?.Value == value) return true;
    diffs?.Add(objName, "Selection", openXmlElement?.Selection?.Value, value);
    return false;
  }
  
  private static void SetSelection(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Selection = value;
    else
      openXmlElement.Selection = null;
  }
  
  /// <summary>
  /// Grouping Lock
  /// </summary>
  private static Boolean? GetGrouping(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.Grouping?.Value;
  }
  
  private static bool CmpGrouping(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Grouping?.Value == value) return true;
    diffs?.Add(objName, "Grouping", openXmlElement?.Grouping?.Value, value);
    return false;
  }
  
  private static void SetGrouping(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Grouping = value;
    else
      openXmlElement.Grouping = null;
  }
  
  /// <summary>
  /// Ungrouping Lock
  /// </summary>
  private static Boolean? GetUngrouping(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.Ungrouping?.Value;
  }
  
  private static bool CmpUngrouping(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Ungrouping?.Value == value) return true;
    diffs?.Add(objName, "Ungrouping", openXmlElement?.Ungrouping?.Value, value);
    return false;
  }
  
  private static void SetUngrouping(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Ungrouping = value;
    else
      openXmlElement.Ungrouping = null;
  }
  
  /// <summary>
  /// Rotation Lock
  /// </summary>
  private static Boolean? GetRotation(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Rotation = value;
    else
      openXmlElement.Rotation = null;
  }
  
  /// <summary>
  /// Cropping Lock
  /// </summary>
  private static Boolean? GetCropping(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.Cropping?.Value;
  }
  
  private static bool CmpCropping(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Cropping?.Value == value) return true;
    diffs?.Add(objName, "Cropping", openXmlElement?.Cropping?.Value, value);
    return false;
  }
  
  private static void SetCropping(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Cropping = value;
    else
      openXmlElement.Cropping = null;
  }
  
  /// <summary>
  /// Vertices Lock
  /// </summary>
  private static Boolean? GetVerticies(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.Verticies?.Value;
  }
  
  private static bool CmpVerticies(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Verticies?.Value == value) return true;
    diffs?.Add(objName, "Verticies", openXmlElement?.Verticies?.Value, value);
    return false;
  }
  
  private static void SetVerticies(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Verticies = value;
    else
      openXmlElement.Verticies = null;
  }
  
  /// <summary>
  /// Handles Lock
  /// </summary>
  private static Boolean? GetAdjustHandles(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.AdjustHandles?.Value;
  }
  
  private static bool CmpAdjustHandles(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AdjustHandles?.Value == value) return true;
    diffs?.Add(objName, "AdjustHandles", openXmlElement?.AdjustHandles?.Value, value);
    return false;
  }
  
  private static void SetAdjustHandles(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AdjustHandles = value;
    else
      openXmlElement.AdjustHandles = null;
  }
  
  /// <summary>
  /// Text Lock
  /// </summary>
  private static Boolean? GetTextLock(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.TextLock?.Value;
  }
  
  private static bool CmpTextLock(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.TextLock?.Value == value) return true;
    diffs?.Add(objName, "TextLock", openXmlElement?.TextLock?.Value, value);
    return false;
  }
  
  private static void SetTextLock(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextLock = value;
    else
      openXmlElement.TextLock = null;
  }
  
  /// <summary>
  /// Aspect Ratio Lock
  /// </summary>
  private static Boolean? GetAspectRatio(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.AspectRatio?.Value;
  }
  
  private static bool CmpAspectRatio(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AspectRatio?.Value == value) return true;
    diffs?.Add(objName, "AspectRatio", openXmlElement?.AspectRatio?.Value, value);
    return false;
  }
  
  private static void SetAspectRatio(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AspectRatio = value;
    else
      openXmlElement.AspectRatio = null;
  }
  
  /// <summary>
  /// AutoShape Type Lock
  /// </summary>
  private static Boolean? GetShapeType(DXVO.Lock openXmlElement)
  {
    return openXmlElement?.ShapeType?.Value;
  }
  
  private static bool CmpShapeType(DXVO.Lock openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ShapeType?.Value == value) return true;
    diffs?.Add(objName, "ShapeType", openXmlElement?.ShapeType?.Value, value);
    return false;
  }
  
  private static void SetShapeType(DXVO.Lock openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShapeType = value;
    else
      openXmlElement.ShapeType = null;
  }
  
  public static DocumentModel.Vml.Lock? CreateModelElement(DXVO.Lock? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.Lock? openXmlElement, DMV.Lock? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName, propName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName, propName))
        ok = false;
      if (!CmpSelection(openXmlElement, value.Selection, diffs, objName, propName))
        ok = false;
      if (!CmpGrouping(openXmlElement, value.Grouping, diffs, objName, propName))
        ok = false;
      if (!CmpUngrouping(openXmlElement, value.Ungrouping, diffs, objName, propName))
        ok = false;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName, propName))
        ok = false;
      if (!CmpCropping(openXmlElement, value.Cropping, diffs, objName, propName))
        ok = false;
      if (!CmpVerticies(openXmlElement, value.Verticies, diffs, objName, propName))
        ok = false;
      if (!CmpAdjustHandles(openXmlElement, value.AdjustHandles, diffs, objName, propName))
        ok = false;
      if (!CmpTextLock(openXmlElement, value.TextLock, diffs, objName, propName))
        ok = false;
      if (!CmpAspectRatio(openXmlElement, value.AspectRatio, diffs, objName, propName))
        ok = false;
      if (!CmpShapeType(openXmlElement, value.ShapeType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Lock value)
    where OpenXmlElementType: DXVO.Lock, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.Lock openXmlElement, DMV.Lock value)
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
