using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using FieldMapData = DocumentFormat.OpenXml.Wordprocessing.FieldMapData;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   External Data Source to Merge Field Mapping.
/// </summary>
public static class FieldMapDataConverter
{
  /// <summary>
  ///   Merge Field Mapping.
  /// </summary>
  public static MailMergeOdsoFieldKind? GetMailMergeFieldType(FieldMapData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MailMergeFieldType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<MailMergeOdsoFieldValues, MailMergeOdsoFieldKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMailMergeFieldType(FieldMapData? openXmlElement, MailMergeOdsoFieldKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MailMergeFieldType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<MailMergeFieldType, MailMergeOdsoFieldValues, MailMergeOdsoFieldKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Data Source Name for Column.
  /// </summary>
  public static String? GetName(FieldMapData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Name>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetName(FieldMapData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Name>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Name { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Predefined Merge Field Name.
  /// </summary>
  public static String? GetMappedName(FieldMapData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MappedName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMappedName(FieldMapData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MappedName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MappedName { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Index of Column Being Mapped.
  /// </summary>
  public static UInt32? GetColumnIndex(FieldMapData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ColumnIndex>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetColumnIndex(FieldMapData? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ColumnIndex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ColumnIndex { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Merge Field Name Language ID.
  /// </summary>
  public static String? GetLanguageId(FieldMapData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LanguageId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLanguageId(FieldMapData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LanguageId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LanguageId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Use Country/Region-Based Address Field Ordering.
  /// </summary>
  public static Boolean? GetDynamicAddress(FieldMapData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DynamicAddress>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDynamicAddress(FieldMapData? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DynamicAddress>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DynamicAddress();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.FieldMapData? CreateModelElement(FieldMapData? openXmlElement)
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
    where OpenXmlElementType : FieldMapData, new()
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