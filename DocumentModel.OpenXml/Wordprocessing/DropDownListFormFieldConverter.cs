using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Drop-Down List Form Field Properties.
/// </summary>
public static class DropDownListFormFieldConverter
{
  /// <summary>
  ///   Drop-Down List Selection.
  /// </summary>
  public static Int32? GetDropDownListSelection(DropDownListFormField? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DropDownListSelection>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDropDownListSelection(DropDownListFormField? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DropDownListSelection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DropDownListSelection { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Default Drop-Down List Item Index.
  /// </summary>
  public static Int32? GetDefaultDropDownListItemIndex(DropDownListFormField? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DefaultDropDownListItemIndex>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDefaultDropDownListItemIndex(DropDownListFormField? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DefaultDropDownListItemIndex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DefaultDropDownListItemIndex { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<String>? GetListEntryFormFields(DropDownListFormField? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<String>();
      foreach (var item in openXmlElement.Elements<ListEntryFormField>())
      {
        var newItem = StringValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((string)newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetListEntryFormFields(DropDownListFormField? openXmlElement, Collection<String>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<ListEntryFormField>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StringValueConverter.CreateOpenXmlElement<ListEntryFormField>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.DropDownListFormField? CreateModelElement(DropDownListFormField? openXmlElement)
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
    where OpenXmlElementType : DropDownListFormField, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDropDownListSelection(openXmlElement, value?.DropDownListSelection);
      SetDefaultDropDownListItemIndex(openXmlElement, value?.DefaultDropDownListItemIndex);
      SetListEntryFormFields(openXmlElement, value?.ListEntryFormFields);
      return openXmlElement;
    }
    return default;
  }
}