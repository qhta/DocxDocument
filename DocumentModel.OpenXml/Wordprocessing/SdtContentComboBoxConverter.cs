namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentComboBox Class.
/// </summary>
public static class SdtContentComboBoxConverter
{
  /// <summary>
  /// Combo Box Last Saved Value
  /// </summary>
  public static String? GetLastValue(DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox? openXmlElement)
  {
    return openXmlElement?.LastValue?.Value;
  }
  
  public static void SetLastValue(DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LastValue = new StringValue { Value = value };
      else
        openXmlElement.LastValue = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ListItem>? GetListItems(DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox? openXmlElement)
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
  
  public static void SetListItems(DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ListItem>? value)
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
  
  public static DocumentModel.Wordprocessing.SdtContentComboBox? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentComboBox();
      value.LastValue = GetLastValue(openXmlElement);
      value.ListItems = GetListItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtContentComboBox? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
