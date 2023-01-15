namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  public static Collection<DocumentModel.Drawings.Charts.Extension>? GetExtensions(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DocumentModel.Drawings.Charts.Extension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Extension>())
      {
        var newItem = ExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetExtensions(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList? openXmlElement, Collection<DocumentModel.Drawings.Charts.Extension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Extension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Extension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.ExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ExtensionList? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Drawing.Charts.ExtensionList, new()
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