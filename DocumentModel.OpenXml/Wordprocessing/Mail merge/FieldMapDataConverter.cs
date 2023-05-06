namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// External Data Source to Merge Field Mapping.
/// </summary>
public static class FieldMapDataConverter
{
  /// <summary>
  /// Merge Field Mapping.
  /// </summary>
  private static DMW.MailMergeOdsoFieldKind? GetMailMergeFieldType(DXW.FieldMapData openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>(openXmlElement.GetFirstChild<DXW.MailMergeFieldType>()?.Val?.Value);
  }
  
  private static bool CmpMailMergeFieldType(DXW.FieldMapData openXmlElement, DMW.MailMergeOdsoFieldKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>(openXmlElement.GetFirstChild<DXW.MailMergeFieldType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetMailMergeFieldType(DXW.FieldMapData openXmlElement, DMW.MailMergeOdsoFieldKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MailMergeFieldType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>(itemElement, (DMW.MailMergeOdsoFieldKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.MailMergeFieldType, DXW.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>((DMW.MailMergeOdsoFieldKind)value));
  }
  
  /// <summary>
  /// Data Source Name for Column.
  /// </summary>
  private static String? GetName(DXW.FieldMapData openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.Name>()?.Val?.Value;
  }
  
  private static bool CmpName(DXW.FieldMapData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Name>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Name", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetName(DXW.FieldMapData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Name>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Name { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Predefined Merge Field Name.
  /// </summary>
  private static String? GetMappedName(DXW.FieldMapData openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.MappedName>()?.Val?.Value;
  }
  
  private static bool CmpMappedName(DXW.FieldMapData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MappedName>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "MappedName", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetMappedName(DXW.FieldMapData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MappedName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.MappedName { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Index of Column Being Mapped.
  /// </summary>
  private static UInt32? GetColumnIndex(DXW.FieldMapData openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.ColumnIndex>()?.Val);
  }
  
  private static bool CmpColumnIndex(DXW.FieldMapData openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.ColumnIndex>()?.Val, value, diffs, objName, "ColumnIndex");
  }
  
  private static void SetColumnIndex(DXW.FieldMapData openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXW.ColumnIndex,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Merge Field Name Language ID.
  /// </summary>
  private static String? GetLanguageId(DXW.FieldMapData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.LanguageId>()?.Val);
  }
  
  private static bool CmpLanguageId(DXW.FieldMapData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.LanguageId>()?.Val, value, diffs, objName, "LanguageId");
  }
  
  private static void SetLanguageId(DXW.FieldMapData openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.LanguageId>(openXmlElement, value);
  }
  
  /// <summary>
  /// Use Country/Region-Based Address Field Ordering.
  /// </summary>
  private static Boolean? GetDynamicAddress(DXW.FieldMapData openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DynamicAddress>());
  }
  
  private static bool CmpDynamicAddress(DXW.FieldMapData openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DynamicAddress>(), value, diffs, objName);
  }
  
  private static void SetDynamicAddress(DXW.FieldMapData openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DynamicAddress>(openXmlElement, value);
  }
  
  public static DMW.FieldMapData? CreateModelElement(DXW.FieldMapData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FieldMapData();
      value.MailMergeFieldType = GetMailMergeFieldType(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.MappedName = GetMappedName(openXmlElement);
      value.ColumnIndex = GetColumnIndex(openXmlElement);
      value.LanguageId = GetLanguageId(openXmlElement);
      value.DynamicAddress = GetDynamicAddress(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FieldMapData? openXmlElement, DMW.FieldMapData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMailMergeFieldType(openXmlElement, value.MailMergeFieldType, diffs, objName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpMappedName(openXmlElement, value.MappedName, diffs, objName))
        ok = false;
      if (!CmpColumnIndex(openXmlElement, value.ColumnIndex, diffs, objName))
        ok = false;
      if (!CmpLanguageId(openXmlElement, value.LanguageId, diffs, objName))
        ok = false;
      if (!CmpDynamicAddress(openXmlElement, value.DynamicAddress, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FieldMapData value)
    where OpenXmlElementType: DXW.FieldMapData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FieldMapData openXmlElement, DMW.FieldMapData value)
  {
    SetMailMergeFieldType(openXmlElement, value?.MailMergeFieldType);
    SetName(openXmlElement, value?.Name);
    SetMappedName(openXmlElement, value?.MappedName);
    SetColumnIndex(openXmlElement, value?.ColumnIndex);
    SetLanguageId(openXmlElement, value?.LanguageId);
    SetDynamicAddress(openXmlElement, value?.DynamicAddress);
  }
}
