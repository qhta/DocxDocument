namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// External Data Source to Merge Field Mapping.
/// </summary>
public static class FieldMapDataConverter
{
  /// <summary>
  /// Merge Field Mapping.
  /// </summary>
  private static DocumentModel.Wordprocessing.MailMergeOdsoFieldKind? GetMailMergeFieldType(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DocumentModel.Wordprocessing.MailMergeOdsoFieldKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetMailMergeFieldType(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement, DocumentModel.Wordprocessing.MailMergeOdsoFieldKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType, DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DocumentModel.Wordprocessing.MailMergeOdsoFieldKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Source Name for Column.
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Name>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Name>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.Name { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Predefined Merge Field Name.
  /// </summary>
  private static String? GetMappedName(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MappedName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMappedName(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MappedName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.MappedName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Index of Column Being Mapped.
  /// </summary>
  private static UInt32? GetColumnIndex(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColumnIndex>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetColumnIndex(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColumnIndex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.ColumnIndex{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Merge Field Name Language ID.
  /// </summary>
  private static String? GetLanguageId(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LanguageId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLanguageId(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LanguageId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.LanguageId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Use Country/Region-Based Address Field Ordering.
  /// </summary>
  private static Boolean? GetDynamicAddress(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DynamicAddress>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDynamicAddress(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DynamicAddress>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DynamicAddress();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.FieldMapData? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FieldMapData? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FieldMapData, new()
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
