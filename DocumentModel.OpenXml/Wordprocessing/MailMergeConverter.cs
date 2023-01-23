namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Mail Merge Settings.
/// </summary>
public static class MailMergeConverter
{
  /// <summary>
  /// Source Document Type.
  /// </summary>
  private static DMW.MailMergeDocumentKind? GetMainDocumentType(DXW.MailMerge openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DMW.MailMergeDocumentKind>(openXmlElement.GetFirstChild<DXW.MainDocumentType>()?.Val?.Value);
  }
  
  private static bool CmpMainDocumentType(DXW.MailMerge openXmlElement, DMW.MailMergeDocumentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DMW.MailMergeDocumentKind>(openXmlElement.GetFirstChild<DXW.MainDocumentType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMainDocumentType(DXW.MailMerge openXmlElement, DMW.MailMergeDocumentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MainDocumentType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.MainDocumentType, DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DMW.MailMergeDocumentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Query Contains Link to External Query File.
  /// </summary>
  private static Boolean? GetLinkToQuery(DXW.MailMerge openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.LinkToQuery>()?.Val?.Value;
  }
  
  private static bool CmpLinkToQuery(DXW.MailMerge openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.LinkToQuery>()?.Val?.Value == value;
  }
  
  private static void SetLinkToQuery(DXW.MailMerge openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.LinkToQuery>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.LinkToQuery();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Source Type.
  /// </summary>
  private static DMW.MailMergeDataKind? GetDataType(DXW.MailMerge openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DMW.MailMergeDataKind>(openXmlElement.GetFirstChild<DXW.DataType>()?.Val?.Value);
  }
  
  private static bool CmpDataType(DXW.MailMerge openXmlElement, DMW.MailMergeDataKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DMW.MailMergeDataKind>(openXmlElement.GetFirstChild<DXW.DataType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataType(DXW.MailMerge openXmlElement, DMW.MailMergeDataKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DataType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.DataType, DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DMW.MailMergeDataKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Source Connection String.
  /// </summary>
  private static String? GetConnectString(DXW.MailMerge openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ConnectString>()?.Val?.Value;
  }
  
  private static bool CmpConnectString(DXW.MailMerge openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.ConnectString>()?.Val?.Value == value;
  }
  
  private static void SetConnectString(DXW.MailMerge openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ConnectString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ConnectString { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Query For Data Source Records To Merge.
  /// </summary>
  private static String? GetQuery(DXW.MailMerge openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.Query>()?.Val?.Value;
  }
  
  private static bool CmpQuery(DXW.MailMerge openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.Query>()?.Val?.Value == value;
  }
  
  private static void SetQuery(DXW.MailMerge openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Query>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Query { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Source File Path.
  /// </summary>
  private static DMW.RelationshipType? GetDataSourceReference(DXW.MailMerge openXmlElement)
  {
    return DMXW.RelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DataSourceReference>());
  }
  
  private static bool CmpDataSourceReference(DXW.MailMerge openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.DataSourceReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataSourceReference(DXW.MailMerge openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DataSourceReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.DataSourceReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Header Definition File Path.
  /// </summary>
  private static DMW.RelationshipType? GetHeaderSource(DXW.MailMerge openXmlElement)
  {
    return DMXW.RelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.HeaderSource>());
  }
  
  private static bool CmpHeaderSource(DXW.MailMerge openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.HeaderSource>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHeaderSource(DXW.MailMerge openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HeaderSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.HeaderSource>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Remove Blank Lines from Merged Documents.
  /// </summary>
  private static Boolean? GetDoNotSuppressBlankLines(DXW.MailMerge openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotSuppressBlankLines>()?.Val?.Value;
  }
  
  private static bool CmpDoNotSuppressBlankLines(DXW.MailMerge openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotSuppressBlankLines>()?.Val?.Value == value;
  }
  
  private static void SetDoNotSuppressBlankLines(DXW.MailMerge openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotSuppressBlankLines>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotSuppressBlankLines();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Merged Document Destination.
  /// </summary>
  private static DMW.MailMergeDestinationKind? GetDestination(DXW.MailMerge openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DMW.MailMergeDestinationKind>(openXmlElement.GetFirstChild<DXW.Destination>()?.Val?.Value);
  }
  
  private static bool CmpDestination(DXW.MailMerge openXmlElement, DMW.MailMergeDestinationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DMW.MailMergeDestinationKind>(openXmlElement.GetFirstChild<DXW.Destination>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDestination(DXW.MailMerge openXmlElement, DMW.MailMergeDestinationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Destination>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Destination, DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DMW.MailMergeDestinationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Column Containing E-mail Address.
  /// </summary>
  private static String? GetAddressFieldName(DXW.MailMerge openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AddressFieldName>()?.Val?.Value;
  }
  
  private static bool CmpAddressFieldName(DXW.MailMerge openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AddressFieldName>()?.Val?.Value == value;
  }
  
  private static void SetAddressFieldName(DXW.MailMerge openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AddressFieldName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.AddressFieldName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Merged E-mail or Fax Subject Line.
  /// </summary>
  private static String? GetMailSubject(DXW.MailMerge openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.MailSubject>()?.Val?.Value;
  }
  
  private static bool CmpMailSubject(DXW.MailMerge openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.MailSubject>()?.Val?.Value == value;
  }
  
  private static void SetMailSubject(DXW.MailMerge openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MailSubject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.MailSubject { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Merged Document To E-Mail Attachment.
  /// </summary>
  private static Boolean? GetMailAsAttachment(DXW.MailMerge openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.MailAsAttachment>()?.Val?.Value;
  }
  
  private static bool CmpMailAsAttachment(DXW.MailMerge openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.MailAsAttachment>()?.Val?.Value == value;
  }
  
  private static void SetMailAsAttachment(DXW.MailMerge openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.MailAsAttachment>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.MailAsAttachment();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// View Merged Data Within Document.
  /// </summary>
  private static Boolean? GetViewMergedData(DXW.MailMerge openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ViewMergedData>()?.Val?.Value;
  }
  
  private static bool CmpViewMergedData(DXW.MailMerge openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.ViewMergedData>()?.Val?.Value == value;
  }
  
  private static void SetViewMergedData(DXW.MailMerge openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ViewMergedData>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ViewMergedData();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Record Currently Displayed In Merged Document.
  /// </summary>
  private static Int32? GetActiveRecord(DXW.MailMerge openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.ActiveRecord>()?.Val?.Value;
  }
  
  private static bool CmpActiveRecord(DXW.MailMerge openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.ActiveRecord>()?.Val?.Value == value;
  }
  
  private static void SetActiveRecord(DXW.MailMerge openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ActiveRecord>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ActiveRecord{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Mail Merge Error Reporting Setting.
  /// </summary>
  private static Int32? GetCheckErrors(DXW.MailMerge openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.CheckErrors>()?.Val?.Value;
  }
  
  private static bool CmpCheckErrors(DXW.MailMerge openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.CheckErrors>()?.Val?.Value == value;
  }
  
  private static void SetCheckErrors(DXW.MailMerge openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CheckErrors>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.CheckErrors{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Office Data Source Object Settings.
  /// </summary>
  private static DMW.DataSourceObject? GetDataSourceObject(DXW.MailMerge openXmlElement)
  {
    return DMXW.DataSourceObjectConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DataSourceObject>());
  }
  
  private static bool CmpDataSourceObject(DXW.MailMerge openXmlElement, DMW.DataSourceObject? value, DiffList? diffs, string? objName)
  {
    return DMXW.DataSourceObjectConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.DataSourceObject>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataSourceObject(DXW.MailMerge openXmlElement, DMW.DataSourceObject? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DataSourceObject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DataSourceObjectConverter.CreateOpenXmlElement<DXW.DataSourceObject>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.MailMerge? CreateModelElement(DXW.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MailMerge();
      value.MainDocumentType = GetMainDocumentType(openXmlElement);
      value.LinkToQuery = GetLinkToQuery(openXmlElement);
      value.DataType = GetDataType(openXmlElement);
      value.ConnectString = GetConnectString(openXmlElement);
      value.Query = GetQuery(openXmlElement);
      value.DataSourceReference = GetDataSourceReference(openXmlElement);
      value.HeaderSource = GetHeaderSource(openXmlElement);
      value.DoNotSuppressBlankLines = GetDoNotSuppressBlankLines(openXmlElement);
      value.Destination = GetDestination(openXmlElement);
      value.AddressFieldName = GetAddressFieldName(openXmlElement);
      value.MailSubject = GetMailSubject(openXmlElement);
      value.MailAsAttachment = GetMailAsAttachment(openXmlElement);
      value.ViewMergedData = GetViewMergedData(openXmlElement);
      value.ActiveRecord = GetActiveRecord(openXmlElement);
      value.CheckErrors = GetCheckErrors(openXmlElement);
      value.DataSourceObject = GetDataSourceObject(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.MailMerge? openXmlElement, DMW.MailMerge? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMainDocumentType(openXmlElement, value.MainDocumentType, diffs, objName))
        ok = false;
      if (!CmpLinkToQuery(openXmlElement, value.LinkToQuery, diffs, objName))
        ok = false;
      if (!CmpDataType(openXmlElement, value.DataType, diffs, objName))
        ok = false;
      if (!CmpConnectString(openXmlElement, value.ConnectString, diffs, objName))
        ok = false;
      if (!CmpQuery(openXmlElement, value.Query, diffs, objName))
        ok = false;
      if (!CmpDataSourceReference(openXmlElement, value.DataSourceReference, diffs, objName))
        ok = false;
      if (!CmpHeaderSource(openXmlElement, value.HeaderSource, diffs, objName))
        ok = false;
      if (!CmpDoNotSuppressBlankLines(openXmlElement, value.DoNotSuppressBlankLines, diffs, objName))
        ok = false;
      if (!CmpDestination(openXmlElement, value.Destination, diffs, objName))
        ok = false;
      if (!CmpAddressFieldName(openXmlElement, value.AddressFieldName, diffs, objName))
        ok = false;
      if (!CmpMailSubject(openXmlElement, value.MailSubject, diffs, objName))
        ok = false;
      if (!CmpMailAsAttachment(openXmlElement, value.MailAsAttachment, diffs, objName))
        ok = false;
      if (!CmpViewMergedData(openXmlElement, value.ViewMergedData, diffs, objName))
        ok = false;
      if (!CmpActiveRecord(openXmlElement, value.ActiveRecord, diffs, objName))
        ok = false;
      if (!CmpCheckErrors(openXmlElement, value.CheckErrors, diffs, objName))
        ok = false;
      if (!CmpDataSourceObject(openXmlElement, value.DataSourceObject, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.MailMerge? value)
    where OpenXmlElementType: DXW.MailMerge, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMainDocumentType(openXmlElement, value?.MainDocumentType);
      SetLinkToQuery(openXmlElement, value?.LinkToQuery);
      SetDataType(openXmlElement, value?.DataType);
      SetConnectString(openXmlElement, value?.ConnectString);
      SetQuery(openXmlElement, value?.Query);
      SetDataSourceReference(openXmlElement, value?.DataSourceReference);
      SetHeaderSource(openXmlElement, value?.HeaderSource);
      SetDoNotSuppressBlankLines(openXmlElement, value?.DoNotSuppressBlankLines);
      SetDestination(openXmlElement, value?.Destination);
      SetAddressFieldName(openXmlElement, value?.AddressFieldName);
      SetMailSubject(openXmlElement, value?.MailSubject);
      SetMailAsAttachment(openXmlElement, value?.MailAsAttachment);
      SetViewMergedData(openXmlElement, value?.ViewMergedData);
      SetActiveRecord(openXmlElement, value?.ActiveRecord);
      SetCheckErrors(openXmlElement, value?.CheckErrors);
      SetDataSourceObject(openXmlElement, value?.DataSourceObject);
      return openXmlElement;
    }
    return default;
  }
}
