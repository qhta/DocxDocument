namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Data About Single Data Source Record.
/// </summary>
public static class RecipientDataConverter
{
  /// <summary>
  /// Record Is Included in Mail Merge.
  /// </summary>
  public static Boolean? GetActive(DocumentFormat.OpenXml.Wordprocessing.RecipientData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Active>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetActive(DocumentFormat.OpenXml.Wordprocessing.RecipientData? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Index of Column Containing Unique Values for Record.
  /// </summary>
  public static UInt32? GetColumnIndex(DocumentFormat.OpenXml.Wordprocessing.RecipientData? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.ColumnIndex");
  }
  
  public static void SetColumnIndex(DocumentFormat.OpenXml.Wordprocessing.RecipientData? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.ColumnIndex");
  }
  
  /// <summary>
  /// Unique Value for Record.
  /// </summary>
  public static DocumentModel.Base64Binary? GetUniqueTag(DocumentFormat.OpenXml.Wordprocessing.RecipientData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UniqueTag>();
    if (itemElement != null)
      return Base64BinaryConverter.GetValue(itemElement);
    return null;
  }
  
  public static void SetUniqueTag(DocumentFormat.OpenXml.Wordprocessing.RecipientData? openXmlElement, DocumentModel.Base64Binary? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.UniqueTag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Base64BinaryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.UniqueTag>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
