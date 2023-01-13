namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Rule List.
/// </summary>
public static class RuleListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Rule>? GetRules(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Rule>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.RuleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetRules(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Rule>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.RuleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.RuleList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.RuleList();
      value.Rules = GetRules(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.RuleList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.RuleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRules(openXmlElement, value?.Rules);
      return openXmlElement;
    }
    return default;
  }
}
