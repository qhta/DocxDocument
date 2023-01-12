namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
/// Defines the Taskpanes Class.
/// </summary>
public static class TaskpanesConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane>? GetWebExtensionTaskpanes(DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>())
      {
        var newItem = DocumentModel.OpenXml.WebExtensions.UI.WebExtensionTaskpaneConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetWebExtensionTaskpanes(DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.WebExtensions.UI.WebExtensionTaskpane>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.WebExtensions.UI.WebExtensionTaskpaneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.WebExtensions.UI.Taskpanes? CreateModelElement(DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
