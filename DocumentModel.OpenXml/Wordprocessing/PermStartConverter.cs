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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues, DMW.RangePermissionEditingGroupKind>(openXmlElement?.EditorGroup?.Value);
  }
  
  private static bool CmpEditorGroup(DXW.PermStart openXmlElement, DMW.RangePermissionEditingGroupKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues, DMW.RangePermissionEditingGroupKind>(openXmlElement?.EditorGroup?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEditorGroup(DXW.PermStart openXmlElement, DMW.RangePermissionEditingGroupKind? value)
  {
    openXmlElement.EditorGroup = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues, DMW.RangePermissionEditingGroupKind>(value);
  }
  
  /// <summary>
  /// ed
  /// </summary>
  private static String? GetEd(DXW.PermStart openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Ed);
  }
  
  private static bool CmpEd(DXW.PermStart openXmlElement, String? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpColumnFirst(DXW.PermStart openXmlElement, Int32? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpColumnLast(DXW.PermStart openXmlElement, Int32? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpId(DXW.PermStart openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static bool CmpDisplacedByCustomXml(DXW.PermStart openXmlElement, DMW.DisplacedByCustomXmlKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDisplacedByCustomXml(DXW.PermStart openXmlElement, DMW.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.PermStart? CreateModelElement(DXW.PermStart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PermStart();
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
  
  public static bool CompareModelElement(DXW.PermStart? openXmlElement, DMW.PermStart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEditorGroup(openXmlElement, value.EditorGroup, diffs, objName))
        ok = false;
      if (!CmpEd(openXmlElement, value.Ed, diffs, objName))
        ok = false;
      if (!CmpColumnFirst(openXmlElement, value.ColumnFirst, diffs, objName))
        ok = false;
      if (!CmpColumnLast(openXmlElement, value.ColumnLast, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpDisplacedByCustomXml(openXmlElement, value.DisplacedByCustomXml, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PermStart value)
    where OpenXmlElementType: DXW.PermStart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PermStart openXmlElement, DMW.PermStart value)
  {
    SetEditorGroup(openXmlElement, value?.EditorGroup);
    SetEd(openXmlElement, value?.Ed);
    SetColumnFirst(openXmlElement, value?.ColumnFirst);
    SetColumnLast(openXmlElement, value?.ColumnLast);
    SetId(openXmlElement, value?.Id);
    SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
  }
}
