namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommands Class.
/// </summary>
public static class AllocatedCommandsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AllocatedCommand>? GetItems(DocumentFormat.OpenXml.Office.Word.AllocatedCommands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AllocatedCommand>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.AllocatedCommandConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office.Word.AllocatedCommands? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AllocatedCommand>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.AllocatedCommandConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.AllocatedCommands? CreateModelElement(DocumentFormat.OpenXml.Office.Word.AllocatedCommands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AllocatedCommands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AllocatedCommands? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.AllocatedCommands, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
