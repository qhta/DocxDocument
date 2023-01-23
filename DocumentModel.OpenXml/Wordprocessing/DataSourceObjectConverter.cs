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
      return openXmlElement.GetFirstChild<DXW.UdlConnectionString>()?.Val?.Value;
  }
  
  private static bool CmpUdlConnectionString(DXW.DataSourceObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement.GetFirstChild<DXW.UdlConnectionString>()?.Val?.Value == value;
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
      return openXmlElement.GetFirstChild<DXW.DataSourceTableName>()?.Val?.Value;
  }
  
  private static bool CmpDataSourceTableName(DXW.DataSourceObject openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement.GetFirstChild<DXW.DataSourceTableName>()?.Val?.Value == value;
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
    return DMXW.RelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SourceReference>());
  }
  
  private static bool CmpSourceReference(DXW.DataSourceObject openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SourceReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.GetFirstChild<DXW.ColumnDelimiter>()?.Val?.Value;
  }
  
  private static bool CmpColumnDelimiter(DXW.DataSourceObject openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.ColumnDelimiter>()?.Val?.Value == value;
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DMW.MailMergeSourceKind>(openXmlElement.GetFirstChild<DXW.MailMergeSource>()?.Val?.Value);
  }
  
  private static bool CmpMailMergeSource(DXW.DataSourceObject openXmlElement, DMW.MailMergeSourceKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DMW.MailMergeSourceKind>(openXmlElement.GetFirstChild<DXW.MailMergeSource>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.FirstRowHeader>()?.Val?.Value;
  }
  
  private static bool CmpFirstRowHeader(DXW.DataSourceObject openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.FirstRowHeader>()?.Val?.Value == value;
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
  
  private static bool CmpFieldMapDatas(DXW.DataSourceObject openXmlElement, Collection<DMW.FieldMapData>? value, DiffList? diffs, string? objName)
  {
    return true;
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
    return DMXW.RelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RecipientDataReference>());
  }
  
  private static bool CmpRecipientDataReference(DXW.DataSourceObject openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.RecipientDataReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXW.DataSourceObject? openXmlElement, DMW.DataSourceObject? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUdlConnectionString(openXmlElement, value.UdlConnectionString, diffs, objName))
        ok = false;
      if (!CmpDataSourceTableName(openXmlElement, value.DataSourceTableName, diffs, objName))
        ok = false;
      if (!CmpSourceReference(openXmlElement, value.SourceReference, diffs, objName))
        ok = false;
      if (!CmpColumnDelimiter(openXmlElement, value.ColumnDelimiter, diffs, objName))
        ok = false;
      if (!CmpMailMergeSource(openXmlElement, value.MailMergeSource, diffs, objName))
        ok = false;
      if (!CmpFirstRowHeader(openXmlElement, value.FirstRowHeader, diffs, objName))
        ok = false;
      if (!CmpFieldMapDatas(openXmlElement, value.FieldMapDatas, diffs, objName))
        ok = false;
      if (!CmpRecipientDataReference(openXmlElement, value.RecipientDataReference, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
