using DocumentModel.Drawings;
using LinePropertiesExtensionList = DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Future extensions..
/// </summary>
public static class LinePropertiesExtensionListConverter
{
  public static Collection<LinePropertiesExtension>? GetLinePropertiesExtensions(LinePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<LinePropertiesExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>())
      {
        var newItem = LinePropertiesExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLinePropertiesExtensions(LinePropertiesExtensionList? openXmlElement, Collection<LinePropertiesExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = LinePropertiesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.LinePropertiesExtensionList? CreateModelElement(LinePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinePropertiesExtensionList();
      value.LinePropertiesExtensions = GetLinePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LinePropertiesExtensionList? value)
    where OpenXmlElementType : LinePropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLinePropertiesExtensions(openXmlElement, value?.LinePropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}