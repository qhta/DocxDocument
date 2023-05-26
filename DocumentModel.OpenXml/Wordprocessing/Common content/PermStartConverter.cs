namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public static class PermStartConverter
{
  /// <summary>
  /// edGrp
  /// </summary>
  private static DMW.RangePermissionEditingGroupKind? GetEditorGroup(DXW.PermStart openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.RangePermissionEditingGroupValues, DMW.RangePermissionEditingGroupKind>(openXmlElement?.EditorGroup?.Value);
  }
  
  private static bool CmpEditorGroup(DXW.PermStart openXmlElement, DMW.RangePermissionEditingGroupKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.RangePermissionEditingGroupValues, DMW.RangePermissionEditingGroupKind>(openXmlElement?.EditorGroup?.Value, value, diffs, objName, propName);
  }
  
  private static void SetEditorGroup(DXW.PermStart openXmlElement, DMW.RangePermissionEditingGroupKind? value)
  {
    openXmlElement.EditorGroup = EnumValueConverter.CreateEnumValue<DXW.RangePermissionEditingGroupValues, DMW.RangePermissionEditingGroupKind>(value);
  }
  
  /// <summary>
  /// ed
  /// </summary>
  private static String? GetEd(DXW.PermStart openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Ed);
  }
  
  private static bool CmpEd(DXW.PermStart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Ed, value, diffs, objName, "Ed");
  }
  
  private static void SetEd(DXW.PermStart openXmlElement, String? value)
  {
    openXmlElement.Ed = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  private static Int32? GetColumnFirst(DXW.PermStart openXmlElement)
  {
    return openXmlElement?.ColumnFirst?.Value;
  }
  
  private static bool CmpColumnFirst(DXW.PermStart openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ColumnFirst?.Value == value) return true;
    diffs?.Add(objName, "ColumnFirst", openXmlElement?.ColumnFirst?.Value, value);
    return false;
  }
  
  private static void SetColumnFirst(DXW.PermStart openXmlElement, Int32? value)
  {
    openXmlElement.ColumnFirst = value;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  private static Int32? GetColumnLast(DXW.PermStart openXmlElement)
  {
    return openXmlElement?.ColumnLast?.Value;
  }
  
  private static bool CmpColumnLast(DXW.PermStart openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ColumnLast?.Value == value) return true;
    diffs?.Add(objName, "ColumnLast", openXmlElement?.ColumnLast?.Value, value);
    return false;
  }
  
  private static void SetColumnLast(DXW.PermStart openXmlElement, Int32? value)
  {
    openXmlElement.ColumnLast = value;
  }
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  private static Int32? GetId(DXW.PermStart openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.PermStart openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "AnnotationId", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXW.PermStart openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  private static DMW.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DXW.PermStart openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static bool CmpDisplacedByCustomXml(DXW.PermStart openXmlElement, DMW.DisplacedByCustomXmlKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value, value, diffs, objName, propName);
  }
  
  private static void SetDisplacedByCustomXml(DXW.PermStart openXmlElement, DMW.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DXW.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(value);
  }
  
  public static DMW.PermStart? CreateModelElement(DXW.PermStart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PermStart();
      value.EditorGroup = GetEditorGroup(openXmlElement);
      value.Ed = GetEd(openXmlElement);
      value.ColumnFirst = GetColumnFirst(openXmlElement);
      value.ColumnLast = GetColumnLast(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PermStart? openXmlElement, DMW.PermStart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEditorGroup(openXmlElement, value.EditorGroup, diffs, objName, propName))
        ok = false;
      if (!CmpEd(openXmlElement, value.Ed, diffs, objName, propName))
        ok = false;
      if (!CmpColumnFirst(openXmlElement, value.ColumnFirst, diffs, objName, propName))
        ok = false;
      if (!CmpColumnLast(openXmlElement, value.ColumnLast, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpDisplacedByCustomXml(openXmlElement, value.DisplacedByCustomXml, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.PermStart CreateOpenXmlElement(DMW.PermStart value)
  {
    var openXmlElement = new DXW.PermStart();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.PermStart openXmlElement, DMW.PermStart value)
  {
    SetEditorGroup(openXmlElement, value?.EditorGroup);
    SetEd(openXmlElement, value?.Ed);
    SetColumnFirst(openXmlElement, value?.ColumnFirst);
    SetColumnLast(openXmlElement, value?.ColumnLast);
    SetId(openXmlElement, value?.Id);
    SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
    return true;
  }
}
