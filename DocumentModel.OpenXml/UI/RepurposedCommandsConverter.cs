namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the RepurposedCommands Class.
/// </summary>
public static class RepurposedCommandsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.UI.RepurposedCommand>? GetItems(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.UI.RepurposedCommand>? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
