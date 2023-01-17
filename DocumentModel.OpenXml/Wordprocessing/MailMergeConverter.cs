namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Mail Merge Settings.
/// </summary>
public static class MailMergeConverter
{
  /// <summary>
  /// Source Document Type.
  /// </summary>
  private static DocumentModel.Wordprocessing.MailMergeDocumentKind? GetMainDocumentType(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MainDocumentType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DocumentModel.Wordprocessing.MailMergeDocumentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetMainDocumentType(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, DocumentModel.Wordprocessing.MailMergeDocumentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MainDocumentType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MainDocumentType, DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DocumentModel.Wordprocessing.MailMergeDocumentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Query Contains Link to External Query File.
  /// </summary>
  private static Boolean? GetLinkToQuery(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkToQuery>();
    return itemElement != null;
  }
  
  private static void SetLinkToQuery(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkToQuery>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.LinkToQuery();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Source Type.
  /// </summary>
  private static DocumentModel.Wordprocessing.MailMergeDataKind? GetDataType(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DocumentModel.Wordprocessing.MailMergeDataKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetDataType(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, DocumentModel.Wordprocessing.MailMergeDataKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DataType, DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DocumentModel.Wordprocessing.MailMergeDataKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Source Connection String.
  /// </summary>
  private static String? GetConnectString(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConnectString>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetConnectString(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConnectString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.ConnectString { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Query For Data Source Records To Merge.
  /// </summary>
  private static String? GetQuery(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Query>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetQuery(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Query>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.Query { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Source File Path.
  /// </summary>
  private static DocumentModel.Wordprocessing.RelationshipType? GetDataSourceReference(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataSourceReference(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DataSourceReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Header Definition File Path.
  /// </summary>
  private static DocumentModel.Wordprocessing.RelationshipType? GetHeaderSource(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderSource>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHeaderSource(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HeaderSource>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Remove Blank Lines from Merged Documents.
  /// </summary>
  private static Boolean? GetDoNotSuppressBlankLines(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressBlankLines>();
    return itemElement != null;
  }
  
  private static void SetDoNotSuppressBlankLines(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressBlankLines>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressBlankLines();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Merged Document Destination.
  /// </summary>
  private static DocumentModel.Wordprocessing.MailMergeDestinationKind? GetDestination(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Destination>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DocumentModel.Wordprocessing.MailMergeDestinationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetDestination(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, DocumentModel.Wordprocessing.MailMergeDestinationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Destination>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Destination, DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DocumentModel.Wordprocessing.MailMergeDestinationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Column Containing E-mail Address.
  /// </summary>
  private static String? GetAddressFieldName(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AddressFieldName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAddressFieldName(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AddressFieldName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.AddressFieldName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Merged E-mail or Fax Subject Line.
  /// </summary>
  private static String? GetMailSubject(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailSubject>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMailSubject(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailSubject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.MailSubject { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Merged Document To E-Mail Attachment.
  /// </summary>
  private static Boolean? GetMailAsAttachment(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailAsAttachment>();
    return itemElement != null;
  }
  
  private static void SetMailAsAttachment(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailAsAttachment>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.MailAsAttachment();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// View Merged Data Within Document.
  /// </summary>
  private static Boolean? GetViewMergedData(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ViewMergedData>();
    return itemElement != null;
  }
  
  private static void SetViewMergedData(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ViewMergedData>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ViewMergedData();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Record Currently Displayed In Merged Document.
  /// </summary>
  private static Int32? GetActiveRecord(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ActiveRecord>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetActiveRecord(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ActiveRecord>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.ActiveRecord{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Mail Merge Error Reporting Setting.
  /// </summary>
  private static Int32? GetCheckErrors(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CheckErrors>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetCheckErrors(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CheckErrors>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.CheckErrors{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Office Data Source Object Settings.
  /// </summary>
  private static DocumentModel.Wordprocessing.DataSourceObject? GetDataSourceObject(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceObject>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DataSourceObjectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataSourceObject(DocumentFormat.OpenXml.Wordprocessing.MailMerge openXmlElement, DocumentModel.Wordprocessing.DataSourceObject? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceObject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DataSourceObjectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DataSourceObject>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.MailMerge? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MailMerge();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MailMerge? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.MailMerge, new()
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
