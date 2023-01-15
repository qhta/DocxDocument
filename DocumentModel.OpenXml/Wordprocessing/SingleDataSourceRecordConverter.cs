using DocumentFormat.OpenXml.Office.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SingleDataSourceRecord Class.
/// </summary>
public static class SingleDataSourceRecordConverter
{
  /// <summary>
  ///   RecordIncluded.
  /// </summary>
  public static Boolean? GetRecordIncluded(SingleDataSourceRecord? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RecordIncluded>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRecordIncluded(SingleDataSourceRecord? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<RecordIncluded>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new RecordIncluded();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   RecordHashCode.
  /// </summary>
  public static Int64? GetRecordHashCode(SingleDataSourceRecord? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RecordHashCode>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRecordHashCode(SingleDataSourceRecord? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RecordHashCode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new RecordHashCode { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.SingleDataSourceRecord? CreateModelElement(SingleDataSourceRecord? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SingleDataSourceRecord();
      value.RecordIncluded = GetRecordIncluded(openXmlElement);
      value.RecordHashCode = GetRecordHashCode(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SingleDataSourceRecord? value)
    where OpenXmlElementType : SingleDataSourceRecord, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRecordIncluded(openXmlElement, value?.RecordIncluded);
      SetRecordHashCode(openXmlElement, value?.RecordHashCode);
      return openXmlElement;
    }
    return default;
  }
}