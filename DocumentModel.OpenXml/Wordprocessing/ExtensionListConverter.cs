namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  public static Collection<DocumentModel.Wordprocessing.Extension>? GetExtensions(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DocumentModel.Wordprocessing.Extension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension>())
      {
        var newItem = ExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetExtensions(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList? openXmlElement, Collection<DocumentModel.Wordprocessing.Extension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Word.ExtensionList.Extension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.ExtensionList? CreateModelElement(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ExtensionList? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtensions(openXmlElement, value?.Extensions);
      return openXmlElement;
    }
    return default;
  }
}