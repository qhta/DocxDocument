using DocumentModel.WebExtensions.UI;
using Taskpanes = DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes;

namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
///   Defines the Taskpanes Class.
/// </summary>
public static class TaskpanesConverter
{
  public static Collection<WebExtensionTaskpane>? GetWebExtensionTaskpanes(Taskpanes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<WebExtensionTaskpane>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>())
      {
        var newItem = WebExtensionTaskpaneConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetWebExtensionTaskpanes(Taskpanes? openXmlElement, Collection<WebExtensionTaskpane>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = WebExtensionTaskpaneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.WebExtensions.UI.Taskpanes? CreateModelElement(Taskpanes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.UI.Taskpanes();
      value.WebExtensionTaskpanes = GetWebExtensionTaskpanes(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.UI.Taskpanes? value)
    where OpenXmlElementType : Taskpanes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWebExtensionTaskpanes(openXmlElement, value?.WebExtensionTaskpanes);
      return openXmlElement;
    }
    return default;
  }
}