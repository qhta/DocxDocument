namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Types.
/// </summary>
public static class DocPartTypesConverter
{
  /// <summary>
  /// Entry Is Of All Types
  /// </summary>
  public static Boolean? GetAll(DocumentFormat.OpenXml.Wordprocessing.DocPartTypes? openXmlElement)
  {
    return openXmlElement?.All?.Value;
  }
  
  public static void SetAll(DocumentFormat.OpenXml.Wordprocessing.DocPartTypes? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.All = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.All = null;
  }
  
  public static DocumentModel.Wordprocessing.DocPartKind? GetDocPartType(DocumentFormat.OpenXml.Wordprocessing.DocPartTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DocumentModel.Wordprocessing.DocPartKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDocPartType(DocumentFormat.OpenXml.Wordprocessing.DocPartTypes? openXmlElement, DocumentModel.Wordprocessing.DocPartKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartType, DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DocumentModel.Wordprocessing.DocPartKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DocPartTypes? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DocPartTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocPartTypes();
      value.All = GetAll(openXmlElement);
      value.DocPartType = GetDocPartType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocPartTypes? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DocPartTypes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAll(openXmlElement, value?.All);
      return openXmlElement;
    }
    return default;
  }
}
