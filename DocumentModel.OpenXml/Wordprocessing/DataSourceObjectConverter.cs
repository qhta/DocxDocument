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
    return openXmlElement?.UdlConnectionString?.Val?.Value;
  }
  
  public static void SetUdlConnectionString(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Data Source Table Name.
  /// </summary>
  public static String? GetDataSourceTableName(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    return openXmlElement?.DataSourceTableName?.Val?.Value;
  }
  
  public static void SetDataSourceTableName(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ODSO Data Source File Path.
  /// </summary>
  public static DocumentModel.Wordprocessing.RelationshipType? GetSourceReference(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSourceReference(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Column Delimiter for Data Source.
  /// </summary>
  public static UInt32? GetColumnDelimiter(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnDelimiter(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFirstRowHeader(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FieldMapData>? GetFieldMapDatas(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFieldMapDatas(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.FieldMapData>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.RelationshipType? GetRecipientDataReference(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRecipientDataReference(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
