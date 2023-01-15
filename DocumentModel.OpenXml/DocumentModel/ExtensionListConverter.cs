namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  public static Collection<Extension>? GetExtensions(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Extension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>())
      {
        var newItem = ExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetExtensions(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList? openXmlElement, Collection<Extension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static ExtensionList? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(ExtensionList? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList, new()
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