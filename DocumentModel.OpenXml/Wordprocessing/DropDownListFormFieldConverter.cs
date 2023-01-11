namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Drop-Down List Form Field Properties.
/// </summary>
public static class DropDownListFormFieldConverter
{
  /// <summary>
  /// Drop-Down List Selection.
  /// </summary>
  public static Int32? GetDropDownListSelection(DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.DropDownListSelection");
  }
  
  public static void SetDropDownListSelection(DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.DropDownListSelection");
  }
  
  /// <summary>
  /// Default Drop-Down List Item Index.
  /// </summary>
  public static Int32? GetDefaultDropDownListItemIndex(DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.DefaultDropDownListItemIndex");
  }
  
  public static void SetDefaultDropDownListItemIndex(DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.DefaultDropDownListItemIndex");
  }
  
  public static System.Collections.ObjectModel.Collection<String>? GetListEntryFormFields(DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<String>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField>())
      {
        var newItem = StringValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((string)newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetListEntryFormFields(DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField? openXmlElement, System.Collections.ObjectModel.Collection<String>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = StringValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DropDownListFormField? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DropDownListFormField();
      value.DropDownListSelection = GetDropDownListSelection(openXmlElement);
      value.DefaultDropDownListItemIndex = GetDefaultDropDownListItemIndex(openXmlElement);
      value.ListEntryFormFields = GetListEntryFormFields(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DropDownListFormField? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
