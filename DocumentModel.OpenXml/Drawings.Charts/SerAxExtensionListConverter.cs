using DocumentModel.Drawings.Charts;
using SerAxExtensionList = DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the SerAxExtensionList Class.
/// </summary>
public static class SerAxExtensionListConverter
{
  public static Collection<SerAxExtension>? GetSerAxExtensions(SerAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SerAxExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension>())
      {
        var newItem = SerAxExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSerAxExtensions(SerAxExtensionList? openXmlElement, Collection<SerAxExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = SerAxExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.SerAxExtensionList? CreateModelElement(SerAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SerAxExtensionList();
      value.SerAxExtensions = GetSerAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SerAxExtensionList? value)
    where OpenXmlElementType : SerAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSerAxExtensions(openXmlElement, value?.SerAxExtensions);
      return openXmlElement;
    }
    return default;
  }
}