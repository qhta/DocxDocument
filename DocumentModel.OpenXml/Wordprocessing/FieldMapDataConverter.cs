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
    var itemElement = openXmlElement.GetFirstChild<DXW.MailMergeFieldType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.Name>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.MappedName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ColumnIndex>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.LanguageId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DynamicAddress>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
