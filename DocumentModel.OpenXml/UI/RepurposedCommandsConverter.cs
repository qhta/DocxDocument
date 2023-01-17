namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the RepurposedCommands Class.
/// </summary>
public static class RepurposedCommandsConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.UI.RepurposedCommand> GetItems(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.UI.RepurposedCommand>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>())
    {
      var newItem = DocumentModel.OpenXml.UI.RepurposedCommandConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.UI.RepurposedCommand>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.UI.RepurposedCommandConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.UI.RepurposedCommands? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands, new()
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
