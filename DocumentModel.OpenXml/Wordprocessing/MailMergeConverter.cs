namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Mail Merge Settings.
/// </summary>
public static class MailMergeConverter
{
  /// <summary>
  /// Source Document Type.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeDocumentKind? GetMainDocumentType(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MainDocumentType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DocumentModel.Wordprocessing.MailMergeDocumentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMainDocumentType(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.MailMergeDocumentKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Query Contains Link to External Query File.
  /// </summary>
  public static Boolean? GetLinkToQuery(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkToQuery>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetLinkToQuery(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Data Source Type.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeDataKind? GetDataType(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DocumentModel.Wordprocessing.MailMergeDataKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDataType(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.MailMergeDataKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Data Source Connection String.
  /// </summary>
  public static String? GetConnectString(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    return openXmlElement?.ConnectString?.Val?.Value;
  }
  
  public static void SetConnectString(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.ConnectString = new DocumentFormat.OpenXml.Wordprocessing.ConnectString { Val = value };
      else
        openXmlElement.ConnectString = null;
    }
  }
  
  /// <summary>
  /// Query For Data Source Records To Merge.
  /// </summary>
  public static String? GetQuery(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    return openXmlElement?.Query?.Val?.Value;
  }
  
  public static void SetQuery(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Query = new DocumentFormat.OpenXml.Wordprocessing.Query { Val = value };
      else
        openXmlElement.Query = null;
    }
  }
  
  /// <summary>
  /// Data Source File Path.
  /// </summary>
  public static DocumentModel.Wordprocessing.RelationshipType? GetDataSourceReference(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataSourceReference(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Header Definition File Path.
  /// </summary>
  public static DocumentModel.Wordprocessing.RelationshipType? GetHeaderSource(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HeaderSource>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHeaderSource(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Remove Blank Lines from Merged Documents.
  /// </summary>
  public static Boolean? GetDoNotSuppressBlankLines(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSuppressBlankLines>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotSuppressBlankLines(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Merged Document Destination.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeDestinationKind? GetDestination(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Destination>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DocumentModel.Wordprocessing.MailMergeDestinationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDestination(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.MailMergeDestinationKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Column Containing E-mail Address.
  /// </summary>
  public static String? GetAddressFieldName(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    return openXmlElement?.AddressFieldName?.Val?.Value;
  }
  
  public static void SetAddressFieldName(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.AddressFieldName = new DocumentFormat.OpenXml.Wordprocessing.AddressFieldName { Val = value };
      else
        openXmlElement.AddressFieldName = null;
    }
  }
  
  /// <summary>
  /// Merged E-mail or Fax Subject Line.
  /// </summary>
  public static String? GetMailSubject(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    return openXmlElement?.MailSubject?.Val?.Value;
  }
  
  public static void SetMailSubject(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.MailSubject = new DocumentFormat.OpenXml.Wordprocessing.MailSubject { Val = value };
      else
        openXmlElement.MailSubject = null;
    }
  }
  
  /// <summary>
  /// Merged Document To E-Mail Attachment.
  /// </summary>
  public static Boolean? GetMailAsAttachment(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailAsAttachment>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetMailAsAttachment(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// View Merged Data Within Document.
  /// </summary>
  public static Boolean? GetViewMergedData(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ViewMergedData>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetViewMergedData(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Record Currently Displayed In Merged Document.
  /// </summary>
  public static Int32? GetActiveRecord(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.ActiveRecord");
  }
  
  public static void SetActiveRecord(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.ActiveRecord");
  }
  
  /// <summary>
  /// Mail Merge Error Reporting Setting.
  /// </summary>
  public static Int32? GetCheckErrors(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.CheckErrors");
  }
  
  public static void SetCheckErrors(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.CheckErrors");
  }
  
  /// <summary>
  /// Office Data Source Object Settings.
  /// </summary>
  public static DocumentModel.Wordprocessing.DataSourceObject? GetDataSourceObject(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceObject>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DataSourceObjectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataSourceObject(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.DataSourceObject? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
