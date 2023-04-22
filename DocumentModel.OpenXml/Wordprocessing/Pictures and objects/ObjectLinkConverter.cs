namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ObjectLink Class.
/// </summary>
public static class ObjectLinkConverter
{
  /// <summary>
  /// updateMode
  /// </summary>
  private static DMW.ObjectUpdateMode? GetUpdateMode(DXW.ObjectLink openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ObjectUpdateMode, DMW.ObjectUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }
  
  private static bool CmpUpdateMode(DXW.ObjectLink openXmlElement, DMW.ObjectUpdateMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.ObjectUpdateMode, DMW.ObjectUpdateMode>(openXmlElement?.UpdateMode?.Value, value, diffs, objName);
  }
  
  private static void SetUpdateMode(DXW.ObjectLink openXmlElement, DMW.ObjectUpdateMode? value)
  {
    openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<DXW.ObjectUpdateMode, DMW.ObjectUpdateMode>(value);
  }
  
  /// <summary>
  /// lockedField
  /// </summary>
  private static Boolean? GetLockedField(DXW.ObjectLink openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LockedField);
  }
  
  private static bool CmpLockedField(DXW.ObjectLink openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.LockedField, value, diffs, objName, "LockedField");
  }
  
  private static void SetLockedField(DXW.ObjectLink openXmlElement, Boolean? value)
  {
    openXmlElement.LockedField = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// drawAspect
  /// </summary>
  private static DMW.ObjectDrawAspect? GetdrawAspect(DXW.ObjectLink openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ObjectDrawAspect, DMW.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value);
  }
  
  private static bool CmpdrawAspect(DXW.ObjectLink openXmlElement, DMW.ObjectDrawAspect? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.ObjectDrawAspect, DMW.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value, value, diffs, objName);
  }
  
  private static void SetdrawAspect(DXW.ObjectLink openXmlElement, DMW.ObjectDrawAspect? value)
  {
    openXmlElement.drawAspect = EnumValueConverter.CreateEnumValue<DXW.ObjectDrawAspect, DMW.ObjectDrawAspect>(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXW.ObjectLink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.ObjectLink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.ObjectLink openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// progId
  /// </summary>
  private static String? GetProgId(DXW.ObjectLink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ProgId);
  }
  
  private static bool CmpProgId(DXW.ObjectLink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ProgId, value, diffs, objName, "ProgId");
  }
  
  private static void SetProgId(DXW.ObjectLink openXmlElement, String? value)
  {
    openXmlElement.ProgId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  private static String? GetShapeId(DXW.ObjectLink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeId);
  }
  
  private static bool CmpShapeId(DXW.ObjectLink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeId, value, diffs, objName, "ShapeId");
  }
  
  private static void SetShapeId(DXW.ObjectLink openXmlElement, String? value)
  {
    openXmlElement.ShapeId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  private static String? GetFieldCodes(DXW.ObjectLink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FieldCodes);
  }
  
  private static bool CmpFieldCodes(DXW.ObjectLink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FieldCodes, value, diffs, objName, "FieldCodes");
  }
  
  private static void SetFieldCodes(DXW.ObjectLink openXmlElement, String? value)
  {
    openXmlElement.FieldCodes = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.ObjectLink? CreateModelElement(DXW.ObjectLink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ObjectLink();
      value.UpdateMode = GetUpdateMode(openXmlElement);
      value.LockedField = GetLockedField(openXmlElement);
      value.drawAspect = GetdrawAspect(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.ProgId = GetProgId(openXmlElement);
      value.ShapeId = GetShapeId(openXmlElement);
      value.FieldCodes = GetFieldCodes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ObjectLink? openXmlElement, DMW.ObjectLink? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUpdateMode(openXmlElement, value.UpdateMode, diffs, objName))
        ok = false;
      if (!CmpLockedField(openXmlElement, value.LockedField, diffs, objName))
        ok = false;
      if (!CmpdrawAspect(openXmlElement, value.drawAspect, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpProgId(openXmlElement, value.ProgId, diffs, objName))
        ok = false;
      if (!CmpShapeId(openXmlElement, value.ShapeId, diffs, objName))
        ok = false;
      if (!CmpFieldCodes(openXmlElement, value.FieldCodes, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ObjectLink value)
    where OpenXmlElementType: DXW.ObjectLink, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ObjectLink openXmlElement, DMW.ObjectLink value)
  {
    SetUpdateMode(openXmlElement, value?.UpdateMode);
    SetLockedField(openXmlElement, value?.LockedField);
    SetdrawAspect(openXmlElement, value?.drawAspect);
    SetId(openXmlElement, value?.Id);
    SetProgId(openXmlElement, value?.ProgId);
    SetShapeId(openXmlElement, value?.ShapeId);
    SetFieldCodes(openXmlElement, value?.FieldCodes);
  }
}
