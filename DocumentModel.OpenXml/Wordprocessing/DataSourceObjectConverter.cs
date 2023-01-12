namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Office Data Source Object Settings.
/// </summary>
public static class DataSourceObjectConverter
{
  /// <summary>
  /// UDL Connection String.
  /// </summary>
  public static String? GetUdlConnectionString(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UdlConnectionString>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetUdlConnectionString(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UdlConnectionString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.UdlConnectionString { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Data Source Table Name.
  /// </summary>
  public static String? GetDataSourceTableName(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceTableName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetDataSourceTableName(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceTableName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.DataSourceTableName { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ODSO Data Source File Path.
  /// </summary>
  public static DocumentModel.Wordprocessing.RelationshipType? GetSourceReference(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SourceReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSourceReference(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SourceReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SourceReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Column Delimiter for Data Source.
  /// </summary>
  public static UInt32? GetColumnDelimiter(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColumnDelimiter>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetColumnDelimiter(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColumnDelimiter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.ColumnDelimiter{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ODSO Data Source Type.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeSourceKind? GetMailMergeSource(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeSource>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DocumentModel.Wordprocessing.MailMergeSourceKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMailMergeSource(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, DocumentModel.Wordprocessing.MailMergeSourceKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMergeSource, DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DocumentModel.Wordprocessing.MailMergeSourceKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// First Row of Data Source Contains Column Names.
  /// </summary>
  public static Boolean? GetFirstRowHeader(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FirstRowHeader>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetFirstRowHeader(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FirstRowHeader>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.FirstRowHeader();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FieldMapData>? GetFieldMapDatas(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FieldMapData>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.FieldMapDataConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetFieldMapDatas(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FieldMapData>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.FieldMapDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FieldMapData>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.RelationshipType? GetRecipientDataReference(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RecipientDataReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRecipientDataReference(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RecipientDataReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RecipientDataReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DataSourceObject? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DataSourceObject, new()
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
      return openXmlElement;
    }
    return default;
  }
}
