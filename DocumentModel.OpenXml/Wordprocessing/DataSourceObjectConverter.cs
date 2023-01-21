namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Office Data Source Object Settings.
/// </summary>
public static class DataSourceObjectConverter
{
  /// <summary>
  /// UDL Connection String.
  /// </summary>
  private static String? GetUdlConnectionString(DXW.DataSourceObject openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UdlConnectionString>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetUdlConnectionString(DXW.DataSourceObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UdlConnectionString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.UdlConnectionString { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Source Table Name.
  /// </summary>
  private static String? GetDataSourceTableName(DXW.DataSourceObject openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DataSourceTableName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDataSourceTableName(DXW.DataSourceObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DataSourceTableName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DataSourceTableName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ODSO Data Source File Path.
  /// </summary>
  private static DMW.RelationshipType? GetSourceReference(DXW.DataSourceObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SourceReference>();
    if (itemElement != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSourceReference(DXW.DataSourceObject openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SourceReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.SourceReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Column Delimiter for Data Source.
  /// </summary>
  private static UInt32? GetColumnDelimiter(DXW.DataSourceObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ColumnDelimiter>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetColumnDelimiter(DXW.DataSourceObject openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ColumnDelimiter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ColumnDelimiter{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ODSO Data Source Type.
  /// </summary>
  private static DMW.MailMergeSourceKind? GetMailMergeSource(DXW.DataSourceObject openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MailMergeSource>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DMW.MailMergeSourceKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetMailMergeSource(DXW.DataSourceObject openXmlElement, DMW.MailMergeSourceKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MailMergeSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.MailMergeSource, DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DMW.MailMergeSourceKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// First Row of Data Source Contains Column Names.
  /// </summary>
  private static Boolean? GetFirstRowHeader(DXW.DataSourceObject openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FirstRowHeader>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetFirstRowHeader(DXW.DataSourceObject openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.FirstRowHeader>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.FirstRowHeader();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.FieldMapData> GetFieldMapDatas(DXW.DataSourceObject openXmlElement)
  {
    var collection = new Collection<DMW.FieldMapData>();
    foreach (var item in openXmlElement.Elements<DXW.FieldMapData>())
    {
      var newItem = DMXW.FieldMapDataConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetFieldMapDatas(DXW.DataSourceObject openXmlElement, Collection<DMW.FieldMapData>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.FieldMapData>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.FieldMapDataConverter.CreateOpenXmlElement<DXW.FieldMapData>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.RelationshipType? GetRecipientDataReference(DXW.DataSourceObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RecipientDataReference>();
    if (itemElement != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRecipientDataReference(DXW.DataSourceObject openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RecipientDataReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.RecipientDataReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.DataSourceObject? CreateModelElement(DXW.DataSourceObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DataSourceObject();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DataSourceObject? value)
    where OpenXmlElementType: DXW.DataSourceObject, new()
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
