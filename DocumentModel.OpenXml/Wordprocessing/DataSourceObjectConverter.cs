using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using DataSourceObject = DocumentFormat.OpenXml.Wordprocessing.DataSourceObject;
using FieldMapData = DocumentModel.Wordprocessing.FieldMapData;
using RelationshipType = DocumentModel.Wordprocessing.RelationshipType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Office Data Source Object Settings.
/// </summary>
public static class DataSourceObjectConverter
{
  /// <summary>
  ///   UDL Connection String.
  /// </summary>
  public static String? GetUdlConnectionString(DataSourceObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<UdlConnectionString>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetUdlConnectionString(DataSourceObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UdlConnectionString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new UdlConnectionString { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Data Source Table Name.
  /// </summary>
  public static String? GetDataSourceTableName(DataSourceObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DataSourceTableName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDataSourceTableName(DataSourceObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DataSourceTableName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DataSourceTableName { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ODSO Data Source File Path.
  /// </summary>
  public static RelationshipType? GetSourceReference(DataSourceObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SourceReference>();
    if (itemElement != null)
      return RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSourceReference(DataSourceObject? openXmlElement, RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SourceReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipTypeConverter.CreateOpenXmlElement<SourceReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Column Delimiter for Data Source.
  /// </summary>
  public static UInt32? GetColumnDelimiter(DataSourceObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ColumnDelimiter>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetColumnDelimiter(DataSourceObject? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ColumnDelimiter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ColumnDelimiter { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ODSO Data Source Type.
  /// </summary>
  public static MailMergeSourceKind? GetMailMergeSource(DataSourceObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MailMergeSource>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<MailMergeSourceValues, MailMergeSourceKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMailMergeSource(DataSourceObject? openXmlElement, MailMergeSourceKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MailMergeSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<MailMergeSource, MailMergeSourceValues, MailMergeSourceKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   First Row of Data Source Contains Column Names.
  /// </summary>
  public static Boolean? GetFirstRowHeader(DataSourceObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FirstRowHeader>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetFirstRowHeader(DataSourceObject? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<FirstRowHeader>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new FirstRowHeader();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<FieldMapData>? GetFieldMapDatas(DataSourceObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<FieldMapData>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>())
      {
        var newItem = FieldMapDataConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetFieldMapDatas(DataSourceObject? openXmlElement, Collection<FieldMapData>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = FieldMapDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static RelationshipType? GetRecipientDataReference(DataSourceObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RecipientDataReference>();
    if (itemElement != null)
      return RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRecipientDataReference(DataSourceObject? openXmlElement, RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RecipientDataReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipTypeConverter.CreateOpenXmlElement<RecipientDataReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.DataSourceObject? CreateModelElement(DataSourceObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DataSourceObject();
      value.UdlConnectionString = GetUdlConnectionString(openXmlElement);
      value.DataSourceTableName = GetDataSourceTableName(openXmlElement);
      value.SourceReference = GetSourceReference(openXmlElement);
      value.ColumnDelimiter = GetColumnDelimiter(openXmlElement);
      value.MailMergeSource = GetMailMergeSource(openXmlElement);
      value.FirstRowHeader = GetFirstRowHeader(openXmlElement);
      value.FieldMapDatas = GetFieldMapDatas(openXmlElement);
      value.RecipientDataReference = GetRecipientDataReference(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DataSourceObject? value)
    where OpenXmlElementType : DataSourceObject, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUdlConnectionString(openXmlElement, value?.UdlConnectionString);
      SetDataSourceTableName(openXmlElement, value?.DataSourceTableName);
      SetSourceReference(openXmlElement, value?.SourceReference);
      SetColumnDelimiter(openXmlElement, value?.ColumnDelimiter);
      SetMailMergeSource(openXmlElement, value?.MailMergeSource);
      SetFirstRowHeader(openXmlElement, value?.FirstRowHeader);
      SetFieldMapDatas(openXmlElement, value?.FieldMapDatas);
      SetRecipientDataReference(openXmlElement, value?.RecipientDataReference);
      return openXmlElement;
    }
    return default;
  }
}