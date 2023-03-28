namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Complex Field Character converter from/to OpenXml.
///</summary>
public static class FieldCharConverter
{
  /// <summary>
  /// Field Character Type
  /// </summary>
  private static DMW.FieldCharKind? GetFieldCharType(DXW.FieldChar openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FieldCharValues, DMW.FieldCharKind>(openXmlElement?.FieldCharType?.Value);
  }
  
  private static bool CmpFieldCharType(DXW.FieldChar openXmlElement, DMW.FieldCharKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.FieldCharValues, DMW.FieldCharKind>(openXmlElement?.FieldCharType?.Value, value, diffs, objName);
  }
  
  private static void SetFieldCharType(DXW.FieldChar openXmlElement, DMW.FieldCharKind? value)
  {
    openXmlElement.FieldCharType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.FieldCharValues, DMW.FieldCharKind>(value);
  }
  
  /// <summary>
  /// Field Should Not Be Recalculated
  /// </summary>
  private static Boolean? GetFieldLock(DXW.FieldChar openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.FieldLock);
  }
  
  private static bool CmpFieldLock(DXW.FieldChar openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.FieldLock, value, diffs, objName, "FieldLock");
  }
  
  private static void SetFieldLock(DXW.FieldChar openXmlElement, Boolean? value)
  {
    openXmlElement.FieldLock = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Field Result Invalidated
  /// </summary>
  private static Boolean? GetDirty(DXW.FieldChar openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Dirty);
  }
  
  private static bool CmpDirty(DXW.FieldChar openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Dirty, value, diffs, objName, "Dirty");
  }
  
  private static void SetDirty(DXW.FieldChar openXmlElement, Boolean? value)
  {
    openXmlElement.Dirty = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Custom Field Data.
  /// </summary>
  private static String? GetFieldData(DXW.FieldChar openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.FieldData>()?.Text;
  }
  
  private static bool CmpFieldData(DXW.FieldChar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.FieldData>()?.Text == value;
  }
  
  private static void SetFieldData(DXW.FieldChar openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FieldData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.FieldData { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  private static DMW.FormFieldData? GetFormFieldData(DXW.FieldChar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FormFieldData>();
    if (element != null)
      return DMXW.FormFieldDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormFieldData(DXW.FieldChar openXmlElement, DMW.FormFieldData? value, DiffList? diffs, string? objName)
  {
    return DMXW.FormFieldDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FormFieldData>(), value, diffs, objName);
  }
  
  private static void SetFormFieldData(DXW.FieldChar openXmlElement, DMW.FormFieldData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FormFieldData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FormFieldDataConverter.CreateOpenXmlElement<DXW.FormFieldData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  private static DMW.NumberingChange? GetNumberingChange(DXW.FieldChar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingChange>();
    if (element != null)
      return DMXW.NumberingChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingChange(DXW.FieldChar openXmlElement, DMW.NumberingChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingChange>(), value, diffs, objName);
  }
  
  private static void SetNumberingChange(DXW.FieldChar openXmlElement, DMW.NumberingChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NumberingChangeConverter.CreateOpenXmlElement<DXW.NumberingChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.FieldChar? CreateModelElement(DXW.FieldChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FieldChar();
      value.FieldCharType = GetFieldCharType(openXmlElement);
      value.FieldLock = GetFieldLock(openXmlElement);
      value.Dirty = GetDirty(openXmlElement);
      value.FieldData = GetFieldData(openXmlElement);
      value.FormFieldData = GetFormFieldData(openXmlElement);
      value.NumberingChange = GetNumberingChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FieldChar? openXmlElement, DMW.FieldChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFieldCharType(openXmlElement, value.FieldCharType, diffs, objName))
        ok = false;
      if (!CmpFieldLock(openXmlElement, value.FieldLock, diffs, objName))
        ok = false;
      if (!CmpDirty(openXmlElement, value.Dirty, diffs, objName))
        ok = false;
      if (!CmpFieldData(openXmlElement, value.FieldData, diffs, objName))
        ok = false;
      if (!CmpFormFieldData(openXmlElement, value.FormFieldData, diffs, objName))
        ok = false;
      if (!CmpNumberingChange(openXmlElement, value.NumberingChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FieldChar value)
    where OpenXmlElementType: DXW.FieldChar, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static DXW.FieldChar CreateOpenXmlElement(DMW.FieldChar value)
    => CreateOpenXmlElement<DXW.FieldChar>(value);

  public static bool UpdateOpenXmlElement(DXW.FieldChar openXmlElement, DMW.FieldChar value)
  {
    SetFieldCharType(openXmlElement, value?.FieldCharType);
    SetFieldLock(openXmlElement, value?.FieldLock);
    SetDirty(openXmlElement, value?.Dirty);
    SetFieldData(openXmlElement, value?.FieldData);
    SetFormFieldData(openXmlElement, value?.FormFieldData);
    SetNumberingChange(openXmlElement, value?.NumberingChange);
    return true;
  }
}
