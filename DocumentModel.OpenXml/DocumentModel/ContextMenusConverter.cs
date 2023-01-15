namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the ContextMenus Class.
/// </summary>
public static class ContextMenusConverter
{
  public static Collection<ContextMenu>? GetItems(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ContextMenu>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>())
      {
        var newItem = ContextMenuConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus? openXmlElement, Collection<ContextMenu>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ContextMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static ContextMenus? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new ContextMenus();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(ContextMenus? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}