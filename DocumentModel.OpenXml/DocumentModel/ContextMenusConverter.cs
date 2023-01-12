namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextMenus Class.
/// </summary>
public static class ContextMenusConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.ContextMenu>? GetItems(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.ContextMenu>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>())
      {
        var newItem = DocumentModel.OpenXml.ContextMenuConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.ContextMenu>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.ContextMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.ContextMenus? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ContextMenus();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.ContextMenus? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
