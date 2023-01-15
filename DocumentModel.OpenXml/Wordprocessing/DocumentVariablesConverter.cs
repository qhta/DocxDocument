using DocumentModel.Wordprocessing;
using DocumentVariables = DocumentFormat.OpenXml.Wordprocessing.DocumentVariables;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Document Variables.
/// </summary>
public static class DocumentVariablesConverter
{
  public static Collection<DocumentVariable>? GetItems(DocumentVariables? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DocumentVariable>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.DocumentVariable>())
      {
        var newItem = DocumentVariableConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(DocumentVariables? openXmlElement, Collection<DocumentVariable>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.DocumentVariable>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DocumentVariableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentVariable>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.DocumentVariables? CreateModelElement(DocumentVariables? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocumentVariables();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocumentVariables? value)
    where OpenXmlElementType : DocumentVariables, new()
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