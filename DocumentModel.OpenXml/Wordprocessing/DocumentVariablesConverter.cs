namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Variables.
/// </summary>
public static class DocumentVariablesConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.DocumentVariable>? GetItems(DocumentFormat.OpenXml.Wordprocessing.DocumentVariables? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.DocumentVariable>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.DocumentVariable>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.DocumentVariableConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Wordprocessing.DocumentVariables? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.DocumentVariable>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.DocumentVariable>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.DocumentVariableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentVariable>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DocumentVariables? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DocumentVariables? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DocumentVariables, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
