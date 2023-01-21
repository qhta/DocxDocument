namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Data About Single Data Source Record.
/// </summary>
public static class RecipientDataConverter
{
  /// <summary>
  /// Record Is Included in Mail Merge.
  /// </summary>
  private static Boolean? GetActive(DocumentFormat.OpenXml.Wordprocessing.RecipientData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Active>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetActive(DocumentFormat.OpenXml.Wordprocessing.RecipientData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Active>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Active();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Index of Column Containing Unique Values for Record.
  /// </summary>
  private static UInt32? GetColumnIndex(DocumentFormat.OpenXml.Wordprocessing.RecipientData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColumnIndex>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetColumnIndex(DocumentFormat.OpenXml.Wordprocessing.RecipientData openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ColumnIndex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.ColumnIndex{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Unique Value for Record.
  /// </summary>
  private static Byte[]? GetUniqueTag(DocumentFormat.OpenXml.Wordprocessing.RecipientData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UniqueTag>();
    if (itemElement != null)
      return DocumentModel.OpenXml.HexBinaryConverter.GetValue(itemElement);
    return null;
  }
  
  private static void SetUniqueTag(DocumentFormat.OpenXml.Wordprocessing.RecipientData openXmlElement, Byte[]? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UniqueTag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.HexBinaryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.UniqueTag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.RecipientData? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.RecipientData? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.RecipientData, new()
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
