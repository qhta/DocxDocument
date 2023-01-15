using DocumentModel.UI;
using RepurposedCommands = DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands;

namespace DocumentModel.OpenXml.UI;

/// <summary>
///   Defines the RepurposedCommands Class.
/// </summary>
public static class RepurposedCommandsConverter
{
  public static Collection<RepurposedCommand>? GetItems(RepurposedCommands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<RepurposedCommand>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>())
      {
        var newItem = RepurposedCommandConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(RepurposedCommands? openXmlElement, Collection<RepurposedCommand>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = RepurposedCommandConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.UI.RepurposedCommands? CreateModelElement(RepurposedCommands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.RepurposedCommands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.RepurposedCommands? value)
    where OpenXmlElementType : RepurposedCommands, new()
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