using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Data About Single Data Source Record.
/// </summary>
public static class RecipientDataConverter
{
  /// <summary>
  ///   Record Is Included in Mail Merge.
  /// </summary>
  public static Boolean? GetActive(RecipientData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Active>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetActive(RecipientData? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Active>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Active();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Index of Column Containing Unique Values for Record.
  /// </summary>
  public static UInt32? GetColumnIndex(RecipientData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ColumnIndex>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetColumnIndex(RecipientData? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ColumnIndex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ColumnIndex { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Unique Value for Record.
  /// </summary>
  public static Byte[]? GetUniqueTag(RecipientData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<UniqueTag>();
    if (itemElement != null)
      return ByteArrayConverter.GetValue(itemElement);
    return null;
  }

  public static void SetUniqueTag(RecipientData? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UniqueTag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ByteArrayConverter.CreateOpenXmlElement<UniqueTag>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.RecipientData? CreateModelElement(RecipientData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RecipientData();
      value.Active = GetActive(openXmlElement);
      value.ColumnIndex = GetColumnIndex(openXmlElement);
      value.UniqueTag = GetUniqueTag(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RecipientData? value)
    where OpenXmlElementType : RecipientData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetActive(openXmlElement, value?.Active);
      SetColumnIndex(openXmlElement, value?.ColumnIndex);
      SetUniqueTag(openXmlElement, value?.UniqueTag);
      return openXmlElement;
    }
    return default;
  }
}