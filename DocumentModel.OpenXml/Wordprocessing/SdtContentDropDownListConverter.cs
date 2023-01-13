namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentDropDownList Class.
/// </summary>
public static class SdtContentDropDownListConverter
{
  /// <summary>
  /// Drop-down List Last Saved Value
  /// </summary>
  public static String? GetLastValue(DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList? openXmlElement)
  {
    return openXmlElement?.LastValue?.Value;
  }
  
  public static void SetLastValue(DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LastValue = new StringValue { Value = value };
      else
        openXmlElement.LastValue = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ListItem>? GetListItems(DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ListItem>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ListItem>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.ListItemConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetListItems(DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ListItem>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ListItem>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.ListItemConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ListItem>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtContentDropDownList? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentDropDownList();
      value.LastValue = GetLastValue(openXmlElement);
      value.ListItems = GetListItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtContentDropDownList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLastValue(openXmlElement, value?.LastValue);
      SetListItems(openXmlElement, value?.ListItems);
      return openXmlElement;
    }
    return default;
  }
}
