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
  
  private static bool CmpUdlConnectionString(DXW.DataSourceObject openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UdlConnectionString>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "UdlConnectionString", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetUdlConnectionString(DXW.DataSourceObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.UdlConnectionString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.UdlConnectionString { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Source Table Name.
  /// </summary>
  private static String? GetDataSourceTableName(DXW.DataSourceObject openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DataSourceTableName>()?.Val?.Value;
  }
  
  private static bool CmpDataSourceTableName(DXW.DataSourceObject openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DataSourceTableName>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DataSourceTableName", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetDataSourceTableName(DXW.DataSourceObject openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DataSourceTableName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DataSourceTableName { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ODSO Data Source File Path.
  /// </summary>
  private static DMW.RelationshipType? GetSourceReference(DXW.DataSourceObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SourceReference>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSourceReference(DXW.DataSourceObject openXmlElement, DMW.RelationshipType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SourceReference>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Column Delimiter for Data Source.
  /// </summary>
  private static UInt32? GetColumnDelimiter(DXW.DataSourceObject openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.ColumnDelimiter>()?.Val);
  }
  
  private static bool CmpColumnDelimiter(DXW.DataSourceObject openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.ColumnDelimiter>()?.Val, value, diffs, objName, "ColumnDelimiter");
  }
  
  private static void SetColumnDelimiter(DXW.DataSourceObject openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXW.ColumnDelimiter,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// ODSO Data Source Type.
  /// </summary>
  private static DMW.MailMergeSourceKind? GetMailMergeSource(DXW.DataSourceObject openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.MailMergeSourceValues, DMW.MailMergeSourceKind>(openXmlElement.GetFirstChild<DXW.MailMergeSource>()?.Val?.Value);
  }
  
  private static bool CmpMailMergeSource(DXW.DataSourceObject openXmlElement, DMW.MailMergeSourceKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.MailMergeSourceValues, DMW.MailMergeSourceKind>(openXmlElement.GetFirstChild<DXW.MailMergeSource>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetMailMergeSource(DXW.DataSourceObject openXmlElement, DMW.MailMergeSourceKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MailMergeSource>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.MailMergeSourceValues, DMW.MailMergeSourceKind>(itemElement, (DMW.MailMergeSourceKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.MailMergeSource, DXW.MailMergeSourceValues, DMW.MailMergeSourceKind>((DMW.MailMergeSourceKind)value));
  }
  
  /// <summary>
  /// First Row of Data Source Contains Column Names.
  /// </summary>
  private static Boolean? GetFirstRowHeader(DXW.DataSourceObject openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.FirstRowHeader>());
  }
  
  private static bool CmpFirstRowHeader(DXW.DataSourceObject openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.FirstRowHeader>(), value, diffs, objName, propName);
  }
  
  private static void SetFirstRowHeader(DXW.DataSourceObject openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.FirstRowHeader>(openXmlElement, value, "0", null);
  }
  
  private static Collection<DMW.FieldMapData>? GetFieldMapDatas(DXW.DataSourceObject openXmlElement)
  {
    var collection = new Collection<DMW.FieldMapData>();
    foreach (var item in openXmlElement.Elements<DXW.FieldMapData>())
    {
      var newItem = DMXW.FieldMapDataConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpFieldMapDatas(DXW.DataSourceObject openXmlElement, Collection<DMW.FieldMapData>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXW.FieldMapData>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.FieldMapDataConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMW.RelationshipType? GetRecipientDataReference(DXW.DataSourceObject openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RecipientDataReference>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRecipientDataReference(DXW.DataSourceObject openXmlElement, DMW.RelationshipType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RecipientDataReference>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
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
  
  public static bool CompareModelElement(DXW.DataSourceObject? openXmlElement, DMW.DataSourceObject? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUdlConnectionString(openXmlElement, value.UdlConnectionString, diffs, objName, propName))
        ok = false;
      if (!CmpDataSourceTableName(openXmlElement, value.DataSourceTableName, diffs, objName, propName))
        ok = false;
      if (!CmpSourceReference(openXmlElement, value.SourceReference, diffs, objName, propName))
        ok = false;
      if (!CmpColumnDelimiter(openXmlElement, value.ColumnDelimiter, diffs, objName, propName))
        ok = false;
      if (!CmpMailMergeSource(openXmlElement, value.MailMergeSource, diffs, objName, propName))
        ok = false;
      if (!CmpFirstRowHeader(openXmlElement, value.FirstRowHeader, diffs, objName, propName))
        ok = false;
      if (!CmpFieldMapDatas(openXmlElement, value.FieldMapDatas, diffs, objName, propName))
        ok = false;
      if (!CmpRecipientDataReference(openXmlElement, value.RecipientDataReference, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DataSourceObject value)
    where OpenXmlElementType: DXW.DataSourceObject, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DataSourceObject openXmlElement, DMW.DataSourceObject value)
  {
    SetUdlConnectionString(openXmlElement, value?.UdlConnectionString);
    SetDataSourceTableName(openXmlElement, value?.DataSourceTableName);
    SetSourceReference(openXmlElement, value?.SourceReference);
    SetColumnDelimiter(openXmlElement, value?.ColumnDelimiter);
    SetMailMergeSource(openXmlElement, value?.MailMergeSource);
    SetFirstRowHeader(openXmlElement, value?.FirstRowHeader);
    SetFieldMapDatas(openXmlElement, value?.FieldMapDatas);
    SetRecipientDataReference(openXmlElement, value?.RecipientDataReference);
  }
}
