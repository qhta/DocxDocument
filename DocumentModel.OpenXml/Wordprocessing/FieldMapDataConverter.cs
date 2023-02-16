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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>(openXmlElement.GetFirstChild<DXW.MailMergeFieldType>()?.Val?.Value);
  }
  
  private static bool CmpMailMergeFieldType(DXW.FieldMapData openXmlElement, DMW.MailMergeOdsoFieldKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>(openXmlElement.GetFirstChild<DXW.MailMergeFieldType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMailMergeFieldType(DXW.FieldMapData openXmlElement, DMW.MailMergeOdsoFieldKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MailMergeFieldType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.MailMergeFieldType, DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
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
      openXmlElement.AddChild(itemElement);
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Index of Column Being Mapped.
  /// </summary>
  private static UInt32? GetColumnIndex(DXW.FieldMapData openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.ColumnIndex>()?.Val?.Value;
  }
  
  private static bool CmpColumnIndex(DXW.FieldMapData openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ColumnIndex>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.ColumnIndex", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetColumnIndex(DXW.FieldMapData openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ColumnIndex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ColumnIndex{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Merge Field Name Language ID.
  /// </summary>
  private static String? GetLanguageId(DXW.FieldMapData openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.LanguageId>()?.Val?.Value;
  }
  
  private static bool CmpLanguageId(DXW.FieldMapData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.LanguageId>()?.Val?.Value == value;
  }
  
  private static void SetLanguageId(DXW.FieldMapData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LanguageId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.LanguageId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Country/Region-Based Address Field Ordering.
  /// </summary>
  private static Boolean? GetDynamicAddress(DXW.FieldMapData openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.DynamicAddress>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDynamicAddress(DXW.FieldMapData openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDynamicAddress(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DynamicAddress", val, value);
    return false;
  }
  
  private static void SetDynamicAddress(DXW.FieldMapData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DynamicAddress>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DynamicAddress();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.FieldMapData? CreateModelElement(DXW.FieldMapData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FieldMapData();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FieldMapData? value)
    where OpenXmlElementType: DXW.FieldMapData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMailMergeFieldType(openXmlElement, value?.MailMergeFieldType);
      SetName(openXmlElement, value?.Name);
      SetMappedName(openXmlElement, value?.MappedName);
      SetColumnIndex(openXmlElement, value?.ColumnIndex);
      SetLanguageId(openXmlElement, value?.LanguageId);
      SetDynamicAddress(openXmlElement, value?.DynamicAddress);
      return openXmlElement;
    }
    return default;
  }
}
