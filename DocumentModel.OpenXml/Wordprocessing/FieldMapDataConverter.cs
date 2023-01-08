namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// External Data Source to Merge Field Mapping.
/// </summary>
public static class FieldMapDataConverter
{
  /// <summary>
  /// Merge Field Mapping.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeOdsoFieldKind? GetMailMergeFieldType(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DocumentModel.Wordprocessing.MailMergeOdsoFieldKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMailMergeFieldType(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement, DocumentModel.Wordprocessing.MailMergeOdsoFieldKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Data Source Name for Column.
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement)
  {
    return openXmlElement?.Name?.Val?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Predefined Merge Field Name.
  /// </summary>
  public static String? GetMappedName(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement)
  {
    return openXmlElement?.MappedName?.Val?.Value;
  }
  
  public static void SetMappedName(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Index of Column Being Mapped.
  /// </summary>
  public static UInt32? GetColumnIndex(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnIndex(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Merge Field Name Language ID.
  /// </summary>
  public static String? GetLanguageId(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.LanguageId");
  }
  
  public static void SetLanguageId(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Use Country/Region-Based Address Field Ordering.
  /// </summary>
  public static Boolean? GetDynamicAddress(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDynamicAddress(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
