using DocumentModel.Wordprocessing;
using AllocatedCommands = DocumentFormat.OpenXml.Office.Word.AllocatedCommands;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the AllocatedCommands Class.
/// </summary>
public static class AllocatedCommandsConverter
{
  public static Collection<AllocatedCommand>? GetItems(AllocatedCommands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<AllocatedCommand>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>())
      {
        var newItem = AllocatedCommandConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(AllocatedCommands? openXmlElement, Collection<AllocatedCommand>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = AllocatedCommandConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.AllocatedCommands? CreateModelElement(AllocatedCommands? openXmlElement)
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
    where OpenXmlElementType : AllocatedCommands, new()
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