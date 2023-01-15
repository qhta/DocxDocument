using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using DataSourceObject = DocumentModel.Wordprocessing.DataSourceObject;
using MailMerge = DocumentFormat.OpenXml.Wordprocessing.MailMerge;
using RelationshipType = DocumentModel.Wordprocessing.RelationshipType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Mail Merge Settings.
/// </summary>
public static class MailMergeConverter
{
  /// <summary>
  ///   Source Document Type.
  /// </summary>
  public static MailMergeDocumentKind? GetMainDocumentType(MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MainDocumentType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<MailMergeDocumentValues, MailMergeDocumentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMainDocumentType(MailMerge? openXmlElement, MailMergeDocumentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MainDocumentType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<MainDocumentType, MailMergeDocumentValues, MailMergeDocumentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Query Contains Link to External Query File.
  /// </summary>
  public static Boolean? GetLinkToQuery(MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LinkToQuery>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLinkToQuery(MailMerge? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LinkToQuery>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LinkToQuery();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Data Source Type.
  /// </summary>
  public static MailMergeDataKind? GetDataType(MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DataType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<MailMergeDataValues, MailMergeDataKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDataType(MailMerge? openXmlElement, MailMergeDataKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DataType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DataType, MailMergeDataValues, MailMergeDataKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Data Source Connection String.
  /// </summary>
  public static String? GetConnectString(MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ConnectString>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetConnectString(MailMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ConnectString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ConnectString { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Query For Data Source Records To Merge.
  /// </summary>
  public static String? GetQuery(MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Query>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetQuery(MailMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Query>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Query { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Data Source File Path.
  /// </summary>
  public static RelationshipType? GetDataSourceReference(MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DataSourceReference>();
    if (itemElement != null)
      return RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataSourceReference(MailMerge? openXmlElement, RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DataSourceReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipTypeConverter.CreateOpenXmlElement<DataSourceReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Header Definition File Path.
  /// </summary>
  public static RelationshipType? GetHeaderSource(MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HeaderSource>();
    if (itemElement != null)
      return RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHeaderSource(MailMerge? openXmlElement, RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HeaderSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationshipTypeConverter.CreateOpenXmlElement<HeaderSource>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Remove Blank Lines from Merged Documents.
  /// </summary>
  public static Boolean? GetDoNotSuppressBlankLines(MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotSuppressBlankLines>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotSuppressBlankLines(MailMerge? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotSuppressBlankLines>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotSuppressBlankLines();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Merged Document Destination.
  /// </summary>
  public static MailMergeDestinationKind? GetDestination(MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Destination>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<MailMergeDestinationValues, MailMergeDestinationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDestination(MailMerge? openXmlElement, MailMergeDestinationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Destination>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Destination, MailMergeDestinationValues, MailMergeDestinationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Column Containing E-mail Address.
  /// </summary>
  public static String? GetAddressFieldName(MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AddressFieldName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAddressFieldName(MailMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AddressFieldName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new AddressFieldName { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Merged E-mail or Fax Subject Line.
  /// </summary>
  public static String? GetMailSubject(MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MailSubject>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMailSubject(MailMerge? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MailSubject>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MailSubject { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Merged Document To E-Mail Attachment.
  /// </summary>
  public static Boolean? GetMailAsAttachment(MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MailAsAttachment>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetMailAsAttachment(MailMerge? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<MailAsAttachment>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new MailAsAttachment();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   View Merged Data Within Document.
  /// </summary>
  public static Boolean? GetViewMergedData(MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ViewMergedData>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetViewMergedData(MailMerge? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ViewMergedData>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ViewMergedData();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Record Currently Displayed In Merged Document.
  /// </summary>
  public static Int32? GetActiveRecord(MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ActiveRecord>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetActiveRecord(MailMerge? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ActiveRecord>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ActiveRecord { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Mail Merge Error Reporting Setting.
  /// </summary>
  public static Int32? GetCheckErrors(MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CheckErrors>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCheckErrors(MailMerge? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CheckErrors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new CheckErrors { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Office Data Source Object Settings.
  /// </summary>
  public static DataSourceObject? GetDataSourceObject(MailMerge? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceObject>();
    if (itemElement != null)
      return DataSourceObjectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataSourceObject(MailMerge? openXmlElement, DataSourceObject? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataSourceObject>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataSourceObjectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DataSourceObject>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.MailMerge? CreateModelElement(MailMerge? openXmlElement)
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
    where OpenXmlElementType : MailMerge, new()
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