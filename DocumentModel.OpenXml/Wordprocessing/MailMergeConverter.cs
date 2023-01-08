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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLinkToQuery(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Data Source File Path.
  /// </summary>
  public static DocumentModel.Wordprocessing.RelationshipType? GetDataSourceReference(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataSourceReference(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Header Definition File Path.
  /// </summary>
  public static DocumentModel.Wordprocessing.RelationshipType? GetHeaderSource(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeaderSource(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Remove Blank Lines from Merged Documents.
  /// </summary>
  public static Boolean? GetDoNotSuppressBlankLines(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotSuppressBlankLines(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Merged Document To E-Mail Attachment.
  /// </summary>
  public static Boolean? GetMailAsAttachment(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMailAsAttachment(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// View Merged Data Within Document.
  /// </summary>
  public static Boolean? GetViewMergedData(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetViewMergedData(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Record Currently Displayed In Merged Document.
  /// </summary>
  public static Int32? GetActiveRecord(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetActiveRecord(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Mail Merge Error Reporting Setting.
  /// </summary>
  public static Int32? GetCheckErrors(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCheckErrors(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Office Data Source Object Settings.
  /// </summary>
  public static DocumentModel.Wordprocessing.DataSourceObject? GetDataSourceObject(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataSourceObject(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.DataSourceObject? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
