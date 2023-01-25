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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, DMW.ObjectUpdateMode>(openXmlElement?.UpdateMode?.Value);
  }
  
  private static bool CmpUpdateMode(DXW.ObjectLink openXmlElement, DMW.ObjectUpdateMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, DMW.ObjectUpdateMode>(openXmlElement?.UpdateMode?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUpdateMode(DXW.ObjectLink openXmlElement, DMW.ObjectUpdateMode? value)
  {
    openXmlElement.UpdateMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectUpdateMode, DMW.ObjectUpdateMode>(value);
  }
  
  /// <summary>
  /// lockedField
  /// </summary>
  private static Boolean? GetLockedField(DXW.ObjectLink openXmlElement)
  {
    return openXmlElement?.LockedField?.Value;
  }
  
  private static bool CmpLockedField(DXW.ObjectLink openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LockedField?.Value == value;
  }
  
  private static void SetLockedField(DXW.ObjectLink openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockedField = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LockedField = null;
  }
  
  /// <summary>
  /// drawAspect
  /// </summary>
  private static DMW.ObjectDrawAspect? GetdrawAspect(DXW.ObjectLink openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DMW.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value);
  }
  
  private static bool CmpdrawAspect(DXW.ObjectLink openXmlElement, DMW.ObjectDrawAspect? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DMW.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetdrawAspect(DXW.ObjectLink openXmlElement, DMW.ObjectDrawAspect? value)
  {
    openXmlElement.drawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DMW.ObjectDrawAspect>(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXW.ObjectLink openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.ObjectLink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// progId
  /// </summary>
  private static String? GetProgId(DXW.ObjectLink openXmlElement)
  {
    return openXmlElement?.ProgId?.Value;
  }
  
  private static bool CmpProgId(DXW.ObjectLink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ProgId?.Value == value;
  }
  
  private static void SetProgId(DXW.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ProgId = new StringValue { Value = value };
    else
      openXmlElement.ProgId = null;
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  private static String? GetShapeId(DXW.ObjectLink openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static bool CmpShapeId(DXW.ObjectLink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShapeId?.Value == value;
  }
  
  private static void SetShapeId(DXW.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  private static String? GetFieldCodes(DXW.ObjectLink openXmlElement)
  {
    return openXmlElement?.FieldCodes?.Value;
  }
  
  private static bool CmpFieldCodes(DXW.ObjectLink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FieldCodes?.Value == value;
  }
  
  private static void SetFieldCodes(DXW.ObjectLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FieldCodes = new StringValue { Value = value };
    else
      openXmlElement.FieldCodes = null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ObjectLink? value)
    where OpenXmlElementType: DXW.ObjectLink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUpdateMode(openXmlElement, value?.UpdateMode);
      SetLockedField(openXmlElement, value?.LockedField);
      SetdrawAspect(openXmlElement, value?.drawAspect);
      SetId(openXmlElement, value?.Id);
      SetProgId(openXmlElement, value?.ProgId);
      SetShapeId(openXmlElement, value?.ShapeId);
      SetFieldCodes(openXmlElement, value?.FieldCodes);
      return openXmlElement;
    }
    return default;
  }
}
