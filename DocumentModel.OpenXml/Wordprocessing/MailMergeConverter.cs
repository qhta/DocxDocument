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
    var itemElement = openXmlElement.GetFirstChild<DXW.MainDocumentType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DMW.MailMergeDocumentKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.LinkToQuery>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DataType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DMW.MailMergeDataKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.ConnectString>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.Query>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DataSourceReference>();
    if (itemElement != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.HeaderSource>();
    if (itemElement != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotSuppressBlankLines>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.Destination>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DMW.MailMergeDestinationKind>(itemElement.Val.Value);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.AddressFieldName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.MailSubject>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.MailAsAttachment>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.ViewMergedData>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ActiveRecord>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CheckErrors>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DataSourceObject>();
    if (itemElement != null)
      return DMXW.DataSourceObjectConverter.CreateModelElement(itemElement);
    return null;
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
